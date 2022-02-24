using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cal_SelectionChanged(object sender, EventArgs e)
        {
            string selecteddate=cal.SelectedDate.ToString();
            label.Text = selecteddate;
        }
    }
}