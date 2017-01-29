using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CalendarDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String strDate = "02-08-1994";
        DateTime dt = new DateTime();
        dt = DateTime.ParseExact(strDate,"dd-MM-yyyy",null);
          
        Calendar1.SelectedDate = dt.Date;

        Calendar1.VisibleDate = dt;

        
        }
    public DateTime SelectedDate { get; set; }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Response.Write(Calendar1.SelectedDate.ToShortDateString());
        

    }
}