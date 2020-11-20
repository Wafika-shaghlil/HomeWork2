using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class Session2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Name"] != null)
            { 
            //هنا قمنا بتخزين نص بداخله فإذا هو يتعامل مع ال object فنحوله لنص
            lblname.Text = Session["Name"].ToString();
            }
            if (Session["E-mail"] != null)
            {
                lblEmail.Text = Session["E-mail"].ToString();
            }
        }
    }
}