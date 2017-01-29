using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class viewstateDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ViewState.Add("name", txtName.Text);
        Response.Write("Value of viewstate: "+ViewState["name"].ToString());
    }
    protected void btnSession_Click(object sender, EventArgs e)
    {
        Session.Add("sname", TextBox1.Text);
        Response.Write("value of session: "+Session["sname"].ToString());
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Hello');", true);
        
    }
  

}