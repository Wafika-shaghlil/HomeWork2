using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class cookies1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //سوف نمرر فقط الاسم لأنه يتعامل مع أكثر من قيمة
            HttpCookie cooki = new HttpCookie("UserInfo");
            cooki["Name"] = txtname.Text;
            cooki["E-mail"] = txtemail.Text;
            //يتم تخزينها والاحتفاظ بالكوكيز لغاية 30 يوم
            cooki.Expires = DateTime.Now.AddDays(30);
            //Add تأخذ قيمة من النوع httpcookie لذلك نمرر له بارامتر الكائن الذي أنشأناه
            Response.Cookies.Add(cooki);
            Response.Redirect("~/cookies2.aspx");
        }
    }
}