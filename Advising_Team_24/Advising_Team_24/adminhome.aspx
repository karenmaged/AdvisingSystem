<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="Advising_Team_24.adminhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <style>
     .menu{
      direction: ltr;
      margin-left:50px;
      margin-bottom:20px;
      height:80px;
      width:300px;
      background-color:maroon;
      font-weight:bold;
      color: white;
     }
 </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                                                <asp:Button ID="Button21" runat="server" Text="Log Out" OnClick="Button21_Click" />
<br />
<br />

            <asp:Button ID="Button1" runat="server" CssClass="menu" OnClick="Button1_Click" Text="list advisors" />

            <br />

        </div>

        <asp:Button ID="Button2" runat="server" CssClass="menu" Text="AdminListStudentsWithAdvisors" OnClick="Button2_Click" />

        <br />
        <asp:Button ID="Button3" runat="server" CssClass="menu" Text="all_Pending_Requests" OnClick="Button3_Click" />

        <br />
        <asp:Button ID="Button4" runat="server" CssClass="menu" OnClick="Button4_Click" Text="AdminAddingSemester" />

        <br />
        <asp:Button ID="Button5" runat="server" CssClass="menu" Text="AdminAddingCourse" OnClick="Button5_Click" />

        <br />
        <asp:Button ID="Button6" runat="server" CssClass="menu" Text="AdminLinkInstructor" OnClick="Button6_Click" />

        <br />
        <asp:Button ID="Button7" runat="server" CssClass="menu" Text="AdminLinkStudentToAdvisor" OnClick="Button7_Click" />

        <br />
        <asp:Button ID="Button8" runat="server" CssClass="menu" Text="AdminLinkStudent" OnClick="Button8_Click" />

        <br />
        <asp:Button ID="Button9" runat="server" CssClass="menu" OnClick="Button9_Click" Text="Instructors_AssignedCourses" />

        <br />
        <asp:Button ID="Button10" runat="server" CssClass="menu" OnClick="Button10_Click" Text="Semster_offered_Courses" />

        <br />

<asp:Button ID="Button11" runat="server" CssClass="menu" OnClick="Button11_Click" Text="Add Makeup Exam" />

        <br />
<asp:Button ID="Button12" runat="server" CssClass="menu" OnClick="Button12_Click" Text="Delete Course" />

        <br />
<asp:Button ID="Button13" runat="server" CssClass="menu" OnClick="Button13_Click" Text="Delete Slot" />

        <br />
<asp:Button ID="Button14" runat="server" CssClass="menu" OnClick="Button14_Click" Text="Issue Installments" />

        <br />
<asp:Button ID="Button15" runat="server" CssClass="menu" OnClick="Button15_Click" Text="Update Student Status" />
        <br />
<asp:Button ID="Button16" runat="server" CssClass="menu" OnClick="Button16_Click" Text="View Active Students" />

        <br />
<asp:Button ID="Button17" runat="server" CssClass="menu" OnClick="Button17_Click" Text="View Graduation Plans" />

        <br />
<asp:Button ID="Button18" runat="server" CssClass="menu" OnClick="Button18_Click" Text="View Payments" />
    
        <br />
<asp:Button ID="Button19" runat="server" CssClass="menu" OnClick="Button19_Click" Text="View Semester Courses" />

        <br />
<asp:Button ID="Button20" runat="server" CssClass="menu" OnClick="Button20_Click" Text="View Student Transcripts" />
    </form>
</body>
</html>
