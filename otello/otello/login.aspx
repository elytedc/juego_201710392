<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="otello.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 196px">
    <form id="form1" runat="server">
        <div style="margin-left: 240px">
            <p style="margin-left: 120px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Othello</p>
            <p style="margin-left: 120px">
                INICIA SECION
            </p>
            <p style="margin-left: 120px">
                &nbsp;</p>
        </div>
        <p style="margin-left: 120px">
            <asp:Label ID="Label1" runat="server" Text="USUARIO:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 46px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label2" runat="server" Text="CONTRASEÑA"></asp:Label>
            :
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 48px"></asp:TextBox>
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="INICIAR" Width="212px" />
        <asp:Button ID="Button2" runat="server" Text="REGISTRARCE" Width="174px" />
    </form>
</body>
</html>
