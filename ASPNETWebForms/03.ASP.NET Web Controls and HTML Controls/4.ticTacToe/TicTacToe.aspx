<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="_4.ticTacToe.TicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px" />
            <asp:Button ID="Button2" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px"/>
            <asp:Button ID="Button3" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px"/>
        </div>
        <div>
            <asp:Button ID="Button4" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px"/>
            <asp:Button ID="Button5" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px"/>
            <asp:Button ID="Button6" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px"/>
        </div>
        <div>
            <asp:Button ID="Button7" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px"/>
            <asp:Button ID="Button8" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px"/>
            <asp:Button ID="Button9" runat="server" Text=" "  OnClick="Button_click" style="background-color:white;border-color:black;height:30px;width:30px"/>
        </div>
    </form>
</body>
</html>
