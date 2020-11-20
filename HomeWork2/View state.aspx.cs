using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class View_state : System.Web.UI.Page
    {
        static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count += 1;
            TextBox1.Text = count.ToString();
        }
    }
}