﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string value = TextBox1.Text;
            Response.Write("Asp Control:" + value);
            string value1 = Request.Form["TextBox2"];
            Response.Write("Html Control:" + value1);
        }
    }
}