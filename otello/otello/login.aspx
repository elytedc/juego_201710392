<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="otello.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
            background-color: #9900CC;
        }
        .auto-style2 {
            background-color: #9900CC;
        }
        .auto-style3 {
            background-color: #FFFFFF;
        }
        .auto-style4 {
            color: #FFFFFF;
            background-color: #9900CC;
            height: 680px;
        }
    </style>
</head>
<body style="height: 196px">
    <form id="form1" runat="server" class="auto-style2">
        <div style="margin-left: 240px">
            <p style="margin-left: 120px" class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Othello</p>
            <p style="margin-left: 120px" class="auto-style1">
                INICIA SECION
            </p>
            <p style="margin-left: 120px" class="auto-style1">
                &nbsp;</p>
        </div>
        <p style="margin-left: 120px">
            <asp:Label ID="Label1" runat="server" Text="USUARIO:" CssClass="auto-style1"></asp:Label>
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 46px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label2" runat="server" Text="CONTRASEÑA" CssClass="auto-style1"></asp:Label>
            <span class="auto-style1">:
            </span>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 48px"></asp:TextBox>
        </p>
        <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="Button1" runat="server" Text="INICIAR" Width="212px" OnClick="Button1_Click" CssClass="auto-style3" />
        <asp:Button ID="Button2" runat="server" Text="REGISTRARCE" Width="174px" OnClick="Button2_Click" CssClass="auto-style3" />
        <br class="auto-style1" />
    <p class="auto-style1">
        &nbsp;</p>
    <p class="auto-style4">
        &nbsp;</p>
    </form>
    </body>
</html>
