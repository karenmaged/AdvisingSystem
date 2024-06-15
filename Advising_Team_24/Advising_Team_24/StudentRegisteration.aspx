<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegisteration.aspx.cs" Inherits="Advising_Team_24.StudentRegisteration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Back to Log In" OnClick="Button2_Click" /><br /><br />
            Please Sign Up <br /><br />
<asp:Label ID="name" runat="server" Text="First Name:"></asp:Label>

<asp:TextBox ID="name1" runat="server"></asp:TextBox><br /><br />
<asp:Label ID="lname" runat="server" Text="Last Name:"></asp:Label>
<asp:TextBox ID="name2" runat="server"></asp:TextBox><br /><br />

<asp:Label ID="password" runat="server" Text="Password:"></asp:Label>
<asp:TextBox ID="password1" runat="server"></asp:TextBox><br /><br />

<asp:Label ID="Label1" runat="server" Text="Faculty:"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />

<asp:Label ID="email" runat="server" Text="Email:"></asp:Label>
<asp:TextBox ID="email1" runat="server"></asp:TextBox><br /><br />

<asp:Label ID="major" runat="server" Text="Major:"></asp:Label>
<asp:TextBox ID="major1" runat="server"></asp:TextBox><br /><br />
<asp:Label ID="Label2" runat="server" Text="Semester:"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />

<asp:Button ID="Button1" runat="server" OnClick="Sign_in" Text="Sign up" /> <br /><br />
<asp:Label ID="ADid" runat="server" Text=""></asp:Label>



        </div>
    </form>
</body>
</html>
