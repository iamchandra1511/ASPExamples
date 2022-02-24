using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class Datagrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("ID");
            table.Columns.Add("Gender");
            table.Rows.Add("chandra", "101", "Male");
            table.Rows.Add("Rama", "101", "Male");
            table.Rows.Add("Kumar", "101", "Male");
            grid.DataSource = table;
            grid.DataBind();

        }

        
    }
}