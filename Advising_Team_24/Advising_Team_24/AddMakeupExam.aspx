<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMakeupExam.aspx.cs" Inherits="Advising_Team_24.AddMakeupExam" %>

<!DOCTYPE html>
<!-- ragy Sameh--> 
<!-- farah ahmed-->
<!-- farah ahmed-->
<!-- farah ahmed-->


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

            Select Makeup Details<br />
            <br />

            <asp:Label ID="Label1" runat="server" Text="Exam Type"></asp:Label>

            <asp:DropDownList ID="DropDownList1" runat="server"> 
                <asp:listitem Value="First MakeUp"></asp:listitem>
                <asp:listitem Value="Second MakeUp"></asp:listitem>

            </asp:DropDownList> 
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Date"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Course ID"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Exam" OnClick="Button1_Click" />

            <br />
        </div>
    </form>
</body>
</html>
