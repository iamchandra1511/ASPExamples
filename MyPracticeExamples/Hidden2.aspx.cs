using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class Hidden2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String value = Request.Form["hidden"];
            Response.Write(value);
        }
    }
}