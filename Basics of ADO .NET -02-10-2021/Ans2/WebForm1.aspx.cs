using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Ans2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        static string strcon = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        protected void Page_Load(object sender, EventArgs e)
        {
            BindEmployee();
            BindCountry();
            BindCourse();
        }
        private void BindCourse()
        {
            SqlCommand cmd = new SqlCommand("select * from Course", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridViewCourse.DataSource = rdr;
            GridViewCourse.DataBind();
            con.Close();

        }
        private void BindCountry()
        {
            SqlCommand cmd = new SqlCommand("select * from Country", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridViewCountry.DataSource = rdr;
            GridViewCountry.DataBind();
            con.Close();

        }
        private void BindEmployee()
        {
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridViewEmployee.DataSource = rdr;
            GridViewEmployee.DataBind();
            con.Close();

        }
    }
}


