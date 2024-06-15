<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLinkStudent.aspx.cs" Inherits="Advising_Team_24.AdminLinkStudent" %>

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
            <asp:Label ID="Label1" runat="server" Text="please enter course id "></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="please enter instructor id "></asp:Label>
        </div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="please enter student id "></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="please enter semester code "></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="link" OnClick="Button1_Click" style="width: 38px" />
    </form>
</body>
</html>
