﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork2
{
    public partial class cookies2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if(cookie != null)
            {
                lblname.Text = cookie["Name"];
                lblEmail.Text = cookie["E-mail"];
            }
            

        }
    }
}