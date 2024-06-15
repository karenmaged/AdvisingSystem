<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MissingCourses.aspx.cs" Inherits="Advising_Team_24.MissingCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
    .padded{
       margin-top:20px;
       margin-bottom:40px;
      
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
        <asp:Button ID="Button1" runat="server" Text="Back to Main Menu" OnClick="Button1_Click" />
    <div style="text-align:center">

        
        
    </div>
    <div  style="text-align:center" id="exist" runat="server">

 </div>
 
</form>
</body>
</html>
