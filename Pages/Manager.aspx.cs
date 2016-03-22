using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Data.SqlClient;


public partial class Pages_Manager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("ok");        
        
        if (DropDownList1.SelectedIndex == 0)
        {
            Response.Write("Alas!!! I am Undone....PLZ SELECT A OPTION");
        }
        else  if (DropDownList1.SelectedIndex == 1)
        {

            Response.Redirect("MealCount.aspx");
            //MessageBox.Show("Hi");
        }
        else if(DropDownList1.SelectedIndex == 2)
        {
            Response.Redirect("BazarCount.aspx");
        }
   
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (DropDownList1.SelectedIndex == 0)
        //{
        //    Response.Write("Alas!!! I am Undone....PLZ SELECT A OPTION");
        //}
        //else  if (DropDownList1.SelectedIndex == 1)
        //{

        //    Response.Redirect("MealCount.aspx");
        //    //MessageBox.Show("Hi");
        //}
        //else if(DropDownList1.SelectedIndex == 2)
        //{
        //    Response.Redirect("BazarCount.aspx");
        //}
    
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowAll.aspx");
    }
}