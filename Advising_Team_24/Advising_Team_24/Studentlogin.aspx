<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Studentlogin.aspx.cs" Inherits="Advising_Team_24.Studentlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

        .try {
           background-color:transparent;
           height:27px;
           margin-top:5px;
           border-color:transparent;
           position:relative;
           text-decoration:underline;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">

            <asp:Label ID="Label1" runat="server" Text="Have no account yet?"></asp:Label>
            
            <asp:Button ID="Signup" runat="server" Text="Sign Up" CssClass="try" OnClick="Signup_Click" />
           
        </div>
        <div style="text-align:center;">
            <asp:Label ID="Label2" runat="server" Text="ID" CssClass="login"></asp:Label>
        <br />
            <asp:TextBox ID="ID" runat="server"></asp:TextBox> <br />
                <asp:Label ID="Label3" runat="server" Text="Password" CssClass="login"></asp:Label>
        <br />
    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="Login" runat="server" Text="Log In" OnClick="Login_Click" />
        </div>
    </form>
</body>
</html>