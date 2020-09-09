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
            right: 947px;
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
            bottom: 27px;
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
        }
        .auto-style63 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            color: #fff;
            font-size: 28px;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 190px;
            margin-left: 10px;
            width: 35px;
            height: 35px;
            left: 383px;
            right: 625px;
            bottom: 251px;
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
            right: 560px;
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
        }
        .auto-style59 {
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
            right: 882px;
            background-color: #009900;
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
            right: 879px;
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
            top: 622px;
            margin-left: 10px;
            width: 156px;
            height: 44px;
            left: 308px;
            right: 579px;
        }
        .auto-style69 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            font-size: large;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 623px;
            margin-left: 10px;
            width: 156px;
            height: 44px;
            left: 475px;
        }
        .auto-style70 {
            border: 2px solid #ffffff;
            border-radius: 200px;
            font-size: large;
            font-weight: bold;
            padding: 5px 15px;
            position: absolute;
            top: 625px;
            margin-left: 10px;
            width: 156px;
            height: 44px;
            left: 637px;
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
                <asp:Image ID="Image1" runat="server" Height="425px" ImageUrl="~/ima/fonfo.jpg" Width="599px" />
                <asp:Button ID="c08" runat="server" CssClass="auto-style20" Text="" />
                <asp:Button ID="e05" runat="server" CssClass="auto-style4" Text="" />
                <asp:Button ID="d04" runat="server" CssClass="auto-style1" Text="" />
                <asp:Button ID="d05" runat="server" CssClass="auto-style3" Text="" />
                <asp:Button ID="e03" runat="server" CssClass="auto-style45" Text="" />
                <asp:Button ID="d06" runat="server" CssClass="auto-style25" Text="" />
                <asp:Button ID="f08" runat="server" CssClass="auto-style10" Text="" />
                <asp:Button ID="d08" runat="server" CssClass="auto-style14" Text="" />
                <asp:Button ID="f03" runat="server" CssClass="auto-style46" Text="" />
                <asp:Button ID="h05" runat="server" CssClass="auto-style15" Text="" />
                <asp:Button ID="a02" runat="server" CssClass="auto-style49" Text="" />
                <asp:Button ID="g07" runat="server" CssClass="auto-style6" Text="" />
                <asp:Button ID="h06" runat="server" CssClass="auto-style7" Text="" />
                <asp:Button ID="g08" runat="server" CssClass="auto-style5" Text="" />
                <asp:Button ID="g06" runat="server" CssClass="auto-style16" Text="" />
                <asp:Button ID="e08" runat="server" CssClass="auto-style12" Text="" />
                <asp:Button ID="c06" runat="server" CssClass="auto-style26" Text="" />
                <asp:Button ID="b08" runat="server" CssClass="auto-style19" Text="" />
                <asp:Button ID="e07" runat="server" CssClass="auto-style11" Text="" />
                <asp:Button ID="b07" runat="server" CssClass="auto-style27" Text="" />
                <asp:Button ID="a08" runat="server" CssClass="auto-style22" Text="" />
                <asp:Button ID="d07" runat="server" CssClass="auto-style13" Text="" />
                <asp:Button ID="f07" runat="server" CssClass="auto-style9" Text="" />
                <asp:Button ID="a07" runat="server" CssClass="auto-style21" Text="" />
                <asp:Button ID="c05" runat="server" CssClass="auto-style40" Text="" />
                <asp:Button ID="e06" runat="server" CssClass="auto-style24" Text="" />
                <asp:Button ID="b06" runat="server" CssClass="auto-style39" Text="" />
                <asp:Button ID="f06" runat="server" CssClass="auto-style23" Text="" />
                <asp:Button ID="h02" runat="server" CssClass="auto-style31" Text="" />
                <asp:Button ID="h04" runat="server" CssClass="auto-style33" Text="" />
                <asp:Button ID="g05" runat="server" CssClass="auto-style34" Text="" />
                <asp:Button ID="f01" runat="server" CssClass="auto-style63" Text="" />
                <asp:Button ID="f05" runat="server" CssClass="auto-style32" Text="" />
                <asp:Button ID="a06" runat="server" CssClass="auto-style28" Text="" />
                <asp:Button ID="c03" runat="server" CssClass="auto-style43" Text="" />
                <asp:Button ID="a05" runat="server" CssClass="auto-style38" Text="" />
                <asp:Button ID="c07" runat="server" CssClass="auto-style17" Text="" />
                <asp:Button ID="h07" runat="server" CssClass="auto-style18" Text="" />
                <asp:Button ID="d03" runat="server" CssClass="auto-style44" Text="" />
                <asp:Button ID="e04" runat="server" CssClass="auto-style2" Text="" />
                <asp:Button ID="f04" runat="server" CssClass="auto-style29" Text="" />
                <asp:Button ID="a04" runat="server" CssClass="auto-style35" Text="" />
                <asp:Button ID="g04" runat="server" CssClass="auto-style48" Text="" />
                <asp:Button ID="h03" runat="server" CssClass="auto-style30" Text="" />
                <asp:Button ID="c04" runat="server" CssClass="auto-style37" Text="" />
                <asp:Button ID="b05" runat="server" CssClass="auto-style36" Text="" />
                <asp:Button ID="d01" runat="server" CssClass="auto-style61" Text="" />
                <asp:Button ID="f02" runat="server" CssClass="auto-style54" Text="" />
                <asp:Button ID="a03" runat="server" CssClass="auto-style41" Text="" />
                <asp:Button ID="g03" runat="server" CssClass="auto-style47" Text="" />
                <asp:Button ID="b1" runat="server" CssClass="auto-style59" Text="" OnClick="b1_Click" BorderColor="#009900" />
                <asp:Button ID="b04" runat="server" CssClass="auto-style42" Text="" />
                <asp:Button ID="c1" runat="server" CssClass="auto-style60" Text="" />
                <asp:Button ID="g01" runat="server" CssClass="auto-style64" Text="" />
                <asp:Button ID="a01" runat="server" CssClass="auto-style57" Text="" OnClick="a01_Click" />
                <asp:Button ID="g02" runat="server" CssClass="auto-style55" Text="" />
                <asp:Button ID="b03" runat="server" CssClass="auto-style50" Text="" />
                <asp:Button ID="e02" runat="server" CssClass="auto-style53" Text="" />
                <asp:Button ID="e01" runat="server" CssClass="auto-style62" Text="" />
                <asp:Button ID="c02" runat="server" CssClass="auto-style51" Text="" />
                <asp:Button ID="d02" runat="server" CssClass="auto-style52" Text="" />
                <asp:Button ID="h01" runat="server" CssClass="auto-style56" Text="" />
                <asp:Button ID="b02" runat="server" CssClass="auto-style65" Text="" />
                <asp:Button ID="h08" runat="server" CssClass="auto-style8" Text="" />
            </p>
            <p>
                <asp:Button ID="a102" runat="server" CssClass="auto-style68" Text="CARGAR XML" />
                <asp:Button ID="a103" runat="server" CssClass="auto-style69" Text="CARGAR XML" />
            </p>
            <br />
            <br />
            <br />
                
            <br />
            <br />
            <br />
            <br />
                <asp:Button ID="a15" runat="server" CssClass="auto-style70" Text="CARGAR XML" />
        </div>
    </form>
</body>
</html>
