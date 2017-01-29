<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo2.aspx.cs" Inherits="Demo2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <center>
    
    
        <asp:DataList ID="DataList1" runat="server" DataKeyField="uid" 
            DataSourceID="SqlDataSource1">
            <ItemTemplate>
                uid:
                <asp:Label ID="uidLabel" runat="server" Text='<%# Eval("uid") %>' />
                <br />
                uname:
                <asp:Label ID="unameLabel" runat="server" Text='<%# Eval("uname") %>' />
                <br />
                gender:
                <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                <br />
                email:
                <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                <br />
                subject:
                <asp:Label ID="subjectLabel" runat="server" Text='<%# Eval("subject") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:constr %>" 
            SelectCommand="SELECT [uid], [uname], [gender], [email], [subject] FROM [tblUser]">
        </asp:SqlDataSource>
    
    
    </center>
    </form>
</body>
</html>
