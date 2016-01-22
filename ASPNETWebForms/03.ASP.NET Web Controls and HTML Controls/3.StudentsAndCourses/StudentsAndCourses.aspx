<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentsAndCourses.aspx.cs" Inherits="_3.StudentsAndCourses.StudentsAndCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label runat="server">First Name</asp:Label>
                <asp:TextBox ID="textBoxFirstName" runat="server" type="text"></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server">Last Name</asp:Label>
                <asp:TextBox ID="textBoxLastName" runat="server" type="text"></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server">Faculty Number</asp:Label>
                <asp:TextBox ID="textBoxFacultyNumber" runat="server" type="text"></asp:TextBox>
            </div>
            <div>
                <asp:DropDownList ID="DropDownListUniversity"
                    runat="server">
                    <asp:ListItem>SU</asp:ListItem>
                    <asp:ListItem>TU</asp:ListItem>
                    <asp:ListItem>VSU</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:DropDownList ID="DropDownListSpecialty"
                    runat="server">
                    <asp:ListItem>Medicine</asp:ListItem>
                    <asp:ListItem>Economy</asp:ListItem>
                    <asp:ListItem>Philosphy</asp:ListItem>
                    <asp:ListItem>History</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:ListBox ID="ListBoxCourses"
                    Rows="6"
                    Width="100px"
                    SelectionMode="Multiple"
                    runat="server">

                    <asp:ListItem>Math 1</asp:ListItem>
                    <asp:ListItem>Math 2</asp:ListItem>
                    <asp:ListItem>Production technologies</asp:ListItem>
                    <asp:ListItem>Macroeconomy</asp:ListItem>
                    <asp:ListItem>Statistcis</asp:ListItem>
                    <asp:ListItem>Bulgaria History</asp:ListItem>

                </asp:ListBox>
            </div>
            <asp:Button ID="btnStudent" Text="Send Form" runat="server" OnClick="button_Click" />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
