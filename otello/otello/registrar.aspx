<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="otello.registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
            background-color: #9900FF;
        }
        .auto-style2 {
            background-color: #9900FF;
        }
        .auto-style3 {
            background-color: #FFFFFF;
        }
        .auto-style4 {
            background-color: #9900FF;
            height: 918px;
        }
    </style>
</head>
<body style="height: 568px">
    <p class="auto-style2">
        <br class="auto-style2" />
        <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="auto-style1">Othello </span>
    </p>
    <p class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRAR USUARIO</p>
    <form id="form1" runat="server">
        <p class="auto-style2">
            &nbsp;</p>
        <div class="auto-style4">
            <asp:Label ID="Label1" runat="server" Text="NOMBRE:" CssClass="auto-style1"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="Label2" runat="server" Text="APELLIDO" CssClass="auto-style1"></asp:Label>
            <span class="auto-style1">:
            </span>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="Label3" runat="server" Text="USUARIO" CssClass="auto-style1"></asp:Label>
            <span class="auto-style1">:
            </span>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="Label4" runat="server" Text="CONTRASEÑA" CssClass="auto-style1"></asp:Label>
            <span class="auto-style1">:
            </span>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="Label5" runat="server" Text="NACIMIENTO" CssClass="auto-style1"></asp:Label>
            <span class="auto-style1">:&nbsp;
            </span>
            <asp:TextBox ID="TextBox5" runat="server" style="margin-top: 0px"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="Label6" runat="server" Text="PAIS" CssClass="auto-style1"></asp:Label>
            <span class="auto-style1">:
            </span>
            <asp:TextBox ID="TextBox6" runat="server" style="margin-top: 0px"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="Label7" runat="server" Text="CORREO ELECTRONICO" CssClass="auto-style1"></asp:Label>
            <span class="auto-style1">:&nbsp;
            </span>
            <asp:TextBox ID="TextBox7" runat="server" style="margin-top: 0px"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Button ID="Button1" runat="server" Height="44px" OnClick="Button1_Click" Text="REGISTRAR" Width="321px" CssClass="auto-style3" />
            <br class="auto-style2" />
            <br class="auto-style2" />
            <br class="auto-style2" />
        </div>
    </form>
</body>
</html>
