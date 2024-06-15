<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_menu.aspx.cs" Inherits="Advising_Team_24.Advisor_menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .farida{
            width:407px;
            height:50px;
            margin-bottom:20px;
            background-color:bisque;
            
            
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center >
                                                            
            <asp:Button ID="Button1" runat="server" Text="Insert a Graduation Plan" Font-Bold ForeColor="DarkGreen" OnClick="Button1_Click" CssClass="farida" />
            <asp:Button ID="Button2" runat="server" Text="Insert a Course Into Graduation Plan" Font-Bold ForeColor="DarkGreen" OnClick="Button2_Click" CssClass="farida" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Delete a Course From Graduation Plan" Font-Bold ForeColor="DarkGreen" OnClick="Button3_Click" CssClass="farida"  />
            <asp:Button ID="Button4" runat="server" Text="Update expected Graduation date" Font-Bold ForeColor="DarkGreen" OnClick="Button4_Click" CssClass="farida" />
            <br />
            <asp:Button ID="Button5" runat="server" Text="View All your advising students" Font-Bold ForeColor="DarkGreen" OnClick="Button5_Click"  CssClass="farida"/>
            <asp:Button ID="Button6" runat="server" Text="View All your Pending Requests" Font-Bold ForeColor="DarkGreen" OnClick="Button6_Click" CssClass="farida" />
            <br />
            <asp:Button ID="Button7" runat="server" Text="View All your requests" Font-Bold ForeColor="DarkGreen" OnClick="Button7_Click" CssClass="farida" />
            <asp:Button ID="Button8" runat="server" Text="View your assigned Students From a Certain Major" Font-Bold ForeColor="DarkGreen" OnClick="Button8_Click" CssClass="farida"/>
            <br />
            <asp:Button ID="Button9" runat="server" Text="Approve/ Reject Credit Hours Request" Font-Bold ForeColor="DarkGreen" OnClick="Button9_Click" CssClass="farida"/>

                        <asp:Button ID="Button10" runat="server" Text="Approve/ Reject Course Request" Font-Bold ForeColor="DarkGreen" OnClick="Button10_Click" CssClass="farida"/>
<br />
            
                                                                        <asp:Button ID="Button21" runat="server" Text="Log Out" OnClick="Button21_Click"/>
<br />
<br />                                                
        </div>
    </form>
</body>
</html>
