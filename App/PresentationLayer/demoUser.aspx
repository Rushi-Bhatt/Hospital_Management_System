<%@ Page Language="C#" AutoEventWireup="true" CodeFile="demoUser.aspx.cs" Inherits="PresentationLayer_demoUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <center>
   <table width="600px" border="2">
   <tr>
   <td colspan="2" align="center">USER DETAILS</td>
   </tr>
   <tr>
   <td>Enter name:</td>
   <td>
   <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
   </td>
   </tr>
   <tr>
   <td>Enter password:</td>
   <td>
   <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
   </td>
   </tr>
   <tr>
   <td>Select Gender:</td>
   <td>
   <asp:RadioButtonList ID="rblGender" runat="server">
       <asp:ListItem Value="m">Male</asp:ListItem>
       <asp:ListItem Value="f">Female</asp:ListItem>
   
   </asp:RadioButtonList>
   </td>
   </tr>
   
   <tr>
   <td>Enter mail id:</td>
   <td>
   <asp:TextBox ID="txtMailId" runat="server" ></asp:TextBox>
   </td>
   </tr>

   <tr>
   <td>Enter subject:</td>
   <td>
   <asp:DropDownList ID="ddlSubject" runat="server">
       <asp:ListItem>--select subject--</asp:ListItem>
       <asp:ListItem>ASP.NET</asp:ListItem>
       <asp:ListItem>JAVA</asp:ListItem>
       <asp:ListItem>DBMS</asp:ListItem>
       <asp:ListItem>DataStructure</asp:ListItem>
       </asp:DropDownList>
   </td>
   </tr>

   <tr>
   <td>Upload Image</td>
   <td>
       <asp:FileUpload ID="FileUpload1" runat="server" />
       </td>
   </tr>

   <tr>
   <td>&nbsp;</td>
   <td>
       <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="ADD" />
   </td>
   </tr>

   <tr>
   <td>&nbsp;</td>
   <td>
       &nbsp;</td>
   </tr>

   <tr>
   <td colspan="2">
       <asp:GridView ID="GridView1" runat="server">
       </asp:GridView>
       </td>
   </tr>
   </table>
   </center>
    </form>
</body>
</html>
