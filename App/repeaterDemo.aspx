<%@ Page Language="C#" AutoEventWireup="true" CodeFile="repeaterDemo.aspx.cs" Inherits="repeaterDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <center>
    
    
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
       <ItemTemplate>
     <table border="1" width="400px">
     <tr>
     <td>
     
     </td>
     <td>
         <img alt="img" src="" width="70px"/>
     </td>
     </tr>
     </table>  
       </ItemTemplate>
       
       
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:constr %>" 
            SelectCommand="SELECT [uid], [uname], [gender], [email], [subject] FROM [tblUser]">
        </asp:SqlDataSource>
    
    
    </center>
    </form>
</body>
</html>
