using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDemo
{
    public partial class CountryNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblEName.Text = "";
            lblMessage.Text = "";
            int er = 0;
            if (txtName.Text == "")
            {
                er++;
                lblEName.Text = "Required";
            }

            if (er > 0)
            return;

            IUBAT13wfa.DAL.Country c = new IUBAT13wfa.DAL.Country();
            c.Name = txtName.Text;

            if (c.Insert())
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Country Inserted";
                txtName.Text = "";
                txtName.Focus();
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = c.Error;
            }
        }
    }
}