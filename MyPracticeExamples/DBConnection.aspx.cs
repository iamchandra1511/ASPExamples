using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyPracticeExamples
{
    public partial class DBConnection : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=MyDB;Trusted_Connection=true;");
                con.Open();
                TextBox1.Focus();
                
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string gender = TextBox2.Text;
            command = new SqlCommand("insert into dbo.personal values('"+name+"','"+gender+"')", con);
            command.ExecuteNonQuery();
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}