using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ViewState["name"] != null)
        { lblMsg.Text = ViewState["name"].ToString(); }
        else
        {
            lblMsg.Text = "no viewstate value found";
        }
        if (Session["sname"] != null)
        { lblSession.Text = Session["sname"].ToString(); }
        else
        {
            lblSession.Text = "no session value found";
        }


    }
}