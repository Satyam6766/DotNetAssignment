using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Execute_Reader_Scalar_Ans3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BindGridViewEmp();
            countValue();

        }


        public void BindGridViewEmp()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-957D9AD;Initial Catalog=myDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridViewEmp.DataSource = rdr;
            GridViewEmp.DataBind();
            con.Close();
        }


        protected void GridViewEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdateAddress_Click(object sender, EventArgs e)
        {

            int i = 0;
            i=UpdateAddress();
            if (i != 0)
            {
                Response.Write("<Script>alert('Address updated successfully')</script>");
            }
            BindGridViewEmp();
            countValue();
        }
        public int UpdateAddress()
        {
            int i;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-957D9AD;Initial Catalog=myDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DemoExecuteNonQuery", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", lblEmpId.SelectedValue);
            cmd.Parameters.AddWithValue("@addrress",TxtAddress.Text);
            con.Open();
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public void countValue()
        {
            Object i;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-957D9AD;Initial Catalog=myDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select EmpName,Mobile from Employee", con);            
            con.Open();
            i = cmd.ExecuteScalar();
            con.Close();
            TxtCount.Text = i.ToString();
        }
    }
}