<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAddingSemester.aspx.cs" Inherits="Advising_Team_24.AdminAddingSemester" %>

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
        <asp:Label ID="Label1" runat="server" Text="please enter semester start date"></asp:Label>
        <br />
        <input type="date" id="StartDate" runat="server" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="please enter semester end date"></asp:Label>
        <br />
        <input type="date" id="EndDate" runat="server" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="please choose semester code"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />


    </form>
</body>
</html>
