using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
public partial class editUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindUsers();
        }
    }

    public void bindUsers()
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\Trio\demo1\App_Data\demoDatabase1.mdf;Integrated Security=True;User Instance=True");
        string query = "select uid,uname from tblUser";
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        ddlUserName.DataSource = dr;
        ddlUserName.DataTextField = "uname";
        ddlUserName.DataValueField = "uid";
        ddlUserName.DataBind();
        con.Close();
    
    }
    protected void ddlUserName_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\Trio\demo1\App_Data\demoDatabase1.mdf;Integrated Security=True;User Instance=True");
        string query = "select * from tblUser where uid= "+Convert.ToInt32(ddlUserName.SelectedItem.Value)+" ";
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            rblGender.SelectedValue = dr["gender"].ToString();
            txtMailId.Text = dr["email"].ToString();
        }
        
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {

    }
}