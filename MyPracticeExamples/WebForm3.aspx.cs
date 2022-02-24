using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(this.IsPostBack);
            Response.Write("<br/>");
            if(this.IsPostBack==true)
            Response.Write("TextBox Value is:" + TextBox1.Text);
        }

        
    }
}