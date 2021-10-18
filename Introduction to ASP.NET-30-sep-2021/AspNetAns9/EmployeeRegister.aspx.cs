using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace AspNetAns9
{
    public partial class EmployeeRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetEmployees();
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string response = InsertEmployee();
                if (response == "Employee Record inserted Successdfully")
                {
                    lblStatus.Text = response;
                    lblStatus.Visible = true;
                    GetEmployees();
                }
                else
                {
                    lblStatus.Text = response;
                    lblStatus.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.Visible = true;
            }
        }
        private string InsertEmployee()
        {
            string str = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-957D9AD;Initial Catalog=myDB;Integrated Security=True");
            try
            {
                SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpName", txtName.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", txtDOB.Text);
                cmd.Parameters.AddWithValue("@Addr", txtAddress.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@ZIP", txtZipCode.Text);
                cmd.Parameters.AddWithValue("@IsActive", rblIsActive.SelectedValue);
                cmd.Parameters.AddWithValue("@CountryId", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@gender", rblGender.SelectedValue);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                str = "Employee Record inserted Successdfully";
            }
            catch (Exception ex)
            {
                str = "Inseertion Failed";
                throw ex;

            }
            finally
            {
                con.Close();
            }
            return str;
        }

        private void GetEmployees()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-957D9AD;Initial Catalog=myDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("GetEmployees", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            GridViewEmployee.DataSource = ds;
            GridViewEmployee.DataBind();
        }

    }
}