<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="HelloProgram.aspx.cs"
    Inherits="HelloProgram.HelloProgram" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>ASP.NET Web Forms Hello Program</title>
</head>

<body>
    <form id="formHello" runat="server">
        <h1>Hello Program</h1>       
        Enter text:  
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonForHello" runat="server"
            OnClick="ButtonAddHello_Click" Text="Add Hello" />
        <br />        
        <asp:label ID="resultLabel" runat="server"></asp:label>
    </form>
</body>

</html>
