<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_registration.aspx.cs" Inherits="Advising_Team_24.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="ADVregistration" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Back to Log In" OnClick="login" /><br /><br />
            Please Sign Up <br /><br />
            <asp:Label ID="name" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="name1" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="password" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="password1" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="email" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="email1" runat="server"></asp:TextBox><br /><br />
            
            <asp:Label ID="office" runat="server" Text="Office:"></asp:Label>
            <asp:TextBox ID="office1" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" OnClick="Sign_in" Text="Sign up" /> <br /><br />
            <asp:Label ID="ADid" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>