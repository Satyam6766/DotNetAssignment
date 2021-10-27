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
    public partial class WebForm2 : System.Web.UI.Page
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
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            GridViewCourse.DataSource = ds;
            GridViewCourse.DataBind();


        }
        private void BindCountry()
        {
            SqlCommand cmd = new SqlCommand("select * from Country", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            GridViewCountry.DataSource = ds;
            GridViewCountry.DataBind();


        }
        private void BindEmployee()
        {
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            GridViewEmployee.DataSource = ds;
            GridViewEmployee.DataBind();


        }
    }
}