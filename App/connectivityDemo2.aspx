<%@ Page Language="C#" AutoEventWireup="true" CodeFile="connectivityDemo2.aspx.cs" Inherits="connectivityDemo2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <center>
    <table border="1" width="400px">
        <tr>
        <td align="center" style="background-color:Gray;width:200px;">USER NAME</td>
        <td style="background-color: Gray; width: 200px;">Image
        </td>
        </tr>
    
    </table>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
        <table border="1" width="400px">
        <tr>
        <td style="width:200px;">
        <%#DataBinder.Eval(Container, "DataItem.uname") %>
        </td>
        <td>
            <img  src="PresentationLayer/userImages/<%#DataBinder.Eval(Container,"DataItem.uname") %>.jpg" 
            height="70px" alt="img" />
        </td> 
        </tr>        
        </table>
        </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:constr %>" 
            SelectCommand="SELECT * FROM [tblUser]">
            </asp:SqlDataSource>
    
    </center>
    </form>
</body>
</html>
