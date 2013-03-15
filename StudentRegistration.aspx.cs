﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.ComponentModel;
using System.Drawing;
using System.Text;

public partial class StudentRegistration : System.Web.UI.Page
{
    
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (PhotoUpload.HasFile)
        {
            PhotoUpload.SaveAs(MapPath("~\\StudentPhotoes\\" + txtStudentID.Text + System.IO.Path.GetExtension(PhotoUpload.FileName)));
            
        }
        String path = "\\StudentPhotoes\\" + txtStudentID.Text + ".jpeg";
        EmailConfirmation obj = new EmailConfirmation();
        DatabaseRegistration objdb = new DatabaseRegistration();
        objdb.insert_Student_Info(txtStudentID.Text,txtFName.Text,txtLName.Text,ddlProgram.SelectedValue,txtCurrentSemester.Text,path);
        objdb.insert_Student_Login_Info(txtEmailID.Text,txtPassword.Text,txtStudentID.Text);
        String Subject = "Registration Confirmation Email";
        String body = "You are Successfully registered with Advisor Booking Service.";
        body = body + "\n Now You can make an appointment with the advisor";
        body = body + "\n Your User Name is =" + txtEmailID.Text;
        body = body + "\n Your Password is =" + txtPassword.Text;
        obj.sendEmail("advisor.system@yahoo.com", "Passwordisimportant", txtEmailID.Text, Subject, body);        
    
    }
    

=======

public partial class StudentRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
>>>>>>> origin/master
}