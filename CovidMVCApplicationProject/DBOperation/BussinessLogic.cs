using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using CovidMVCApplicationProject.DBOperation;
using CovidMVCApplicationProject.Models;
using System.Configuration;

namespace CovidMVCApplicationProject.DBOperation
{
    public class BussinessLogic
    {
        static string strcon = ConfigurationManager.ConnectionStrings["myConnectionstring"].ConnectionString;
        //create new sqlconnection and connection to database by using connection string from web.config file  
        SqlConnection con = new SqlConnection(strcon);

        public List<LoginModel> GetUserList()
        {
            List<LoginModel> loginModels = new List<LoginModel>();
            SqlCommand cmd = new SqlCommand("select email,password from LoginTable", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    LoginModel model = new LoginModel();
                    model.email = reader["email"].ToString();
                    model.password = reader["password"].ToString();
                    loginModels.Add(model);
                }
            }
            con.Close();
            return loginModels;
        }
        public string GetUsernameFromLoginTable(string email)
        {
            string firstName="", lastname="", name;

            SqlCommand cmd = new SqlCommand("SP_GetUsernameFromEmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    firstName = reader["fname"].ToString();
                    lastname = reader["lname"].ToString();
                }
               

            }
            con.Close();
            name = firstName + " " + lastname;
            return name;
        }

        public bool isValidUser(LoginModel loginModel)
        {
            bool response = false;
            List<LoginModel> list = GetUserList();
            foreach (var item in list)
            {
                if (item.email.ToLower().ToString() == loginModel.email.ToLower().ToString() && item.password.ToString() == loginModel.password.ToString())
                {
                    response = true;
                    break;
                }
            }
            return response;
        }

        public bool isValidRequest(UserRegisterModel userRegisterModel)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("SP_InsertUserLoginTable", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstName", userRegisterModel.firstName);
            cmd.Parameters.AddWithValue("@lastName", userRegisterModel.lastName);
            cmd.Parameters.AddWithValue("@email", userRegisterModel.email);
            cmd.Parameters.AddWithValue("@password", userRegisterModel.password);
            con.Open();
            i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
       
    }
}