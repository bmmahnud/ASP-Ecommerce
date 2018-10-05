using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDemo
{
    public partial class CityNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
                return;

            IUBAT13wfa.DAL.Country c = new IUBAT13wfa.DAL.Country();
            ddlCountry.DataSource = c.Select().Tables[0];
            ddlCountry.DataTextField = "name";
            ddlCountry.DataValueField = "id";

            ddlCountry.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblEName.Text = "";
            lblECountry.Text = "";
            lblMessage.Text = "";

            int er = 0;

            if (txtName.Text == "")
            {
                er++;
                lblEName.Text = "Required";
            }

            if (ddlCountry.SelectedIndex == 0)
            {
                er++;
                lblECountry.Text = "Required";
            }
            if(er>0)
                return;


            IUBAT13wfa.DAL.City ct = new IUBAT13wfa.DAL.City();
            ct.Name = txtName.Text;
            ct.CountryId = Convert.ToInt32(ddlCountry.SelectedValue);

            if (ct.Insert())
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "City Inserted";
                txtName.Text = "";
                ddlCountry.SelectedIndex = 0;
                txtName.Focus();
            }
            else
            {
                lblMessage.Text = ct.Error;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            ddlCountry.SelectedIndex = 0;
            lblEName.Text = "";
            lblECountry.Text = "";
            lblMessage.Text = "";
            txtName.Focus();
        }
    }
}