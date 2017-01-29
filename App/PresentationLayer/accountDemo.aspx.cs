using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class PresentationLayer_accountDemo : System.Web.UI.Page
{
    demoClass1 obj;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet ds = new DataSet();
             obj = new demoClass1();
             ds = obj.fetchData();
             ddlUserName.DataSource = ds;
             ddlUserName.DataTextField = "uname";
             ddlUserName.DataValueField = "uid";
             ddlUserName.DataBind();
             ddlUserName.Items.Insert(0,"--select user--");
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //logic of update query
    }
    protected void ddlUserName_SelectedIndexChanged(object sender, EventArgs e)
    {
        obj=new demoClass1();
        DataSet ds = new DataSet();
        ds = obj.userDetails(Convert.ToInt32(ddlUserName.SelectedItem.Value));

        if (ds.Tables[0].Rows.Count > 0)
        { 
        rblGender.SelectedValue=ds.Tables[0].Rows[0]["gender"].ToString();
            ddlSubject.SelectedValue=ds.Tables[0].Rows[0]["subject"].ToString();
            txtMailId.Text = ds.Tables[0].Rows[0]["email"].ToString();
            //imgUser.ImageUrl = "~/PresentationLayer/userImages/" + ddlUserName.SelectedItem.Text + ".jpg";


            imgUser.ImageUrl = "~/PresentationLayer/userImages/"+ddlUserName.SelectedItem.Text+".jpg";
        }
        
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void imgUser_Click(object sender, ImageClickEventArgs e)
    {
        FileUpload1.Visible = true;
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        obj = new demoClass1();



            }
}