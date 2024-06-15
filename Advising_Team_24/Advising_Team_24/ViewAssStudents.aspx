<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAssStudents.aspx.cs" Inherits="Advising_Team_24.ViewAssStudents" %>

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
            <asp:Label ID="majj" runat="server" Text="Select a Major: "></asp:Label>
            <asp:TextBox ID="majjj" runat="server"></asp:TextBox>
            <asp:Button ID="selectmaj" runat="server"  OnClick="Enter_maj" Text="Enter" />
        </div>
    </form>
</body>
</html>
