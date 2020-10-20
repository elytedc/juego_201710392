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
                &nbsp;
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
&nbsp;<asp:Button ID="Button6" runat="server" Height="22px" Text="." Width="30px" CssClass="auto-style77" />
        </p>
        <p class="auto-style78">
            A&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; B&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; C&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; D&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; F&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; G&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; H</p>
        <p class="auto-style74">
            1&nbsp;&nbsp;&nbsp; <asp:Button ID="a01" runat="server" Height="24px" Text="." Width="39px" OnClick="a01_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b01" runat="server" Height="24px" Text="." Width="39px" OnClick="b01_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c1" runat="server" Height="24px" Text="." Width="39px" OnClick="c1_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d01" runat="server" Height="24px" Text="." Width="39px" OnClick="d01_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e01" runat="server" Height="24px" Text="." Width="39px" OnClick="e01_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f01" runat="server" Height="24px" Text="." Width="39px" OnClick="f01_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g01" runat="server" Height="24px" Text="." Width="39px" OnClick="g01_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h01" runat="server" Height="24px" Text="." Width="39px" OnClick="h01_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        </p>
        <p class="auto-style74">
            2&nbsp;&nbsp;&nbsp; <asp:Button ID="a02" runat="server" Height="24px" Text="." Width="39px" OnClick="a02_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b02" runat="server" Height="24px" Text="." Width="39px" OnClick="b02_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c02" runat="server" Height="24px" Text="." Width="39px" OnClick="c02_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d02" runat="server" Height="24px" Text="." Width="39px" OnClick="d02_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e02" runat="server" Height="24px" Text="." Width="39px" OnClick="e02_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f02" runat="server" Height="24px" Text="." Width="39px" OnClick="f02_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g02" runat="server" Height="24px" Text="." Width="39px" OnClick="g02_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h02" runat="server" Height="24px" Text="." Width="39px" OnClick="h02_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        </p>
        <p class="auto-style74">
            3&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a03" runat="server" Height="24px" Text="." Width="39px" OnClick="a03_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b03" runat="server" Height="24px" Text="." Width="39px" OnClick="b03_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c03" runat="server" Height="24px" Text="." Width="39px" OnClick="c03_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d03" runat="server" Height="24px" Text="." Width="39px" OnClick="d03_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e03" runat="server" Height="24px" Text="." Width="39px" OnClick="e03_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f03" runat="server" Height="24px" Text="." Width="39px" OnClick="f03_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g03" runat="server" Height="24px" Text="." Width="39px" OnClick="g03_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h03" runat="server" Height="24px" Text="." Width="39px" OnClick="h03_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        </p>
        <p class="auto-style74">
            4&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a04" runat="server" Height="24px" Text="." Width="39px" OnClick="a04_Click" BackColor="#009E0C" BorderColor="#009E0C" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b04" runat="server" Height="24px" Text="." Width="39px" OnClick="b04_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c04" runat="server" Height="24px" Text="." Width="39px" OnClick="c04_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d04" runat="server" Height="24px" Text="." Width="39px" OnClick="d04_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e04" runat="server" Height="24px" Text="." Width="39px" OnClick="e04_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f04" runat="server" Height="24px" Text="." Width="39px" OnClick="f04_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g04" runat="server" Height="24px" Text="." Width="39px" OnClick="g04_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h04" runat="server" Height="24px" Text="." Width="39px" OnClick="h04_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        </p>
        <p class="auto-style74">
            5&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a05" runat="server" Height="24px" Text="." Width="39px" OnClick="a05_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b05" runat="server" Height="24px" Text="." Width="39px" OnClick="b05_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c05" runat="server" Height="24px" Text="." Width="39px" OnClick="c05_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d05" runat="server" Height="24px" Text="." Width="39px" OnClick="d05_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e05" runat="server" Height="24px" Text="." Width="39px" OnClick="e05_Click" BackColor="#009E0C" BorderColor="#009E0C" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f05" runat="server" Height="24px" Text="." Width="39px" OnClick="f05_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g05" runat="server" Height="24px" Text="." Width="39px" OnClick="g05_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h05" runat="server" Height="24px" Text="." Width="39px" OnClick="h05_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        </p>
        <p class="auto-style74">
            6&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a06" runat="server" Height="24px" Text="." Width="39px" OnClick="a06_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b06" runat="server" Height="24px" Text="." Width="39px" OnClick="b06_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c06" runat="server" Height="24px" Text="." Width="39px" OnClick="c06_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d06" runat="server" Height="24px" Text="." Width="39px" OnClick="d06_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e06" runat="server" Height="24px" Text="." Width="39px" OnClick="e06_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f06" runat="server" Height="24px" Text="." Width="39px" OnClick="f06_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g06" runat="server" Height="24px" Text="." Width="39px" OnClick="g06_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h06" runat="server" Height="24px" Text="." Width="39px" OnClick="h06_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        </p>
        <p class="auto-style74">
            7&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a07" runat="server" Height="24px" Text="." Width="39px" OnClick="a07_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b07" runat="server" Height="24px" Text="." Width="39px" OnClick="b07_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c07" runat="server" Height="24px" Text="." Width="39px" OnClick="c07_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d07" runat="server" Height="24px" Text="." Width="39px" OnClick="d07_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e07" runat="server" Height="24px" Text="." Width="39px" OnClick="e07_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f07" runat="server" Height="24px" Text="." Width="39px" OnClick="f07_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g07" runat="server" Height="24px" Text="." Width="39px" OnClick="g07_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h07" runat="server" Height="24px" Text="." Width="39px" OnClick="h07_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        </p>
        <p class="auto-style74">
            8&nbsp;&nbsp;&nbsp;
            <asp:Button ID="a08" runat="server" Height="24px" Text="." Width="39px" OnClick="a08_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="b08" runat="server" Height="24px" Text="." Width="39px" OnClick="b08_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="c08" runat="server" Height="24px" Text="." Width="39px" OnClick="c08_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="d08" runat="server" Height="24px" Text="." Width="39px" OnClick="d08_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="e08" runat="server" Height="24px" Text="." Width="39px" OnClick="e08_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="f08" runat="server" Height="24px" Text="." Width="39px" OnClick="f08_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="g08" runat="server" Height="24px" Text="." Width="39px" OnClick="g08_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="h08" runat="server" Height="24px" Text="." Width="39px" OnClick="h08_Click" BackColor="#009E0C" BorderColor="#009E0C"/>
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
