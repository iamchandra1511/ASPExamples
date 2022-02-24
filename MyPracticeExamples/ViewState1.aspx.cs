using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class ViewState1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            int counter = 0;

            if (ViewState["counter"] == null)
                counter += 1;
            else
               counter=((int)ViewState["counter"]) + 1;
            ViewState["counter"] = counter;
            Response.Write(counter);
        }
    }
}