using System;
using System.Data.SqlClient;
using System.Data;
namespace Connection_architecture_Ans4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-957D9AD;Initial Catalog=myDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = bindGrid();
            GridViewEmp.DataSource = ds;
            GridViewEmp.DataBind();
            demo();
        }
        public DataSet bindGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;

        }
        public void demo()
        {
            SqlCommand cmd = new SqlCommand("select EmpName,Mobile from Employee", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Response.Write(rdr["EmpName"].ToString());
                    Response.Write(rdr["Mobile"].ToString());
                    
                   // Response.Write("<script language=javascript>console.log(rdr);</script>");
                }
            }
            else
            {
                Console.WriteLine("Record not found.");
            }
                con.Close();
        }
    }

}