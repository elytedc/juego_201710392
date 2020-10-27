<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RETO_INVERSO.aspx.cs" Inherits="otello.RETO_INVERSO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 62px;
        }
        
        .auto-style72 {
            background-color: #FF0000;
        }
        
        .auto-style73 {
            margin-left: 320px;
        }
        .auto-style74 {
            margin-left: 40px;
        }
        .auto-style75 {
            color: #FFFFFF;
            background-color: #9900CC;
        }
        .auto-style76 {
            background-color: #000000;
        }
        .auto-style77 {
            background-color: #FFFFFF;
        }
        .auto-style78 {
            margin-left: 80px;
        }
        .auto-style79 {
            background-color: #0000CC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style75">
        <div class="auto-style1">
            <p class="auto-style73">
                RETO INVERSO</p>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="1000" OnTick="Timer1_Tick">
                </asp:Timer>
                TIEMPO J1:
                <asp:Label ID="m1" runat="server" Text="0:"></asp:Label>
                <asp:Label ID="s1" runat="server" Text="0"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; TIEMPO J2:&nbsp;
                <asp:Label ID="m2" runat="server" Text="0:"></asp:Label>
                &nbsp;<asp:Label ID="s2" runat="server" Text="0"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FILA:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;COLUMNA&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </ContentTemplate>
        </asp:UpdatePanel>
            <p>
                CARGAR XML: <asp:FileUpload ID="fUpload" runat="server"  type="file" onchange="this.form.submit();" Width="216px"  Height="22px"  />
                
            &nbsp;&nbsp;&nbsp; GUARDAR XML:&nbsp;
                <asp:Button ID="Button1" runat="server" Height="21px" OnClick="Button1_Click" Text="GUARDAR XML" Width="108px" />
&nbsp; LIMPIAR:
                <asp:Button ID="B" runat="server" CssClass="auto-style72" Height="20px" Width="44px" OnClick="B_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="INICIAR" />
            &nbsp;&nbsp; TURNO DE:
                <asp:Label ID="Label1" runat="server" Text="label"></asp:Label>
&nbsp;&nbsp;
            </p>
            <p>
                ELIJA SU COLOR J1:&nbsp;
                <asp:Button ID="Button3" runat="server" Height="21px" Text="Button" Width="37px" CssClass="auto-style76" OnClick="Button3_Click" />
&nbsp;<asp:Button ID="Button4" runat="server" Height="22px" Text="." Width="30px" CssClass="auto-style77" OnClick="Button4_Click" />
        </p>
        <p>
            ELIJA SU COLOR J1:&nbsp;
            <asp:Button ID="Button5" runat="server" Height="21px" Text="Button" Width="37px" CssClass="auto-style76" />
&nbsp;<asp:Button ID="Button6" runat="server" Height="22px" Text="." Width="30px" CssClass="auto-style77" OnClick="Button6_Click" />
        </p>
        <p class="auto-style78">
            A&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; B&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; C&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; D&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; F&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; G&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; H&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            I&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; J&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; K&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; L&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; M&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; N&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ñ&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; O&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; P&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Q</p>
        <p class="auto-style74">
            1&nbsp;&nbsp;&nbsp; <asp:Button ID="a01" runat="server" Height="24px" Text="." Width="39px" OnClick="a01_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style76"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b01" runat="server" Height="24px" Text="." Width="39px" OnClick="b01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c1" runat="server" Height="24px" Text="." Width="39px" OnClick="c1_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d01" runat="server" Height="24px" Text="." Width="39px" OnClick="d01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e01" runat="server" Height="24px" Text="." Width="39px" OnClick="e01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f01" runat="server" Height="24px" Text="." Width="39px" OnClick="f01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g01" runat="server" Height="24px" Text="." Width="39px" OnClick="g01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h01" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q1" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            2&nbsp;&nbsp;&nbsp; <asp:Button ID="a02" runat="server" Height="24px" Text="." Width="39px" OnClick="a02_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b02" runat="server" Height="24px" Text="." Width="39px" OnClick="b02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c02" runat="server" Height="24px" Text="." Width="39px" OnClick="c02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d02" runat="server" Height="24px" Text="." Width="39px" OnClick="d02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e02" runat="server" Height="24px" Text="." Width="39px" OnClick="e02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f02" runat="server" Height="24px" Text="." Width="39px" OnClick="f02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g02" runat="server" Height="24px" Text="." Width="39px" OnClick="g02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h02" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i2" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q2" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        </p>
        <p class="auto-style74">
            3&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a03" runat="server" Height="24px" Text="." Width="39px" OnClick="a03_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b03" runat="server" Height="24px" Text="." Width="39px" OnClick="b03_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c03" runat="server" Height="24px" Text="." Width="39px" OnClick="c03_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d03" runat="server" Height="24px" Text="." Width="39px" OnClick="d03_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e03" runat="server" Height="24px" Text="." Width="39px" OnClick="e03_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f03" runat="server" Height="24px" Text="." Width="39px" OnClick="f03_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g03" runat="server" Height="24px" Text="." Width="39px" OnClick="g03_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h03" runat="server" Height="24px" Text="." Width="39px" OnClick="h03_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i3" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q3" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        </p>
        <p class="auto-style74">
            4&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a04" runat="server" Height="24px" Text="." Width="39px" OnClick="a04_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b04" runat="server" Height="24px" Text="." Width="39px" OnClick="b04_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c04" runat="server" Height="24px" Text="." Width="39px" OnClick="c04_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d04" runat="server" Height="24px" Text="." Width="39px" OnClick="d04_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e04" runat="server" Height="24px" Text="." Width="39px" OnClick="e04_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f04" runat="server" Height="24px" Text="." Width="39px" OnClick="f04_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g04" runat="server" Height="24px" Text="." Width="39px" OnClick="g04_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h04" runat="server" Height="24px" Text="." Width="39px" OnClick="h04_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i4" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q4" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        </p>
        <p class="auto-style74">
            5&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a05" runat="server" Height="24px" Text="." Width="39px" OnClick="a05_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b05" runat="server" Height="24px" Text="." Width="39px" OnClick="b05_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c05" runat="server" Height="24px" Text="." Width="39px" OnClick="c05_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d05" runat="server" Height="24px" Text="." Width="39px" OnClick="d05_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e05" runat="server" Height="24px" Text="." Width="39px" OnClick="e05_Click" BackColor="#9900CC" BorderColor="#9900CC" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f05" runat="server" Height="24px" Text="." Width="39px" OnClick="f05_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g05" runat="server" Height="24px" Text="." Width="39px" OnClick="g05_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h05" runat="server" Height="24px" Text="." Width="39px" OnClick="h05_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i5" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q5" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        </p>
        <p class="auto-style74">
            6&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a06" runat="server" Height="24px" Text="." Width="39px" OnClick="a06_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b06" runat="server" Height="24px" Text="." Width="39px" OnClick="b06_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c06" runat="server" Height="24px" Text="." Width="39px" OnClick="c06_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d06" runat="server" Height="24px" Text="." Width="39px" OnClick="d06_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e06" runat="server" Height="24px" Text="." Width="39px" OnClick="e06_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f06" runat="server" Height="24px" Text="." Width="39px" OnClick="f06_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g06" runat="server" Height="24px" Text="." Width="39px" OnClick="g06_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h06" runat="server" Height="24px" Text="." Width="39px" OnClick="h06_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i6" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q6" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            7&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a07" runat="server" Height="24px" Text="." Width="39px" OnClick="a07_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b07" runat="server" Height="24px" Text="." Width="39px" OnClick="b07_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c07" runat="server" Height="24px" Text="." Width="39px" OnClick="c07_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d07" runat="server" Height="24px" Text="." Width="39px" OnClick="d07_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e07" runat="server" Height="24px" Text="." Width="39px" OnClick="e07_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f07" runat="server" Height="24px" Text="." Width="39px" OnClick="f07_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g07" runat="server" Height="24px" Text="." Width="39px" OnClick="g07_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h07" runat="server" Height="24px" Text="." Width="39px" OnClick="h07_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i7" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q7" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        </p>
        <p class="auto-style74">
            8&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a08" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b08" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c08" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d08" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e08" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f08" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g08" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h08" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i8" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q8" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            9&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a9" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b9" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c9" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d9" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e9" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f9" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g9" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h9" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i9" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q9" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            10&nbsp;
            <asp:Button ID="a010" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b10" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c10" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d10" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e10" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f10" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g10" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h10" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i10" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q10" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            11&nbsp; <asp:Button ID="a11" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b11" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c11" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d11" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e11" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f11" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g11" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h11" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i11" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q11" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            12&nbsp; <asp:Button ID="a12" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b12" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c12" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d12" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e12" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f12" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g12" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h12" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i12" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q12" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            13&nbsp;
            <asp:Button ID="a13" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b13" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c13" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d13" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e13" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f13" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g13" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h13" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i13" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q13" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            14&nbsp;
            <asp:Button ID="a14" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b14" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c14" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d14" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e14" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f14" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g14" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h14" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i14" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q14" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            15&nbsp;
            <asp:Button ID="a15" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b15" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c15" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d15" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e15" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f15" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g15" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h15" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i15" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q15" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            16&nbsp;
            <asp:Button ID="a16" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b16" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c16" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d16" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e16" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f16" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g16" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h16" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i16" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q16" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            17&nbsp;
            <asp:Button ID="a17" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#9900CC" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b17" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c17" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d17" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e17" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f17" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g17" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h17" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i17" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q17" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#9900CC"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            18&nbsp; <asp:Button ID="a18" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#009E0C" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b18" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c18" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d18" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e18" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f18" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g18" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h18" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i18" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q18" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;
        </p>
        <p class="auto-style74">
            19&nbsp;
            <asp:Button ID="a19" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#009E0C" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b19" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c19" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d19" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e19" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f19" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g19" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h19" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i19" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q19" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        </p>
        <p class="auto-style74">
            20&nbsp;
            <asp:Button ID="a20" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#9900CC" BorderColor="#009E0C" CssClass="auto-style79"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b20" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c20" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d20" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e20" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f20" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g20" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h20" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="i20" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="j20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="k20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="l20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="mm20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="n20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ñ20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="o20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="p20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="q20" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#9900CC" BorderColor="#009E0C"/>
        &nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
