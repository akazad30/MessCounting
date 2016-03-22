using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Pages_LogInPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1Name.Text;

        string password = TextBox2Pass.Text;

        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True;MultipleActiveResultSets=true";

        con.Open();
        SqlCommand check_User_Names = new SqlCommand("SELECT count([Name]) FROM Regirstration WHERE ([Name] = '" + TextBox1Name.Text + "') ", con);

        int UserExist1 = (int)check_User_Names.ExecuteScalar();

        if (UserExist1 == 1)
        {
            //The Id is already Exist.......
            // Response.Write("This Dept already exist");
            // conn.Open();

            string query = "select Password from Regirstration where Name = '" + TextBox1Name.Text + "'";
            SqlCommand passCom = new SqlCommand(query, con);
            string passwrd = passCom.ExecuteScalar().ToString().Replace(" ", "");
            if (passwrd == TextBox2Pass.Text)
            {
                Session["New"] = TextBox1Name.Text;
                Response.Write("Passsword and userName is coorect");
                Response.Redirect("AfterLogInMainPage.aspx");
            }
            else
            {
                Response.Write("Password is not correct");
                //Response.Redirect("Registration.aspx");
            }


            con.Close();

        }

        else
        {
            Response.Write("You are not registered.. <a href='RegistrationPage.aspx'> Fill Up Registration Form");
          // Response.Redirect("RegistrationPage.aspx");
        }

    }
}