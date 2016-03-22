using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Pages_ShowAll : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1StudentID_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Connection With Database
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True";
        con.Open();

        string select = "select * from Meal";
        SqlCommand cmd = new SqlCommand(select, con);
  

        SqlDataReader DR1 = cmd.ExecuteReader();
        if (DR1.Read())
        {
            TextBox1StudentID.Text = DR1.GetValue(1).ToString();
            TextBoxName.Text = DR1.GetValue(2).ToString();
            TextBoxMeal.Text = DR1.GetValue(3).ToString();
            TextBoxDate.Text = DR1.GetValue(4).ToString();
        }
        else
        {
            Response.Write("Not reached");
        }

        con.Close();
        Response.Write("its all right");
    }

    protected void Button2ShowResult_Click(object sender, EventArgs e)
    {
        // connection with database
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True";
        
        conn.Open();

        // select studentId and check it (existing in database or not)

        string studentIdCheck = "select count(*) from  Meal where Stu_id = '" + TextBox1stID.Text + "'";
        SqlCommand checkcmd = new SqlCommand(studentIdCheck, conn);
        int temp = Convert.ToInt32(checkcmd.ExecuteScalar().ToString());
        conn.Close();

        if (temp > 0)
        {

            conn.Open();
            // select Student Id from Meal table and Check it UserInput of studentId value

            string selectStudentId = "select Stu_id,Name from Meal where Meal.Stu_id = '" + TextBox1stID.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(selectStudentId, conn);
            SqlDataReader sdr = sqlcmd.ExecuteReader();

            if (sdr.Read())
            {
                // insert studentId and Student Name into the textBox
                txtStudentID.Text = sdr.GetValue(0).ToString();
                txtStudentName.Text = sdr.GetValue(1).ToString();

            }
            else
            {
                Response.Write("Check your StudentID and StudentName");
            }
            conn.Close();

            conn.Open();
            // select Total Meal and insert into TotalMeal textBox
      
            string totalMeal = "select sum(cast(Meal as float)) from Meal where Meal.Stu_id = '" + TextBox1stID.Text + "';";
            SqlCommand cmdTotalMeal = new SqlCommand(totalMeal, conn);
            SqlDataReader sdrTotalMeal = cmdTotalMeal.ExecuteReader();

            if (sdrTotalMeal.Read())
            {
                txtStudentMeal.Text = sdrTotalMeal.GetValue(0).ToString();
            }
            else
            {
                Response.Write("Check your Total_Meal ");
            }

            conn.Close();


            conn.Open();
            // Select total_bazar of a student and insert into TotalBazar textBox
            string totalBazar = "select sum(cast(Bazar as int)) from Bazar where Bazar.Stu_id = '" + TextBox1stID.Text + "'";
            SqlCommand cmdtotalBazar = new SqlCommand(totalBazar, conn);
            SqlDataReader sdrTotalBazar = cmdtotalBazar.ExecuteReader();
            if (sdrTotalBazar.Read())
            {
                txtStudentBazar.Text = sdrTotalBazar.GetValue(0).ToString();        
            }
            else
            {
                Response.Write("Check your TotalBazar System");
            }

            conn.Close();

        }
        else
        {
            Response.Write("StudentID is not matched...Please Check :)");
        }

        conn.Close();
    }
}