<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PozdravnaPoruka.aspx.cs" Inherits="WebFormsPrimjer.PozdravnaPoruka" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ovo je pozdravna poruka <br />
            <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label><br />
            <asp:textbox runat="server" ID="txtIme"></asp:textbox><br />
            <asp:Button ID="btnObradi" runat="server" Text="Button" BackColor="#3333CC" Font-Bold="True" Font-Size="Medium" ForeColor="#FF9900" Height="43px" OnClick="btnObradi_Click" Width="123px" /><br />
            <asp:Label ID="lblRezultat" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
