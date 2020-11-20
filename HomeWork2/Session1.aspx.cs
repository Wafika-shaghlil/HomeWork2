using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class Session1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*هناك نوعان من Key 
            الأول String indexer
            الثاني integlar indexer
            */
            //هنا استعملنا String indexer
            Session["Name"] = txtname.Text;
            Session["E-mail"] = txtemail.Text;
            // قمنا بتخزين القيم في المتحولات 
            //والآن سوف نمرر القيم للصفحة الثانية 
            //~/ لكي نصل إلى ال root
            Response.Redirect("~/Session2.aspx");
        }
    }
}