﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAboutPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Username"] == null)
        {
            Response.Redirect("TeacherLoginPage.aspx");
        }
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("TeacherPage.aspx");

        
    }
}