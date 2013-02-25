using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try { if (Session["date"].ToString() == null);if (Session["ID"].ToString() == null);}
        catch{ Server.Transfer("Advisor.aspx"); }
        
        int advisorId = Convert.ToInt16(Session["ID"].ToString());
        string date = Session["date"].ToString();
        ronUtil get = new ronUtil(advisorId);
        DateTime datev2 = DateTime.ParseExact(Session["date"].ToString(), "MM/dd/yyyy", null);             
        DateTime[] advisorAllSlots = get.getSlots(advisorId);
        DateTime[] taken = get.getTaken(advisorId, datev2.ToString("yyyy-MM-dd"));
        DateTime[] availibility = get.getAvailability(advisorAllSlots, taken);
        string[] shorttime = new string[availibility.Length];
        for (int i = 0; i < availibility.Length; i++)
        { shorttime[i] = availibility[i].ToShortTimeString(); }
        Label2.Text = get.FullName;
        Label3.Text = "AdvisorID:" + Session["ID"].ToString(); 
        Label1.Text = "Date:" + Session["date"].ToString();
        

        DropDownList1.DataSource = shorttime;
        if(!IsPostBack)
          {DropDownList1.DataBind();}
        

        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int advisorId = Convert.ToInt16(Session["ID"].ToString());
        string date = Session["date"].ToString();
        
        DateTime datev2 = DateTime.ParseExact(Session["date"].ToString(), "MM/dd/yyyy", null);

        

        DateTime picked = new DateTime();
        picked = DateTime.ParseExact(DropDownList1.SelectedValue.ToString(), "h:mm tt", CultureInfo.InvariantCulture);

        int Student_Id = 822459073;
        int Advisor_Id = Convert.ToInt16(Session["ID"].ToString());
        string Time = picked.ToString("HH:mm:ss");
        string Date = datev2.ToString("yyyy-MM-dd");
        Label1.Text = Time;
        int Completed = 0;
        string sqlQuery = "INSERT INTO Scheduling (Student_Id,Advisor_Id,Time,Date,Completed)";
        sqlQuery += " VALUES (@Student_Id,@Advisor_Id,@Time,@Date,@Completed)";
        string connectionString = ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();
        using (SqlConnection dataConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand dataCommand = new SqlCommand(sqlQuery, dataConnection))
            {

                dataCommand.Parameters.AddWithValue("Student_Id", Student_Id);
                dataCommand.Parameters.AddWithValue("Advisor_Id", Advisor_Id);
                dataCommand.Parameters.AddWithValue("Time", Time);
                dataCommand.Parameters.AddWithValue("Date", Date);
                dataCommand.Parameters.AddWithValue("Completed", Completed);


                dataConnection.Open();
                dataCommand.ExecuteNonQuery();
                dataConnection.Close();
            }
        }

        Response.Write("<script type='text/javascript'>alert('You are booked');</script>");
        Server.Transfer("Advisor.aspx");

    }
}
