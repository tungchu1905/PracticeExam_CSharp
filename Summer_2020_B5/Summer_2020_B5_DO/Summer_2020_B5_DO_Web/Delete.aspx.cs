﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Summer_2020_B5_DO_Web
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Database.delAuthor_Book(Request.Params["ID"]);
            Database.delBook(Request.Params["ID"]);
            Response.Redirect("MainScreen.aspx");
        }
    }
}