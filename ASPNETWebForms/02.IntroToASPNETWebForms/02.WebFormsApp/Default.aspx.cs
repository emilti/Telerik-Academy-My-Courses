﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label2.Text = "Hello, ASP.NET from the C# code";
            this.Label3.Text = Assembly.GetExecutingAssembly().Location;
        }
    }
}