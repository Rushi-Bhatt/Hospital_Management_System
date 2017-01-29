using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class testconnectivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\Trio\demo1\App_Data\demoDatabase1.mdf;Integrated Security=True;User Instance=True");
        string query = "insert into tblUser(uname, pwd,gender, email, subject) values( '"+txtUname.Text+"','"+txtPwd.Text+"', '"+rblGender.SelectedItem.Value+"','"+txtMailId.Text+"','"+ddlSubject.SelectedItem.Text+"'  ) ";
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        bindData();
    }

    public void bindData()
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\Trio\demo1\App_Data\demoDatabase1.mdf;Integrated Security=True;User Instance=True");
        string query = "select uid,uname, gender, email, subject from tblUser";
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
    con.Close();
    }
}