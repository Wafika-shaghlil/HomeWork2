using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class Application2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Application["Name"] != null)
            {
                lblname.Text = Application["Name"].ToString();
            }
            if (Application["E-mail"] != null)
            {
                lblEmail.Text = Application["E-mail"].ToString();

            }

        }
    }
}