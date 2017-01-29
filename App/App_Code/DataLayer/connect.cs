using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data.Sql;

public class connect
{
    SqlConnection con;
    private SqlConnection GetConnectionObj()
    {
        try
        {
            String constr;
            constr = ConfigurationManager.ConnectionStrings["myConnection"].ToString();
            con = new SqlConnection(constr);
            return con;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally 
        {
            releaseConnection(); 
        }
    }
   
    

    public void releaseConnection()
    {
        try
        {
            if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            {
                con.Close();
                con.Dispose();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataSet getDataset(string strQry)
    {
        try
        {
            DataSet ds = new DataSet();
            con = GetConnectionObj();
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQry;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
            releaseConnection();
        }
    }

    public void fnInsertUpdateDelete(string strQry)
    {
        try
        {
            con = new SqlConnection();
            con = GetConnectionObj();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQry;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            releaseConnection();
        }
    }
}
