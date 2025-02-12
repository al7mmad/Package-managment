﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ICS321
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand com = new SqlCommand("login", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("UserName", Login1.UserName);
            SqlParameter p2 = new SqlParameter("Password", Login1.Password);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            con.Open();
            SqlDataReader rd = com.ExecuteReader();

            if (rd.HasRows)
            {
                rd.Read();
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true); 
                Response.Redirect("Default.aspx");
            }
            else
            {
                Login1.FailureText = "Invalid username or password.";
            }
        }
    }
}