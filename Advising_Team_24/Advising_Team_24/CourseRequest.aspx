<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseRequest.aspx.cs" Inherits="Advising_Team_24.Request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="Button2" runat="server" Text="Back to Main Menu" OnClick="Button2_Click" /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="CourseID"></asp:Label><br />
            <asp:DropDownList ID="DropDownList1" runat="server" >
                <asp:ListItem Value="Select course"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Comment"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />



        </div>
    </form>
</body>
</html>
