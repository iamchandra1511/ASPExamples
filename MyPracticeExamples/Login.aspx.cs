using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            username.Focus();

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
                Server.Transfer("Success.aspx");
            else
                Server.Transfer("Fail.aspx");
        }
    }
}