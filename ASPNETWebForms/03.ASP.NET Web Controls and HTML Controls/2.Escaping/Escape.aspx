<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Escape.aspx.cs" Inherits="_2.Escaping.Escape" validateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="textBoxInput" runat="server" type="text"></asp:TextBox>
            <asp:Button ID="btn" runat="server" Text="Submit" OnClick="button_Click" />
            <br />
            <br />
            <div>
                <asp:TextBox ID="textBoxResult" runat="server" type="text" ></asp:TextBox>                
            </div>            
            <div>
                <asp:label ID="labelresult" runat="server" type="text"></asp:label>
            </div>
        </div>
    </form>
</body>
</html>
