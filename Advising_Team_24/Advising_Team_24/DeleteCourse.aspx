<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCourse.aspx.cs" Inherits="Advising_Team_24.DeleteCourse" %>

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

            Choose course to delete<br />
            <br />

            <asp:DropDownList ID="DropDownList1" runat="server"> 
            </asp:DropDownList> 
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" style="height: 29px" />

            <br />

        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
