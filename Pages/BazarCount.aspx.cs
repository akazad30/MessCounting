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



public partial class Pages_BazarCount : System.Web.UI.Page
{
    StringBuilder table = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=KALAM-PC\SQLEXPRESS;Initial Catalog=HeaveNet;Integrated Security=True;MultipleActiveResultSets=true";
            con.Open();
            SqlCommand cmd = new SqlCommand();

            //................ Insert value(Meal) for Abul Kalam Azad ............................

            cmd.CommandText = "select Bazar,Date from Bazar where Bazar.Name = 'Abul Kalam Azad' order by Date asc";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();

            //............. insert value for Kalam,,,,,,,,,,,,,,,,


            SqlCommand cmdKalam = new SqlCommand();
            cmdKalam.CommandText = "select Bazar,Date from Bazar where Bazar.Name = 'Kalam' order by Date asc";
            cmdKalam.Connection = con;
            SqlDataReader rdKalam = cmdKalam.ExecuteReader();

            // .................. insert for james................

            SqlCommand cmdjames = new SqlCommand();
            cmdjames.CommandText = "select Bazar,Date from Bazar where Bazar.Name = 'james' order by Date asc";
            cmdjames.Connection = con;
            SqlDataReader rdjames = cmdjames.ExecuteReader();

            //...............insert for Bond....................

            SqlCommand cmdBond = new SqlCommand();
            cmdBond.CommandText = "select Bazar,Date from Bazar where Bazar.Name = 'Bond' order by Date asc";
            cmdBond.Connection = con;
            SqlDataReader rdBond = cmdBond.ExecuteReader();

            //  ............. insert for Azad................

            SqlCommand cmdAzad = new SqlCommand();
            cmdAzad.CommandText = "select Bazar,Date from Bazar where Bazar.Name = 'Azad' order by Date asc";
            cmdAzad.Connection = con;
            SqlDataReader rdAzad = cmdAzad.ExecuteReader();

            // ............... Table Creation.................

            table.Append("<table border = '2' bgcolor='#E4A484' CELLPADDING='4' CELLSPACING='4' width='200px'>");


            //............... show Meal for Kalam..................

            table.Append("<tr><th style = 'width:50px;height:50px;background-color:gray'>Kalam</th>");
            if (rdKalam.HasRows)
            {
                while (rdKalam.Read())
                {
                    table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Bazar:" + rdKalam[0] +"TK"+ " Date :" + '(' + rdKalam[1] + ')' + "</td>"); ;
                }

            }

            table.Append("</tr>");

            //............... show Meal for Abul Kalam Azad Kalam..................

            table.Append("<tr><th  style = 'width:50px;height:50px;background-color:gray'>Abul Kalam Azad</th>");

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Bazar:" + rd[0] + "TK" + " Date :" + '(' + rd[1] + ')' + "</td>"); ;
                }
            }

            table.Append("</tr>");

            //............... show Meal for Bond..................

            table.Append("<tr><th  style = 'width:50px;height:50px;background-color:gray'>Bond</th>");
            if (rdBond.HasRows)
            {
                while (rdBond.Read())
                {

                    table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Bazar :" + rdBond[0] + "TK" + " Date :" + '(' + rdBond[1] + ')' + "</td>");
                }

            }
            table.Append("</tr>");

            //............... show Meal for james..................

            table.Append("<tr><th  style = 'width:50px;height:50px;background-color:gray'>James</th>");
            if (rdjames.HasRows)
            {
                while (rdjames.Read())
                {
                    table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Bazar :" + rdjames[0] + "TK" + " Date :" + '(' + rdjames[1] + ')' + "</td>");
                }

            }
            table.Append("</tr>");

            //............... show Meal for Azad..................

            table.Append("<tr><th  style = 'width:50px;height:50px;background-color:gray'>Azad</th>");
            if (rdAzad.HasRows)
            {
                while (rdAzad.Read())
                {
                    table.Append("<td style = 'width:20px;background-color:#915C74'>" + " Bazar :" + rdAzad[0] + "TK" + " Date :" + '(' + rdAzad[1] + ')' + "</td>");
                }

            }

            table.Append("</tr>");

            table.Append("</table>");
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

        }

    }
}