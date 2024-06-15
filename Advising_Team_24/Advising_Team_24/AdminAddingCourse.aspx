<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAddingCourse.aspx.cs" Inherits="Advising_Team_24.Procedures_AdminAddingCourse" %>

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
        <asp:Label ID="Label1" runat="server" Text="please choose major"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="please enter semester"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Text="1" Value="1"></asp:ListItem>
            <asp:ListItem Text="2" Value="2"></asp:ListItem>
            <asp:ListItem Text="3" Value="3"></asp:ListItem>
            <asp:ListItem Text="4" Value="4"></asp:ListItem>
            <asp:ListItem Text="5" Value="5"></asp:ListItem>
            <asp:ListItem Text="6" Value="6"></asp:ListItem>
            <asp:ListItem Text="7" Value="7"></asp:ListItem>
            <asp:ListItem Text="8" Value="8"></asp:ListItem>
            <asp:ListItem Text="9" Value="9"></asp:ListItem>
            <asp:ListItem Text="10" Value="10"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="please choose credit hours"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <script>
            function isNumberKey(evt) {
                var charCode = (evt.which) ? evt.which : event.keyCode;
                if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                    return false;
                }
                return true;
            }

            function validateInput() {
                var textBox = document.getElementById('<%= TextBox2.ClientID %>');
                var inputValue = textBox.value;

                if (isNaN(inputValue)) {
                    alert('Please enter a valid integer.');
                    textBox.value = ''; // Clear the invalid input
                }
            }
        </script>
        <asp:Label ID="Label3" runat="server" Text="please enter course name"></asp:Label>
        <br />


        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="is this course offered?"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
            <asp:ListItem Text="No" Value="No"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
        <br />
      


    </form>
</body>
</html>
