using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class HiddenField : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_click(object sender, EventArgs e)
        {
            count = int.Parse(hidden.Value);
            count += 1;
            Response.Write(count);
            hidden.Value = count.ToString();

        }
    }
}