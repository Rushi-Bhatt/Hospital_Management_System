using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class PresentationLayer_demoUser : System.Web.UI.Page
{
    demoClass1 obj;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        obj = new demoClass1();
        
        obj.addUser(txtUname.Text, txtPwd.Text, rblGender.SelectedItem.Value, txtMailId.Text, ddlSubject.SelectedItem.Text);
        FileUpload1.SaveAs(Server.MapPath("userImages") + "\\" + txtUname.Text + ".jpg");
        Response.Write("Data inserted successfully");
        bindData();

        clearControls();
    }

    private void clearControls()
    {


        txtMailId.Text = "";
        txtPwd.Text = "";
        txtUname.Text = "";
        ddlSubject.SelectedIndex = 0;
        rblGender.SelectedIndex = -1;
    }
    public void bindData()
    {
        obj = new demoClass1();
        DataSet ds = new DataSet();
        ds = obj.fetchData();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }



    }