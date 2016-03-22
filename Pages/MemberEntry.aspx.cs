using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Pages_LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //con.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True";
        //con.Open();

        //SqlCommand cmd = new SqlCommand();
        //cmd.CommandText = "insert into Meal (Stu_id,Name) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "') ";
        //cmd.Connection = con;
        //cmd.ExecuteNonQuery();

        //con.Close();
        //cmd.CommandText = "insert into Bazar values";
        //cmd.ExecuteNonQuery();

                       // Isert Meal table Values
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True";
        con.Open();

        string insert = "insert into Meal(Stu_id,Name,Meal,Date) values ('" + txtStuID.Text + "', '" + txtName.Text + "', '" + txtMeal.Text+ "', '" + Calendar1.SelectedDate + "')";
        SqlCommand cmd = new SqlCommand(insert, con);
        cmd.ExecuteNonQuery();


                        // Insert into Bazar Table

        string insertBa = "insert into Bazar(Stu_id,Name,Bazar,Date) values ('" + txtStuID.Text + "', '" + txtName.Text + "', '" + txtBazar.Text + "', '" + Calendar1.SelectedDate + "')";
        SqlCommand cmdBa = new SqlCommand(insertBa, con);
        cmdBa.ExecuteNonQuery();




        con.Close();
        Response.Write("Inserted Successfully");
        


    }
}