<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequiredCourses.aspx.cs" Inherits="Advising_Team_24.RequiredCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .padded{
       margin-top:20px;
       margin-bottom:40px;
        width:150px
    }
    .padded2{
        margin-left:10px;
        margin-bottom:40px;

    }
    .padded3{
         transform:translateX(-10px);
         margin-left:30px;
    }
 
</style>
</head>
<body>
    <form id="form1" runat="server">
<asp:Button ID="Button2" runat="server" Text="Back to Main Menu" OnClick="Button2_Click" />
    <div style="text-align:center">

        <asp:Label ID="Label1" runat="server" Text="Current Semester Code" ></asp:Label> <br/>
       <asp:DropDownList ID="DropDownList1" runat="server" CssClass="padded">
                          <asp:ListItem Value="Select semester"></asp:ListItem>
       </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Show" CssClass="padded2" OnClick="Button1_Click"/><br />
        
        
    </div>
    <div  style="text-align:center" id="exist" runat="server">

 </div>
 
</form>
</body>
</html>
