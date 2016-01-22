<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_5.Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="border:1px solid black; padding:5px; display:inline-block; width:255px; margin-left:500px">
            <div>
                <asp:textBox ID="input" runat="server" type="number" style="width:240px; margin-left:5px"></asp:textBox>
            </div>            
            <div>
                <asp:Button ID="Button1" runat="server" Text="1" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px; margin:5px"/>
                <asp:Button ID="Button2" runat="server" Text="2" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="Button3" runat="server" Text="3" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="ButtonPlus" runat="server" Text="+" OnClick="ButtonPlus_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
            </div>
            <div>
                <asp:Button ID="Button4" runat="server" Text="4" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="Button5" runat="server" Text="5" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="Button6" runat="server" Text="6" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="ButtonMinus" runat="server" Text="-" OnClick="ButtonMinus_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
            </div>
            <div>
                <asp:Button ID="Button7" runat="server" Text="7" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="Button8" runat="server" Text="8" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="Button9" runat="server" Text="9" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="ButtonMulti" runat="server" Text="x" OnClick="ButtonMulti_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
            </div>
            <div>
                <asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="Button0" runat="server" Text="0" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="ButtonDivide" runat="server" Text="/" OnClick="ButtonDivide_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
                <asp:Button ID="ButtonSqrt" runat="server" Text="Sqrt" OnClick="ButtonSqrt_click" Style="background-color: gray; border-color: black; height: 30px; width: 50px;margin:5px" />
            </div>
            <div>
                <asp:Button ID="ButtonEqual" runat="server" Text="=" OnClick="ButtonEqual_click" Style="background-color: gray; border-color: black; height: 30px; width: 240px;margin-left:10px;margin:5px" />
            </div>
        </div>
    </form>
</body>
</html>
