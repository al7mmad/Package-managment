using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ICS321
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
        protected void Regiester_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd = new SqlCommand("regLogin ", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", txtPhone.Text);

            Boolean uses; 
            if (RadioButton2.Checked)
            {
                uses = false; 
            }
            else 
            {
                uses = true; 
            }

            cmd.Parameters.AddWithValue("@useAs", uses);


            con.Open();
            int k = cmd.ExecuteNonQuery();
            if (k != 0)
            {
                lblmsg.Text = "Record Inserted Succesfully into the Database";
                lblmsg.ForeColor = System.Drawing.Color.CornflowerBlue;
            }
            con.Close();


            //redirect to anthoer page to complete registertion of employees  
            if (uses == false)
            {
                Response.Redirect("EmployeeRegsitertion.aspx");
            }

            //redirect to anthoer page to complete registertion of customer 
            else
            {
                Response.Redirect("CustomerRegsitertion.aspx");
            }
        }

        
        //protected void RadioButtonList1_TextChanged(object sender, EventArgs e)
        //{
        //    String seleValue = RadioButtonList1.SelectedIndex.ToString();

        //    System.Console.WriteLine(seleValue);


        //    if (seleValue == "Customer")
        //    {
        //        Label4.Visible = true;
        //        Label8.Visible = true;
        //        txtType.Visible = true;
        //        txtAddress.Visible = true;

        //    }
        //    else if (seleValue == "Employee")
        //    {
        //        Label6.Visible = true;
        //        Label7.Visible = true;
        //        txtSalary.Visible = true;
        //        txtPosition.Visible = true;
        //    }
        //}


        //protected void Login_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //    SqlCommand com = new SqlCommand("CUser", con);
        //    com.CommandType = System.Data.CommandType.StoredProcedure;
        //    SqlParameter p1 = new SqlParameter("Username", TextBox1.Text);
        //    SqlParameter p2 = new SqlParameter("Password", TextBox2.Text);
        //    com.Parameters.Add(p1);
        //    com.Parameters.Add(p2);
        //    con.Open();
        //    SqlDataReader rd = com.ExecuteReader();
        //    if (rd.HasRows)
        //    {
        //        rd.Read();
        //        lblmsg1.Text = "Login successful.";
        //        lblmsg1.Visible = true;
        //    }

        //    else
        //    {

        //        lblmsg1.Text = "Invalid username or password.";
        //        lblmsg1.Visible = true;
        //    }

        //}
    }
}