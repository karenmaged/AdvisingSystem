<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertGradPlan.aspx.cs" Inherits="Advising_Team_24.InsertGradPlan" %>

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
            <asp:Label ID="semCode" runat="server" Text="Semester Code: " ForeColor="RoyalBlue" Font-Bold ></asp:Label>
            <asp:DropDownList ID="SemDropDown" runat="server"></asp:DropDownList>
            <br /><br />
            
            <asp:Label ID="Gdate" runat="server" Text="Expected Graduation Date: " ForeColor="RoyalBlue" Font-Bold></asp:Label><br />
            <input type="date" id="selectDate" runat="server" ontextchanged="Gdate1_TextChanged" />
            <br /><br />

             <asp:Label ID="sCredit" runat="server" Text="Semester Credit Hours: " ForeColor="RoyalBlue" Font-Bold></asp:Label>
            <asp:TextBox ID="sCredit1" runat="server"></asp:TextBox><br />
           <br /><br />

            <asp:Label ID="Sid" runat="server" Text="Student ID:  " ForeColor="RoyalBlue" Font-Bold></asp:Label>
            <asp:DropDownList ID="StudentDropDown" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:Button ID="InsertGP" runat="server" OnClick="Submit_GP" Text="Submit" />
            
        </div>
    </form>
</body>
</html>
