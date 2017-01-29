using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
/// <summary>
/// Summary description for demoClass1
/// </summary>
public class demoClass1:connect
{
	public demoClass1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataSet fetchData()
    {
        string query = "select *from tblUser";
        DataSet ds = new DataSet();
        ds = getDataset(query);

        return ds;
    }

    public void addUser(string uname, string pwd, string  gender, string email, string subject)
    {
        string query = "insert into tblUser(uname, pwd, gender, email, subject) values( '"+uname+"','"+pwd+"' ,'"+gender+"', '"+email+"','"+subject+"'  )";
        fnInsertUpdateDelete(query);
    }

    public DataSet userDetails(int id)
    {
        string query = "select *from tblUser where uid= "+id+"  ";
        DataSet ds = new DataSet();
        ds = getDataset(query);
        return ds;
    }

    
    void delete()
    { }
}