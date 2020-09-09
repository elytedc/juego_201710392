<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="partidavs.aspx.cs" Inherits="otello.partidavs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        
        #Radio1 {
            height: 104px;
            width: 180px;
        }
        #form1 {
            color: #FFFFFF;
            font-weight: 700;
            background-color: #6600CC;
        }

        


        .auto-style1 {
            
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 388px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 224px;
            right: 784px;
        }

        


        .auto-style2 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 390px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 281px;
            right: 727px;
        }
        .auto-style3 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 431px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 225px;
            right: 783px;
        }
        .auto-style4 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 431px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 281px;
            right: 727px;
        }
        .auto-style5 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 562px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 394px;
            right: 614px;
        }
        .auto-style6 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 514px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 395px;
            right: 613px;
        }
        .auto-style7 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 514px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 455px;
            right: 553px;
        }
        .auto-style8 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 561px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 451px;
            right: 557px;
        }
        .auto-style9 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 514px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 335px;
            right: 673px;
        }
        .auto-style10 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 559px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 339px;
            right: 669px;
        }
        .auto-style11 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 517px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 282px;
            right: 726px;
        }
        .auto-style12 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 558px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 280px;
            right: 728px;
        }
        .auto-style13 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 514px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 224px;
            right: 784px;
        }
        .auto-style14 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 561px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 225px;
            right: 783px;
        }
        .auto-style15 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 473px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 453px;
            right: 555px;
        }
        .auto-style16 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 476px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 397px;
            right: 611px;
        }
        .auto-style17 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 513px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 169px;
            right: 839px;
        }
        .auto-style18 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 516px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 111px;
            right: 897px;
        }
        .auto-style19 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 559px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 113px;
            right: 895px;
        }
        .auto-style20 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 559px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 168px;
            right: 840px;
        }
        .auto-style21 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 517px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 57px;
            right: 951px;
        }
        .auto-style22 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 560px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 56px;
            right: 952px;
        }
        .auto-style23 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 473px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 339px;
            right: 669px;
        }
        .auto-style24 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 475px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 283px;
            right: 725px;
        }
        .auto-style25 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 474px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 225px;
            right: 783px;
        }
        .auto-style26 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 473px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 167px;
            right: 841px;
        }
        .auto-style27 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 479px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 111px;
            right: 897px;
        }
        .auto-style28 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 474px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 56px;
            right: 952px;
        }
        .auto-style29 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 388px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 339px;
            right: 669px;
        }
        .auto-style30 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 390px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 394px;
            right: 614px;
        }
        .auto-style31 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 387px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 452px;
            right: 556px;
        }
        .auto-style32 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 431px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 338px;
            right: 670px;
        }
        .auto-style33 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 432px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 392px;
            right: 616px;
        }
        .auto-style34 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 430px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 453px;
        }
        .auto-style35 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 391px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 54px;
            right: 954px;
        }
        .auto-style36 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 389px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 111px;
            right: 897px;
        }
        .auto-style37 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 390px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 167px;
            right: 841px;
        }
        .auto-style38 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 431px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 56px;
            right: 952px;
        }
        .auto-style39 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 432px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 112px;
            right: 896px;
        }
        .auto-style40 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 433px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 168px;
            right: 840px;
        }
        .auto-style41 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 350px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 56px;
            right: 952px;
        }
        .auto-style42 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 349px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 112px;
            right: 896px;
        }
        .auto-style43 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 347px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 169px;
            right: 839px;
        }
        .auto-style44 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 348px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 224px;
            right: 784px;
        }
        .auto-style45 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 351px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 282px;
            right: 726px;
        }
        .auto-style46 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 348px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 339px;
            right: 669px;
        }
        .auto-style47 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 350px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 394px;
            right: 614px;
        }
        .auto-style48 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 348px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 452px;
            right: 556px;
        }
        .auto-style49 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 306px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 56px;
            right: 952px;
        }
        .auto-style50 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 305px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 112px;
            right: 896px;
        }
        .auto-style51 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 305px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 168px;
            right: 840px;
        }
        .auto-style52 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 304px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 225px;
            right: 783px;
        }
        .auto-style53 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 304px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 281px;
            right: 727px;
        }
        .auto-style54 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 302px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 339px;
            right: 669px;
        }
        .auto-style55 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 302px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 396px;
            right: 612px;
        }
        .auto-style56 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 306px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 453px;
            right: 555px;
        }
        .auto-style57 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 260px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 54px;
            right: 954px;
        }
        .auto-style58 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 260px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 112px;
            right: 896px;
        }
        .auto-style59 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 258px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 168px;
            right: 840px;
        }
        .auto-style60 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 256px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 225px;
            right: 783px;
        }
        .auto-style61 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 258px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 280px;
            right: 728px;
        }
        .auto-style62 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 258px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 339px;
            right: 669px;
        }
        .auto-style63 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 257px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 395px;
            right: 613px;
        }
        .auto-style64 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 258px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 451px;
            right: 557px;
        }
        .auto-style65 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            font-size: large;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 278px;
            margin-left: 10px;
            width: 159px;
            height: 31px;
            left: 679px;
            right: 205px;
        }
        .auto-style66 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            font-size: large;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 358px;
            margin-left: 10px;
            width: 159px;
            height: 31px;
            left: 686px;
            right: 198px;
        }
        .auto-style67 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            font-size: large;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 423px;
            margin-left: 10px;
            width: 159px;
            height: 31px;
            left: 684px;
            right: 200px;
        }

        


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 778px">
    <p style="            margin-left: 360px
    ">
        Othello </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PARTIDA INDIVIDUAL</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
            </p>
            <asp:Panel ID="Panel1" runat="server" BackColor="#FFCC99" Height="437px" Width="540px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Image ID="Image1" runat="server" Height="407px" ImageUrl="~/App_Data/ta2.jpg" Width="525px" />
                <br />
&nbsp;
                <br />
                <asp:Button ID="a1" runat="server" CssClass="auto-style20" Text="°" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
                <asp:Button ID="a2" runat="server" CssClass="auto-style4" Text="°" />
                <asp:Button ID="a3" runat="server" CssClass="auto-style1" Text="°" />
                <asp:Button ID="a4" runat="server" CssClass="auto-style3" Text="°" />
                <asp:Button ID="a5" runat="server" CssClass="auto-style45" Text="°" />
                <asp:Button ID="a8" runat="server" CssClass="auto-style25" Text="°" />
                <asp:Button ID="a9" runat="server" CssClass="auto-style10" Text="°" />
                <asp:Button ID="a10" runat="server" CssClass="auto-style14" Text="°" />
                <asp:Button ID="a12" runat="server" CssClass="auto-style46" Text="°" />
                <asp:Button ID="a13" runat="server" CssClass="auto-style15" Text="°" />
                <asp:Button ID="a14" runat="server" CssClass="auto-style49" Text="°" />
                <asp:Button ID="a15" runat="server" CssClass="auto-style8" Text="°" />
                <asp:Button ID="a" runat="server" CssClass="auto-style6" Text="°" />
                <asp:Button ID="a7" runat="server" CssClass="auto-style7" Text="°" />
                <asp:Button ID="a6" runat="server" CssClass="auto-style5" Text="°" />
                <asp:Button ID="a11" runat="server" CssClass="auto-style16" Text="°" />
                <asp:Button ID="a16" runat="server" CssClass="auto-style12" Text="°" />
                <asp:Button ID="a17" runat="server" CssClass="auto-style26" Text="°" />
                <asp:Button ID="a18" runat="server" CssClass="auto-style19" Text="°" />
                <asp:Button ID="a19" runat="server" CssClass="auto-style11" Text="°" />
                <asp:Button ID="a20" runat="server" CssClass="auto-style27" Text="°" />
                <asp:Button ID="a21" runat="server" CssClass="auto-style22" Text="°" />
                <asp:Button ID="a22" runat="server" CssClass="auto-style13" Text="°" />
                <asp:Button ID="a23" runat="server" CssClass="auto-style9" Text="°" />
                <asp:Button ID="a24" runat="server" CssClass="auto-style21" Text="°" />
                <asp:Button ID="a25" runat="server" CssClass="auto-style40" Text="°" />
                <asp:Button ID="a26" runat="server" CssClass="auto-style24" Text="°" />
                <asp:Button ID="a27" runat="server" CssClass="auto-style39" Text="°" />
                <asp:Button ID="a28" runat="server" CssClass="auto-style23" Text="°" />
                <asp:Button ID="a29" runat="server" CssClass="auto-style31" Text="°" />
                <asp:Button ID="a30" runat="server" CssClass="auto-style33" Text="°" />
                <asp:Button ID="a31" runat="server" CssClass="auto-style34" Text="°" />
                <asp:Button ID="a32" runat="server" CssClass="auto-style63" Text="°" />
                <asp:Button ID="a33" runat="server" CssClass="auto-style32" Text="°" />
                <asp:Button ID="a34" runat="server" CssClass="auto-style28" Text="°" />
                <asp:Button ID="a35" runat="server" CssClass="auto-style43" Text="°" />
                <asp:Button ID="a36" runat="server" CssClass="auto-style58" Text="°" />
                <asp:Button ID="a37" runat="server" CssClass="auto-style38" Text="°" />
                <asp:Button ID="a38" runat="server" CssClass="auto-style17" Text="°" />
                <asp:Button ID="a39" runat="server" CssClass="auto-style18" Text="°" />
                <asp:Button ID="a40" runat="server" CssClass="auto-style44" Text="°" />
                <asp:Button ID="a41" runat="server" CssClass="auto-style2" Text="°" />
                <asp:Button ID="a42" runat="server" CssClass="auto-style29" Text="°" />
                <asp:Button ID="a43" runat="server" CssClass="auto-style35" Text="°" />
                <asp:Button ID="a44" runat="server" CssClass="auto-style48" Text="°" />
                <asp:Button ID="a45" runat="server" CssClass="auto-style30" Text="°" />
                <asp:Button ID="a46" runat="server" CssClass="auto-style37" Text="°" />
                <asp:Button ID="a47" runat="server" CssClass="auto-style36" Text="°" />
                <asp:Button ID="a48" runat="server" CssClass="auto-style61" Text="°" />
                <asp:Button ID="a49" runat="server" CssClass="auto-style54" Text="°" />
                <asp:Button ID="a50" runat="server" CssClass="auto-style41" Text="°" />
                <asp:Button ID="a51" runat="server" CssClass="auto-style47" Text="°" />
                <asp:Button ID="a52" runat="server" CssClass="auto-style59" Text="°" />
                <asp:Button ID="a53" runat="server" CssClass="auto-style42" Text="°" />
                <asp:Button ID="a54" runat="server" CssClass="auto-style60" Text="°" />
                <asp:Button ID="a55" runat="server" CssClass="auto-style64" Text="°" />
                <asp:Button ID="a56" runat="server" CssClass="auto-style57" Text="°" />
                <asp:Button ID="a57" runat="server" CssClass="auto-style55" Text="°" />
                <asp:Button ID="a58" runat="server" CssClass="auto-style50" Text="°" />
                <asp:Button ID="a59" runat="server" CssClass="auto-style53" Text="°" />
                <asp:Button ID="a60" runat="server" CssClass="auto-style62" Text="°" />
                <asp:Button ID="a61" runat="server" CssClass="auto-style51" Text="°" />
                <asp:Button ID="a62" runat="server" CssClass="auto-style52" Text="°" />
                <asp:Button ID="a63" runat="server" CssClass="auto-style56" Text="°" />
                <asp:Button ID="a64" runat="server" CssClass="auto-style65" Text="CARGAR XML" />
                <asp:Button ID="a65" runat="server" CssClass="auto-style66" Text="GUARDAR XML" />
                <asp:Button ID="a66" runat="server" CssClass="auto-style67" Text="INICIAR" />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
