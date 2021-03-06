﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


public partial class addfriend : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String friendid = Request.QueryString["userid"];
        String username = Request.QueryString["username"];
        String userid = Session["userid"].ToString();
        bool result = Usr.AddFriend(userid, friendid);
        if (result)
            lblMsg.Text = "[" + username + "] został dodany do listy ulubionych. Przejdź <a href='javascript:history.back()'>tutaj</a> aby znaleźć ich jeszcze więcej!";
        else
            lblMsg.Text = "[" + username + "] nie mógł być dodany do ulubionych! Przejdź <a href='javascript:history.back()'>tutaj</a> aby spróbować jeszcze raz .";
    }
}
