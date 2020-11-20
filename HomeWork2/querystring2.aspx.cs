using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class querystring2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblname.Text = Request.QueryString["UserName"];
            lblemail.Text = Request.QueryString["UserE-mail"];

        }
    }
}