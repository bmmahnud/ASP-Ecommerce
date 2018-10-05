using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDemo
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IUBAT13wfa.DAL.Customer ctm = new IUBAT13wfa.DAL.Customer();
            GridView1.DataSource = ctm.Select().Tables[0];

            GridView1.DataBind();
        }
    }
}