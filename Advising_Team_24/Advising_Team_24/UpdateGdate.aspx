<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateGdate.aspx.cs" Inherits="Advising_Team_24.UpdateGdate" %>

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

         <asp:Label ID="Label1" runat="server" Text="Please Update Expected Graduation Date " Font-Underline  Font-Bold ForeColor="Red"></asp:Label>

            <br /><br />
            <asp:Label ID="newdate" runat="server" Text="Expected Graduation Date: " Font-Bold ForeColor="RoyalBlue"></asp:Label>
            <input type="date" id="newGdate" runat="server" />
            <br /><br />
            <asp:Label ID="Sid1" runat="server" Text="Student ID:  " Font-Bold ForeColor="RoyalBlue"></asp:Label>
            <asp:DropDownList ID="StudentDropDown2" runat="server"></asp:DropDownList>
           <br /><br />
            <asp:Button ID="UpdateDate" runat="server" OnClick="Update_GDate" Text="Update" ForeColor="DarkRed" Font-Bold />

            

                               

        </div>
    </form>
</body>
</html>
