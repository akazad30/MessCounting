using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Pages_RegistrationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True;MultipleActiveResultSets=true";

        con.Open();

        SqlCommand check_User_Name = new SqlCommand("SELECT count([Stu_id]) FROM Regirstration WHERE ([Stu_id] = '" + txtID.Text + "') ", con);

        int UserExist = (int)check_User_Name.ExecuteScalar();

        if (UserExist == 1)
        {
            //The Id is already Exist.......
            Response.Write("This ID already exist");
        }


        else
        {
      
            
            string insertInfo = "insert into Regirstration (Stu_id,Name,Dept,ContactNo,Password) values (@Stu_id,@Name,@Dept,@ContactNo,@Password) ";

            SqlCommand cmd = new SqlCommand(insertInfo, con);
            cmd.Parameters.AddWithValue("@Stu_id", txtID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Dept", txtDept.Text);
            cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

            cmd.ExecuteNonQuery();
            Response.Write("Registration is successful <a href = 'LogInPage.aspx'> Now LOGIN");
           // Response.Redirect("LogInPage.aspx");
        }
      

            con.Close();
        }
      
  }
