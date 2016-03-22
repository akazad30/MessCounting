using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;



public partial class Pages_Check : System.Web.UI.Page
{
    StringBuilder table = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True;MultipleActiveResultSets=true";
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand();

        //    ................ Insert value(Meal) for Abul Kalam Azad ............................

        //    cmd.CommandText = "select Meal,Date from Meal where Meal.Name = 'Abul Kalam Azad' order by Date asc";
        //    cmd.Connection = con;
        //    SqlDataReader rd = cmd.ExecuteReader();

        //    ............. insert value for Kalam,,,,,,,,,,,,,,,,


        //    SqlCommand cmdKalam = new SqlCommand();
        //    cmdKalam.CommandText = "select Meal,Date from Meal where Meal.Name = '" + TextBox1.Text + "' order by Date asc";
        //    cmdKalam.Connection = con;
        //    SqlDataReader rdKalam = cmdKalam.ExecuteReader();

        //     .................. insert for james................

        //    SqlCommand cmdjames = new SqlCommand();
        //    cmdjames.CommandText = "select Meal,Date from Meal where Meal.Name = 'james' order by Date asc";
        //    cmdjames.Connection = con;
        //    SqlDataReader rdjames = cmdjames.ExecuteReader();

        //    ...............insert for Bond....................

        //    SqlCommand cmdBond = new SqlCommand();
        //    cmdBond.CommandText = "select Meal,Date from Meal where Meal.Name = 'Bond' order by Date asc";
        //    cmdBond.Connection = con;
        //    SqlDataReader rdBond = cmdBond.ExecuteReader();

        //      ............. insert for Azad................

        //    SqlCommand cmdAzad = new SqlCommand();
        //    cmdAzad.CommandText = "select Meal,Date from Meal where Meal.Name = 'Azad' order by Date asc";
        //    cmdAzad.Connection = con;
        //    SqlDataReader rdAzad = cmdAzad.ExecuteReader();

        //     ............... Table Creation.................

        //    table.Append("<table border = '2' bgcolor='#E4A484' CELLPADDING='4' CELLSPACING='4' width='200px'>");


        //    ............... show Meal for Kalam..................

        //    table.Append("<tr><th style = 'width:50px;height:50px;background-color:gray'>'"+TextBox1.Text+"'</th>");
        //    if (rdKalam.HasRows)
        //    {
        //        while (rdKalam.Read())
        //        {
        //            table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Meal :" + rdKalam[0] + " Date :" + '(' + rdKalam[1] + ')' + "</td>"); ;
        //        }

        //    }

        //    table.Append("</tr>");

        //    //............... show Meal for Abul Kalam Azad Kalam..................

        //    table.Append("<tr><th  style = 'width:50px;height:50px;background-color:gray'>Abul Kalam Azad</th>");

        //    if (rd.HasRows)
        //    {
        //        while (rd.Read())
        //        {
        //            table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Meal :" + rd[0] + " Date :" + '(' + rd[1] + ')' + "</td>"); ;
        //        }
        //    }

        //    table.Append("</tr>");

        //    //............... show Meal for Bond..................

        //    table.Append("<tr><th  style = 'width:50px;height:50px;background-color:gray'>Bond</th>");
        //    if (rdBond.HasRows)
        //    {
        //        while (rdBond.Read())
        //        {

        //            table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Meal :" + rdBond[0] + " Date :" + '(' + rdBond[1] + ')' + "</td>");
        //        }

        //    }
        //    table.Append("</tr>");

        //    //............... show Meal for james..................

        //    table.Append("<tr><th  style = 'width:50px;height:50px;background-color:gray'>James</th>");
        //    if (rdjames.HasRows)
        //    {
        //        while (rdjames.Read())
        //        {
        //            table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Meal :" + rdjames[0] + " Date :" + '(' + rdjames[1] + ')' + "</td>");
        //        }

        //    }
        //    table.Append("</tr>");

        //    //............... show Meal for Azad..................

        //    table.Append("<tr><th  style = 'width:50px;height:50px;background-color:gray'>Azad</th>");
        //    if (rdAzad.HasRows)
        //    {
        //        while (rdAzad.Read())
        //        {
        //            table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Meal :" + rdAzad[0] + " Date :" + '(' + rdAzad[1] + ')' + "</td>");
        //        }

        //    }

        //    table.Append("</tr>");

        //    table.Append("</table>");
        //    PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

       // }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True;MultipleActiveResultSets=true";
        con.Open();
        SqlCommand cmd = new SqlCommand();

        SqlCommand cmdKalam = new SqlCommand();
        cmdKalam.CommandText = "select Meal,Date from Meal where Meal.Name = '" + TextBox1.Text + "' order by Date asc";
        cmdKalam.Connection = con;
        SqlDataReader rdKalam = cmdKalam.ExecuteReader();


        cmd.CommandText = "select Meal,Date from Meal where Meal.Name = '"+TextBox2.Text+"' order by Date asc";
        cmd.Connection = con;
        SqlDataReader rd = cmd.ExecuteReader();


         

        table.Append("<table border = '1' bgcolor='#E4A484' CELLPADDING='1' CELLSPACING='1' width='500px' height:'800px'>");


        //............... show Meal for Kalam..................
        
        table.Append("<tr><th style = 'width:50px;height:50px;background-color:gray'>'" + TextBox1.Text + "'</th>");
        if (rdKalam.HasRows)
        {
            while (rdKalam.Read())
            {
                table.Append("<td style = 'width:5px; heigth:1px;background-color:#915C74'>" + " Meal :" + rdKalam[0] + " Date :" + '(' + rdKalam[1] + ')' + "</td>"); 

            }


        }

        table.Append("</tr>");

        table.Append("<tr><th style = 'width:50px;height:50px;background-color:gray'>'" + TextBox2.Text + "'</th>");
        if (rd.HasRows)
        {
            while (rd.Read())
            {
                table.Append("<td style = 'width:5px; heigth:1px;background-color:#915C74'>" + " Meal :" + rd[0] + " Date :" + '(' + rd[1] + ')' + "</td>");

            }


        }

        table.Append("</tr>");

       table.Append("</table>");
       PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
    }
}