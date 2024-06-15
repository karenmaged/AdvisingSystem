<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLinkInstructor.aspx.cs" Inherits="Advising_Team_24.AdminLinkInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
        </div>
                    <asp:Button ID="Button2" runat="server" Text="Back To Home Page" OnClick="Button2_Click" />
<br />
<br />
        <asp:Label ID="Label1" runat="server" Text="please enter instuctor id"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="please enter course id"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="please enter slot id"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="link" OnClick="Button1_Click" />
    </form>
</body>
</html>
