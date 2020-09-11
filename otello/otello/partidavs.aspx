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

        


        .auto-style20 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 505px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 189px;
            right: 819px;
            background-color: #00CC00;
        }
        .auto-style4 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 375px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 315px;
            right: 693px;
            background-color: #00CC00;
        }
        
        


        .auto-style1 {
            
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 331px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 255px;
            right: 753px;
            bottom: 92px;
            background-color: #00CC00;
        }

        


        .auto-style3 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 374px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 255px;
            right: 753px;
            background-color: #00CC00;
        }
        .auto-style45 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 287px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 317px;
            right: 691px;
            background-color: #00CC00;
        }
        .auto-style25 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 418px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 255px;
            right: 753px;
            background-color: #00CC00;
        }
        .auto-style10 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 504px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 384px;
            right: 624px;
            background-color: #00CC00;
        }
        .auto-style14 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 506px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 253px;
            right: 755px;
            background-color: #00CC00;
        }
        .auto-style46 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 286px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 385px;
            right: 623px;
            background-color: #00CC00;
        }
        .auto-style15 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 373px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 511px;
            right: 497px;
            background-color: #00CC00;
        }
        .auto-style49 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 240px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 61px;
            background-color: #00CC00;
        }
        .auto-style8 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 503px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 509px;
            right: 499px;
            background-color: #00CC00;
        }
        .auto-style6 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 462px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 447px;
            right: 561px;
            background-color: #00CC00;
        }
        .auto-style7 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 417px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 509px;
            right: 499px;
            background-color: #00CC00;
        }
        .auto-style5 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 504px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 449px;
            background-color: #00CC00;
        }
        .auto-style16 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 420px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 447px;
            right: 561px;
            background-color: #00CC00;
        }
        .auto-style12 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 505px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 318px;
            right: 690px;
            background-color: #00CC00;
        }
        .auto-style26 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 418px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 189px;
            right: 819px;
            bottom: 188px;
            background-color: #00CC00;
        }
        .auto-style19 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 505px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 126px;
            right: 882px;
            background-color: #00CC00;
        }
        .auto-style11 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 461px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 317px;
            right: 691px;
            background-color: #00CC00;
        }
        .auto-style27 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 461px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 126px;
            right: 882px;
            background-color: #00CC00;
            bottom: 105px;
        }
        .auto-style22 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 507px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 63px;
            right: 945px;
            background-color: #00CC00;
        }
        .auto-style13 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 461px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 255px;
            right: 753px;
            background-color: #00CC00;
        }
        .auto-style9 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 462px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 384px;
            right: 624px;
            background-color: #00CC00;
        }
        .auto-style21 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 461px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 61px;
            right: 947px;
            background-color: #00CC00;
        }
        .auto-style40 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 372px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 190px;
            right: 818px;
            background-color: #00CC00;
            bottom: 217px;
        }
        .auto-style24 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 416px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 316px;
            right: 692px;
            background-color: #00CC00;
        }
        .auto-style39 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 417px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 126px;
            right: 882px;
            background-color: #00CC00;
        }
        .auto-style23 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 418px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 383px;
            right: 625px;
            background-color: #00CC00;
        }
        .auto-style31 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 240px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 512px;
            right: 496px;
            background-color: #00CC00;
        }
        .auto-style33 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 332px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 510px;
            right: 498px;
            background-color: #00CC00;
        }
        .auto-style34 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 376px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 447px;
            bottom: 228px;
            background-color: #00CC00;
        }
        .auto-style63 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 185px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 384px;
            right: 881px;
            bottom: 338px;
            background-color: #00CC00;
        }
        .auto-style32 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 375px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 384px;
            right: 624px;
            background-color: #00CC00;
        }
        .auto-style28 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 418px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 60px;
            right: 948px;
            bottom: 158px;
            background-color: #00CC00;
        }
        .auto-style43 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 286px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 190px;
            right: 818px;
            background-color: #00CC00;
        }
        .auto-style38 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 371px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 61px;
            right: 947px;
            background-color: #00CC00;
        }
        .auto-style17 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 461px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 190px;
            right: 818px;
            background-color: #00CC00;
        }
        .auto-style18 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 463px;
            margin-left: 10px;
            width: 35px;
            height: 30px;
            left: 509px;
            right: 499px;
            background-color: #00CC00;
        }
        .auto-style44 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 287px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 253px;
            right: 755px;
            background-color: #00CC00;
        }
        
        


        .auto-style2 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 331px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 316px;
            right: 692px;
            background-color: #00CC00;
        }
        .auto-style29 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 332px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 385px;
            right: 623px;
            background-color: #00CC00;
        }
        .auto-style35 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 330px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 61px;
            right: 947px;
            background-color: #00CC00;
        }
        .auto-style48 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 333px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 448px;
            background-color: #00CC00;
        }
        .auto-style30 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 287px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 511px;
            right: 497px;
            background-color: #00CC00;
            bottom: 298px;
        }
        .auto-style37 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 331px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 191px;
            right: 817px;
            background-color: #00CC00;
        }
        .auto-style36 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 372px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 126px;
            right: 882px;
            background-color: #00CC00;
        }
        .auto-style61 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 188px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 253px;
            right: 755px;
            background-color: #00CC00;
            bottom: 114px;
        }
        .auto-style54 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 240px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 384px;
            right: 624px;
            background-color: #00CC00;
        }
        .auto-style41 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 285px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 61px;
            background-color: #00CC00;
        }
        .auto-style47 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 287px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 447px;
            right: 561px;
            background-color: #00CC00;
        }
        .auto-style42 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 331px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 127px;
            right: 881px;
            background-color: #00CC00;
        }
        .auto-style60 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 188px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 190px;
            right: 818px;
            background-color: #00CC00;
        }
        .auto-style64 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 187px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 446px;
            right: 562px;
            background-color: #00CC00;
        }
        .auto-style57 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 189px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 59px;
            right: 926px;
            background-color: #009D0E;
        }
        .auto-style55 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 238px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 446px;
            right: 562px;
            bottom: 110px;
            background-color: #00CC00;
        }
        .auto-style50 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 287px;
            margin-left: 10px;
            width: 35px;
            height: 32px;
            left: 127px;
            right: 881px;
            background-color: #00CC00;
        }
        .auto-style53 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 236px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 317px;
            right: 691px;
            bottom: 217px;
            background-color: #00CC00;
        }
        .auto-style62 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 187px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 318px;
            right: 690px;
            background-color: #00CC00;
        }
        .auto-style51 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 237px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 190px;
            background-color: #00CC00;
        }
        .auto-style52 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 237px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 253px;
            right: 755px;
            bottom: 186px;
            background-color: #00CC00;
        }
        .auto-style56 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 187px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 511px;
            right: 497px;
            background-color: #00CC00;
        }
        .auto-style65 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 237px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 129px;
            background-color: #00CC00;
        }

        


        .auto-style67 {
            height: 788px;
        }
        .auto-style68 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            font-size: large;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 264px;
            margin-left: 10px;
            width: 156px;
            height: 44px;
            left: 726px;
            right: 151px;
        }
        .auto-style70 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            font-size: large;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 401px;
            margin-left: 10px;
            width: 156px;
            height: 44px;
            left: 733px;
        }

        


        .auto-style71 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 187px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 128px;
            right: 1137px;
            background-color: #00CC00;
        }

        


        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style67">
    <p style="            margin-left: 360px
    ">
        Othello </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PARTIDA INDIVIDUAL</p>
            <p>
                CARGAR XML: <asp:FileUpload ID="fUpload" runat="server"  type="file" onchange="this.form.submit();" Width="216px"  Height="22px"  />
                
            &nbsp;&nbsp;&nbsp; </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Image ID="Image1" runat="server" Height="425px" ImageUrl="~/ima/fonfo.jpg" Width="599px" />
                <asp:Button ID="c08" runat="server" CssClass="auto-style20" Text="" BorderColor="#00CC00" OnClick="c08_Click" />
                <asp:Button ID="e05" runat="server" CssClass="auto-style4" Text="" BorderColor="#00CC00" OnClick="e05_Click" />
                <asp:Button ID="d04" runat="server" CssClass="auto-style1" Text="" BorderColor="#00CC00" OnClick="d04_Click" />
                <asp:Button ID="d05" runat="server" CssClass="auto-style3" Text="" BorderColor="#00CC00" OnClick="d05_Click" />
                <asp:Button ID="e03" runat="server" CssClass="auto-style45" Text="" BorderColor="#00CC00" OnClick="e03_Click" />
                <asp:Button ID="d06" runat="server" CssClass="auto-style25" Text="" BorderColor="#00CC00" OnClick="d06_Click" />
                <asp:Button ID="f08" runat="server" CssClass="auto-style10" Text="" BorderColor="#00CC00" OnClick="f08_Click" />
                <asp:Button ID="d08" runat="server" CssClass="auto-style14" Text="" BorderColor="#00CC00" OnClick="d08_Click" />
                <asp:Button ID="f03" runat="server" CssClass="auto-style46" Text="" BorderColor="#00CC00" OnClick="f03_Click" />
                <asp:Button ID="h05" runat="server" CssClass="auto-style15" Text="" BorderColor="#00CC00" OnClick="h05_Click" />
                <asp:Button ID="a02" runat="server" CssClass="auto-style49" Text="" BorderColor="#00CC00" OnClick="a02_Click" />
                <asp:Button ID="g07" runat="server" CssClass="auto-style6" Text="" BorderColor="#00CC00" OnClick="g07_Click" />
                <asp:Button ID="h06" runat="server" CssClass="auto-style7" Text="" BorderColor="#00CC00" OnClick="h06_Click" />
                <asp:Button ID="g08" runat="server" CssClass="auto-style5" Text="" BorderColor="#00CC00" OnClick="g08_Click" />
                <asp:Button ID="g06" runat="server" CssClass="auto-style16" Text="" BorderColor="#00CC00" OnClick="g06_Click" />
                <asp:Button ID="e08" runat="server" CssClass="auto-style12" Text="" BorderColor="#00CC00" OnClick="e08_Click" />
                <asp:Button ID="c06" runat="server" CssClass="auto-style26" Text="" BorderColor="#00CC00" OnClick="c06_Click" />
                <asp:Button ID="b08" runat="server" CssClass="auto-style19" Text="" BorderColor="#00CC00" OnClick="b08_Click" />
                <asp:Button ID="e07" runat="server" CssClass="auto-style11" Text="" BorderColor="#00CC00" OnClick="e07_Click" />
                <asp:Button ID="b07" runat="server" CssClass="auto-style27" Text="" BorderColor="#00CC00" OnClick="b07_Click" />
                <asp:Button ID="a08" runat="server" CssClass="auto-style22" Text="" BorderColor="#00CC00" OnClick="a08_Click" />
                <asp:Button ID="d07" runat="server" CssClass="auto-style13" Text="" BorderColor="#00CC00" OnClick="d07_Click" />
                <asp:Button ID="f07" runat="server" CssClass="auto-style9" Text="" BorderColor="#00CC00" OnClick="f07_Click" />
                <asp:Button ID="a07" runat="server" CssClass="auto-style21" Text="" BorderColor="#00CC00" OnClick="a07_Click" />
                <asp:Button ID="c05" runat="server" CssClass="auto-style40" Text="" BorderColor="#00CC00" OnClick="c05_Click" />
                <asp:Button ID="e06" runat="server" CssClass="auto-style24" Text="" BorderColor="#00CC00" OnClick="e06_Click" />
                <asp:Button ID="b06" runat="server" CssClass="auto-style39" Text="" BorderColor="#00CC00" OnClick="b06_Click" />
                <asp:Button ID="f06" runat="server" CssClass="auto-style23" Text="" BorderColor="#00CC00" OnClick="f06_Click" />
                <asp:Button ID="h02" runat="server" CssClass="auto-style31" Text="" BorderColor="#00CC00" OnClick="h02_Click" />
                <asp:Button ID="h04" runat="server" CssClass="auto-style33" Text="" BorderColor="#00CC00" OnClick="h04_Click" />
                <asp:Button ID="g05" runat="server" CssClass="auto-style34" Text="" BorderColor="#00CC00" OnClick="g05_Click" />
                <asp:Button ID="f01" runat="server" CssClass="auto-style63" Text="" BorderColor="#00CC00" OnClick="f01_Click" />
                <asp:Button ID="f05" runat="server" CssClass="auto-style32" Text="" BorderColor="#00CC00" OnClick="f05_Click" />
                <asp:Button ID="a06" runat="server" CssClass="auto-style28" Text="" BorderColor="#00CC00" OnClick="a06_Click" />
                <asp:Button ID="c03" runat="server" CssClass="auto-style43" Text="" BorderColor="#00CC00" OnClick="c03_Click" />
                <asp:Button ID="a05" runat="server" CssClass="auto-style38" Text="" BorderColor="#00CC00" OnClick="a05_Click" />
                <asp:Button ID="c07" runat="server" CssClass="auto-style17" Text="" BorderColor="#00CC00" OnClick="c07_Click" />
                <asp:Button ID="h07" runat="server" CssClass="auto-style18" Text="" BorderColor="#00CC00" OnClick="h07_Click" />
                <asp:Button ID="d03" runat="server" CssClass="auto-style44" Text="" BorderColor="#00CC00" OnClick="d03_Click" />
                <asp:Button ID="e04" runat="server" CssClass="auto-style2" Text="" BorderColor="#00CC00" OnClick="e04_Click" />
                <asp:Button ID="f04" runat="server" CssClass="auto-style29" Text="" BorderColor="#00CC00" OnClick="f04_Click" />
                <asp:Button ID="a04" runat="server" CssClass="auto-style35" Text="" BorderColor="#00CC00" OnClick="a04_Click" />
                <asp:Button ID="g04" runat="server" CssClass="auto-style48" Text="" BorderColor="#00CC00" OnClick="g04_Click" />
                <asp:Button ID="h03" runat="server" CssClass="auto-style30" Text="" BorderColor="#00CC00" OnClick="h03_Click" />
                <asp:Button ID="c04" runat="server" CssClass="auto-style37" Text="" BorderColor="#00CC00" OnClick="c04_Click" />
                <asp:Button ID="b05" runat="server" CssClass="auto-style36" Text="" BorderColor="#00CC00" OnClick="b05_Click" />
                <asp:Button ID="d01" runat="server" CssClass="auto-style61" Text="" BorderColor="#00CC00" OnClick="d01_Click" />
                <asp:Button ID="f02" runat="server" CssClass="auto-style54" Text="" BorderColor="#00CC00" OnClick="f02_Click" />
                <asp:Button ID="a03" runat="server" CssClass="auto-style41" Text="" BorderColor="#00CC00" OnClick="a03_Click" />
                <asp:Button ID="g03" runat="server" CssClass="auto-style47" Text="" BorderColor="#00CC00" OnClick="g03_Click" />
                <asp:Button ID="b04" runat="server" CssClass="auto-style42" Text="" BorderColor="#00CC00" OnClick="b04_Click" />
                <asp:Button ID="c1" runat="server" CssClass="auto-style60" Text="" BorderColor="#00CC00" OnClick="c1_Click" />
                <asp:Button ID="g01" runat="server" CssClass="auto-style64" Text="" BorderColor="#00CC00" OnClick="g01_Click" />
                <asp:Button ID="a01" runat="server" CssClass="auto-style57" Text="" OnClick="a01_Click" BorderColor="#009E0C" />
                <asp:Button ID="g02" runat="server" CssClass="auto-style55" Text="" BorderColor="#00CC00" OnClick="g02_Click" />
                <asp:Button ID="b03" runat="server" CssClass="auto-style50" Text="" BorderColor="#00CC00" OnClick="b03_Click" />
                <asp:Button ID="e02" runat="server" CssClass="auto-style53" Text="" BorderColor="#00CC00" OnClick="e02_Click" />
                <asp:Button ID="e01" runat="server" CssClass="auto-style62" Text="" BorderColor="#00CC00" OnClick="e01_Click" />
                <asp:Button ID="c02" runat="server" CssClass="auto-style51" Text="" BorderColor="#00CC00" OnClick="c02_Click" />
                <asp:Button ID="d02" runat="server" CssClass="auto-style52" Text="" BorderColor="#00CC00" OnClick="d02_Click" />
                <asp:Button ID="h01" runat="server" CssClass="auto-style56" Text="" BorderColor="#00CC00" OnClick="h01_Click" />
                <asp:Button ID="b02" runat="server" CssClass="auto-style65" Text="" BorderColor="#00CC00" OnClick="b02_Click" />
                <asp:Button ID="h08" runat="server" CssClass="auto-style8" Text="" BorderColor="#00CC00" OnClick="h08_Click" />
                <asp:Button ID="b01" runat="server" CssClass="auto-style71" Text="" OnClick="b01_Click" BorderColor="#00CC00" />
            </p>
            <p>
                <asp:Button ID="a102" runat="server" CssClass="auto-style68" Text="CARGAR XML" OnClick="a102_Click"  />
            </p>&nbsp;<br />
            <br />
            <br />
                
            <br />&nbsp;<br />
            <br />
                
            <br />
            <br />
            <br />
            <br />
                <asp:Button ID="a15" runat="server" CssClass="auto-style70" Text="INICIAR" />
        </div>
    </form>
</body>
</html>
