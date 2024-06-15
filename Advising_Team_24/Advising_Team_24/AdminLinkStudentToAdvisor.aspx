<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLinkStudentToAdvisor.aspx.cs" Inherits="Advising_Team_24.AdminLinkStudentToAdvisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Button ID="Button2" runat="server" Text="Back To Home Page" OnClick="Button2_Click" />
<br />
<br />
            <asp:Label ID="Label1" runat="server" Text="please enter student id"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="please enter advisor id"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="link" OnClick="Button1_Click" />
    </form>
</body>
</html>
