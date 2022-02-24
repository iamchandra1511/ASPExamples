using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (password.Text != null && username.Text != null)
            {
                Session["username"] = username.Text;
                Session["password"] = password.Text;
                Response.Write("Data added to the session");
            }
            else
                Response.Write("session doen't created");
        }
    }
}