using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SQLInjection_Ans5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-957D9AD;Initial Catalog=myDB;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        public void BindGrid()
        {
            using (SqlCommand cmd = new SqlCommand("GetAllEmployee", con))
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                GridViewEmpList.DataSource = ds;
                GridViewEmpList.DataBind();
                con.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int i = UpdateEmp();
                if (i != 0)
                {
                    Response.Write("<script>alert('Updated successfully')</script>");
                    BindGrid();

                }
                else
                {
                    Response.Write("<script>alert('Updation failed.')");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Entry')");
            }

           

        }
        public int UpdateEmp()
        {
            int i = 0;
            using (SqlCommand cmd = new SqlCommand("Usp_EmpAddress", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Addr", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Id", ddlEmp.SelectedValue);
                i = cmd.ExecuteNonQuery();
                con.Close();
            }
            return i;
        }
    }
}