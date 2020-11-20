using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class querystring1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //? تدل على بداية ال querystring 
            // ثم نضع اسم querystring ثم قيمته
            Response.Redirect("~/querystring2.aspx?UserName= " + txtname.Text + "&UserE-mail= " + txtemail.Text);
        }
    }
}