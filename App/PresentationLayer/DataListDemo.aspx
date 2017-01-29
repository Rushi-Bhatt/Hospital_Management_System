<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataListDemo.aspx.cs" Inherits="PresentationLayer_DataListDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <center>
    
    <asp:DataList ID="DataList1" runat="server" DataKeyField="uid" 
            DataSourceID="SqlDataSource1" RepeatColumns="3" BackColor="#CCCCFF">
        <AlternatingItemStyle BackColor="#FFFF66" />
        <ItemTemplate>
       <center>
       <table border="1" width="200px" style="height:60px;">
       <tr>
       <td>
       <img  src="userImages/<%#Eval("uname") %>.jpg" 
            height="70px" alt="img" border="2" />
       </td>
       <td><asp:Label ID="unameLabel" runat="server" Text='<%# Eval("uname") %>' 
               Font-Bold="True" ForeColor="#CC0066" /></td>
       </tr>
       <tr>
       <td>  <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' /></td>
       <td><asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' /></td>
       </tr>
      <tr>
      <td colspan="2" align="center">  <asp:Label ID="subjectLabel" runat="server" Text='<%# Eval("subject") %>' /></td>
      </tr>
       </table>
       </center>
        </ItemTemplate>
    </asp:DataList>
        <img alt="" /><asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:constr %>" 
            SelectCommand="SELECT * FROM [tblUser]"></asp:SqlDataSource>
    </center>
    </form>
</body>
</html>
