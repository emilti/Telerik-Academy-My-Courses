<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetRandom.aspx.cs" Inherits="_1.GetRandom.GetRandom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="number" runat="server" id="htmlLowBound" />
            <input type="number" runat="server" id="htmlUpBound" />
            <button id="htmlBtn" runat="server" onserverclick="htmlButton_Click">HTML Control Random Generator</button>
            <span id="htmlResult" runat="server"></span>
        </div>

        <div>
            <asp:TextBox ID="webLowBound" runat="server" type="number" ></asp:TextBox>
            <asp:TextBox ID="webUpBound" runat="server" type="number" ></asp:TextBox>            
            <asp:Button ID="webBtn" runat="server" Text="WEB Control Random Generator" onclick="webButton_Click"/>
            <asp:Label ID="webResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
