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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
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
            background-color: #009D0E;
        }

        


        .auto-style67 {
            height: 788px;
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
            background-color: #009D0E;
        }

        


        .auto-style72 {
            background-color: #FF0000;
        }

        


        .auto-style73 {
            margin-top: 0px;
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
                &nbsp;</p> 
            <p>
                &nbsp;</p>
            <p>
                <asp:Image ID="Image1" runat="server" Height="425px" ImageUrl="~/ima/fonfo.jpg" Width="599px" CssClass="auto-style73" />
                <asp:Button ID="c08" runat="server" CssClass="auto-style20" Text="" BorderColor="#009D0E" OnClick="c08_Click" />
                <asp:Button ID="e05" runat="server" CssClass="auto-style4" Text="" BorderColor="#009D0E" OnClick="e05_Click" />
                <asp:Button ID="d04" runat="server" CssClass="auto-style1" Text="" BorderColor="#009D0E" OnClick="d04_Click" />
                <asp:Button ID="d05" runat="server" CssClass="auto-style3" Text="" BorderColor="#009D0E" OnClick="d05_Click" />
                <asp:Button ID="e03" runat="server" CssClass="auto-style45" Text="" BorderColor="#009D0E" OnClick="e03_Click" />
                <asp:Button ID="d06" runat="server" CssClass="auto-style25" Text="" BorderColor="#009D0E" OnClick="d06_Click" />
                <asp:Button ID="f08" runat="server" CssClass="auto-style10" Text="" BorderColor="#009D0E" OnClick="f08_Click" />
                <asp:Button ID="d08" runat="server" CssClass="auto-style14" Text="" BorderColor="#009D0E" OnClick="d08_Click" />
                <asp:Button ID="f03" runat="server" CssClass="auto-style46" Text="" BorderColor="#009D0E" OnClick="f03_Click" />
                <asp:Button ID="h05" runat="server" CssClass="auto-style15" Text="" BorderColor="#009D0E" OnClick="h05_Click" />
                <asp:Button ID="a02" runat="server" CssClass="auto-style49" Text="" BorderColor="#009D0E" OnClick="a02_Click" />
                <asp:Button ID="g07" runat="server" CssClass="auto-style6" Text="" BorderColor="#009D0E" OnClick="g07_Click" />
                <asp:Button ID="h06" runat="server" CssClass="auto-style7" Text="" BorderColor="#009D0E" OnClick="h06_Click" />
                <asp:Button ID="g08" runat="server" CssClass="auto-style5" Text="" BorderColor="#009D0E" OnClick="g08_Click" />
                <asp:Button ID="g06" runat="server" CssClass="auto-style16" Text="" BorderColor="#009D0E" OnClick="g06_Click" />
                <asp:Button ID="e08" runat="server" CssClass="auto-style12" Text="" BorderColor="#009D0E" OnClick="e08_Click" />
                <asp:Button ID="c06" runat="server" CssClass="auto-style26" Text="" BorderColor="#009D0E" OnClick="c06_Click" />
                <asp:Button ID="b08" runat="server" CssClass="auto-style19" Text="" BorderColor="#009D0E" OnClick="b08_Click" />
                <asp:Button ID="e07" runat="server" CssClass="auto-style11" Text="" BorderColor="#009D0E" OnClick="e07_Click" />
                <asp:Button ID="b07" runat="server" CssClass="auto-style27" Text="" BorderColor="#009D0E" OnClick="b07_Click" />
                <asp:Button ID="a08" runat="server" CssClass="auto-style22" Text="" BorderColor="#009D0E" OnClick="a08_Click" />
                <asp:Button ID="d07" runat="server" CssClass="auto-style13" Text="" BorderColor="#009D0E" OnClick="d07_Click" />
                <asp:Button ID="f07" runat="server" CssClass="auto-style9" Text="" BorderColor="#009D0E" OnClick="f07_Click" />
                <asp:Button ID="a07" runat="server" CssClass="auto-style21" Text="" BorderColor="#009D0E" OnClick="a07_Click" />
                <asp:Button ID="c05" runat="server" CssClass="auto-style40" Text="" BorderColor="#009D0E" OnClick="c05_Click" />
                <asp:Button ID="e06" runat="server" CssClass="auto-style24" Text="" BorderColor="#009D0E" OnClick="e06_Click" />
                <asp:Button ID="b06" runat="server" CssClass="auto-style39" Text="" BorderColor="#009D0E" OnClick="b06_Click" />
                <asp:Button ID="f06" runat="server" CssClass="auto-style23" Text="" BorderColor="#009D0E" OnClick="f06_Click" />
                <asp:Button ID="h02" runat="server" CssClass="auto-style31" Text="" BorderColor="#009D0E" OnClick="h02_Click" />
                <asp:Button ID="h04" runat="server" CssClass="auto-style33" Text="" BorderColor="#009D0E" OnClick="h04_Click" />
                <asp:Button ID="g05" runat="server" CssClass="auto-style34" Text="" BorderColor="#009D0E" OnClick="g05_Click" />
                <asp:Button ID="f01" runat="server" CssClass="auto-style63" Text="" BorderColor="#009D0E" OnClick="f01_Click" />
                <asp:Button ID="f05" runat="server" CssClass="auto-style32" Text="" BorderColor="#009D0E" OnClick="f05_Click" />
                <asp:Button ID="a06" runat="server" CssClass="auto-style28" Text="" BorderColor="#009D0E" OnClick="a06_Click" />
                <asp:Button ID="c03" runat="server" CssClass="auto-style43" Text="" BorderColor="#009D0E" OnClick="c03_Click" />
                <asp:Button ID="a05" runat="server" CssClass="auto-style38" Text="" BorderColor="#009D0E" OnClick="a05_Click" />
                <asp:Button ID="c07" runat="server" CssClass="auto-style17" Text="" BorderColor="#009D0E" OnClick="c07_Click" />
                <asp:Button ID="h07" runat="server" CssClass="auto-style18" Text="" BorderColor="#009D0E" OnClick="h07_Click" />
                <asp:Button ID="d03" runat="server" CssClass="auto-style44" Text="" BorderColor="#009D0E" OnClick="d03_Click" />
                <asp:Button ID="e04" runat="server" CssClass="auto-style2" Text="" BorderColor="#009D0E" OnClick="e04_Click" />
                <asp:Button ID="f04" runat="server" CssClass="auto-style29" Text="" BorderColor="#009D0E" OnClick="f04_Click" />
                <asp:Button ID="a04" runat="server" CssClass="auto-style35" Text="" BorderColor="#009D0E" OnClick="a04_Click" />
                <asp:Button ID="g04" runat="server" CssClass="auto-style48" Text="" BorderColor="#009D0E" OnClick="g04_Click" />
                <asp:Button ID="h03" runat="server" CssClass="auto-style30" Text="" BorderColor="#009D0E" OnClick="h03_Click" />
                <asp:Button ID="c04" runat="server" CssClass="auto-style37" Text="" BorderColor="#009D0E" OnClick="c04_Click" />
                <asp:Button ID="b05" runat="server" CssClass="auto-style36" Text="" BorderColor="#009D0E" OnClick="b05_Click" />
                <asp:Button ID="d01" runat="server" CssClass="auto-style61" Text="" BorderColor="#009D0E" OnClick="d01_Click" />
                <asp:Button ID="f02" runat="server" CssClass="auto-style54" Text="" BorderColor="#009D0E" OnClick="f02_Click" />
                <asp:Button ID="a03" runat="server" CssClass="auto-style41" Text="" BorderColor="#009D0E" OnClick="a03_Click" />
                <asp:Button ID="g03" runat="server" CssClass="auto-style47" Text="" BorderColor="#009D0E" OnClick="g03_Click" />
                <asp:Button ID="b04" runat="server" CssClass="auto-style42" Text="" BorderColor="#009D0E" OnClick="b04_Click" />
                <asp:Button ID="c1" runat="server" CssClass="auto-style60" Text="" BorderColor="#009D0E" OnClick="c1_Click" />
                <asp:Button ID="g01" runat="server" CssClass="auto-style64" Text="" BorderColor="#009D0E" OnClick="g01_Click" />
                <asp:Button ID="a01" runat="server" CssClass="auto-style57" Text="" OnClick="a01_Click" BorderColor="#009E0C" />
                <asp:Button ID="g02" runat="server" CssClass="auto-style55" Text="" BorderColor="#009D0E" OnClick="g02_Click" />
                <asp:Button ID="b03" runat="server" CssClass="auto-style50" Text="" BorderColor="#009D0E" OnClick="b03_Click" />
                <asp:Button ID="e02" runat="server" CssClass="auto-style53" Text="" BorderColor="#009D0E" OnClick="e02_Click" />
                <asp:Button ID="e01" runat="server" CssClass="auto-style62" Text="" BorderColor="#009D0E" OnClick="e01_Click" />
                <asp:Button ID="c02" runat="server" CssClass="auto-style51" Text="" BorderColor="#009D0E" OnClick="c02_Click" />
                <asp:Button ID="d02" runat="server" CssClass="auto-style52" Text="" BorderColor="#009D0E" OnClick="d02_Click" />
                <asp:Button ID="h01" runat="server" CssClass="auto-style56" Text="" BorderColor="#009D0E" OnClick="h01_Click" />
                <asp:Button ID="b02" runat="server" CssClass="auto-style65" Text="" BorderColor="#009D0E" OnClick="b02_Click" />
                <asp:Button ID="h08" runat="server" CssClass="auto-style8" Text="" BorderColor="#009D0E" OnClick="h08_Click" />
                <asp:Button ID="b01" runat="server" CssClass="auto-style71" Text="" OnClick="b01_Click" BorderColor="#009D0E" />
            </p>
            <p>
                CARGAR XML: <asp:FileUpload ID="fUpload" runat="server"  type="file" onchange="this.form.submit();" Width="216px"  Height="22px"  />
                
            &nbsp;&nbsp;&nbsp; GUARDAR XML:&nbsp;
                <asp:Button ID="Button1" runat="server" Height="21px" OnClick="Button1_Click" Text="GUARDAR XML" Width="108px" />
&nbsp; LIMPIAR:
                <asp:Button ID="B" runat="server" CssClass="auto-style72" Height="20px" Width="44px" OnClick="B_Click" />
            </p>
            <p>
                &nbsp;</p>&nbsp;<br />
            <br />
            <br />
                
            <br />&nbsp;<br />
            <br />
                
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
