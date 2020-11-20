using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class Application1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //لضمان دخول مستخدم واحد فقط
            Application.Lock();
            Application["Name"] = txtname.Text;
            Application.UnLock();
            Application.Lock();
            Application["E-mail"] = txtemail.Text;
            Application.UnLock();

            Response.Redirect("~/Application2.aspx");

        }
    }
}