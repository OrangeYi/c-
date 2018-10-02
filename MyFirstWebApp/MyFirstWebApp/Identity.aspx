<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Identity.aspx.cs" Inherits="MyFirstWebApp.Identity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Rule: Guess a number betweent 1-99 and the computer will generate a random number.<br />
            If your gusee number less then the random number you win.<br />
            For example your guess number is 50 and the random number is 60 then you win.<br />
            However if the random number is 49 you lose.<br />
            <br />
            Guess a number:
            <asp:TextBox ID="guessNumber" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            Make a bet:
            <asp:TextBox ID="betBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Click And Win" />
            <br />
            <br />
            Add fund: <asp:TextBox ID="fundBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addFund" runat="server" OnClick="addFund_Click" Text="Add fund" />
            <br />
            <br />
            Amount:
            <asp:Label ID="amountLabel" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="debug" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
