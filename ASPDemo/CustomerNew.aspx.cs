using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDemo
{
    public partial class CustomerNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            IUBAT13wfa.DAL.Country ctm = new IUBAT13wfa.DAL.Country();
            ddlCity.DataSource = ctm.Select().Tables[0];
            ddlCity.DataTextField = "name";
            ddlCity.DataValueField = "id";

            ddlCity.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblEName.Text = "";
            lblEContact.Text = "";
            lblEEmail.Text = "";
            lblEGender.Text = "";
            lblEAddress.Text = "";
            lblECity.Text = "";

            lblMessage.Text = "";


            int er = 0;

            if (txtName.Text == "")
            {
                er++;
                lblEName.Text = "Required";
            }
            if (txtContact.Text == "")
            {
                er++;
                lblEContact.Text = "Required";
            }
            if (txtEmail.Text == "")
            {
                er++;
                lblEEmail.Text = "Required";
            }
            if (txtAddress.Text == "")
            {
                er++;
                lblEAddress.Text = "Required";
            }

            if (ddlGender.SelectedIndex == 0)
            {
                er++;
                lblEGender.Text = "Required";
            }
            if (ddlCity.SelectedIndex == 0)
            {
                er++;
                lblECity.Text = "Required";
            }
            if (er > 0)
                return;

            IUBAT13wfa.DAL.Customer ctm = new IUBAT13wfa.DAL.Customer();
            ctm.Name = txtName.Text;
            ctm.Contact = txtContact.Text;
            ctm.Email = txtEmail.Text;
           // ctm.Gender = Convert.ToInt32(ddlGender.SelectedValue); 
            ctm.Address = txtAddress.Text;
            ctm.CityId = Convert.ToInt32(ddlCity.SelectedValue);

            if (ctm.Insert())
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Customer Inserted";
                txtName.Text = "";
                ddlCity.SelectedIndex = 0;
                txtName.Focus();
            }
            else
            {
                lblMessage.Text = ctm.Error;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            ddlGender.SelectedIndex = 0;
            lblEName.Text = "";
            lblEContact.Text = "";
            lblEEmail.Text = "";
            lblEGender.Text = "";
            lblEAddress.Text = "";
            lblECity.Text = "";
            lblMessage.Text = "";
            txtName.Focus();
        }
    }
}