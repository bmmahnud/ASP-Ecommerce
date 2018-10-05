using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDemo
{
    public partial class Country : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IUBAT13wfa.DAL.Country c = new IUBAT13wfa.DAL.Country();
            GridView1.DataSource = c.Select().Tables[0];

            GridView1.DataBind();
            
        }
    }
}