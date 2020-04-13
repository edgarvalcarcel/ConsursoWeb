<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informacion.aspx.cs" Inherits="ConsursoWeb.Paginas.Informacion" %>

<%@ Register Src="~/ControlesUsuario/Menu.ascx" TagPrefix="uc1" TagName="Menu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, user-scalable=no" />
    <title></title>
    <style>
        body {
            background-image: url(../Image/20-BG.png);
            height: 700px;
        }
        .footer {
            position: absolute;
            right: 0;
            bottom: 0;
            left: 0;
            padding: 1rem;
            background-color: black;
            text-align: center;
            margin-top: 30px;
        }
        .Image10 {
            float: right;
        }
        .bordes {

        }
          .stabla {
            padding-left:0px !important;
            padding-right:0px !important;
        }
         .stabla2 {
            padding-left:0px !important;
            padding-right:0px !important;
        }
        .footerimage {
            max-width:80px !important;
        }
        .ImagPadd {
            padding:0px 0px !important;
        }
        @media screen and (min-width:415px ) {
            .ImagPadd {
            padding:0px 0px !important;
        }
         .footerimage {
            width:80px !important
        }
            body {
            background-image: url(../Image/20-BG.png);
            height: 500px;
        }
        }
        @media screen and (min-width: 600px) {
            
                 .stabla {
            padding-left:16px !important;
            padding-right:16px !important;
        }
            body {
            background-image: url(../Image/20-BG.png);
            height: 600px;
        }
        }

        .img_foot_right{
            padding-top:17px !important;
        }
        .img_foot_left{
            padding-top:0px !important;
        }
        .txt_title{
            background-color:black;
            border-radius:15px;
            color:white;
            text-align:center;
            height:40px;
            font-size:20px;
            padding-top:7px;
            margin-bottom: 16px;
        }

        @media(max-width: 450px){
            .img_foot_right{
                padding-top: 11px !important;
            }
            .img_foot_left{
            padding-top:0px !important;
            }
        }
    </style>
</head>
<body style="background-image: url(../Image/20-BG.png);">

    <div>
        <uc1:Menu runat="server" ID="Menu" />
    </div>
    <form id="form1" runat="server">
        <div class="row">
            <div class="container col-sm-10 col-sm-offset-1 col-xs-12 hidden-xs">
            <div class="row" style="padding-bottom:100px">
                <div class="container col-xs-12  col-md-12 " >
                    <center>
                        <div style="width:95%;">
                            <center>
                                </br>
                                <asp:Image ID="Image1" CssClass="img-responsive" runat="server" ImageUrl="~/Image/Informacion.png"/>
                                                        </br>
                        </br>
                        </br>
                        </br>
                            </center>
                        </div>
                    </center>
                    
                </div>
                
            </div>
                </div>
            <div class="container visible-xs-block " >
            <div class="row" style="padding-bottom:50px">
                <div class="container col-xs-12  col-md-12 " >
                    <center>
                        <div style="width:95%;">
                            <center>
                                <div class="col-xs-10 col-xs-offset-1 txt_title">INFORMACIÓN</div>
                                <asp:Image ID="Image2" CssClass="img-responsive" runat="server" ImageUrl="~/Image/INFORMACION-APP-MP.png"/>
                                                        </br>
                        </br>
                        </br>
                        </br>
                            </center>
                        </div>
                    </center>
                  
                </div>
                
            </div>
                </div>
            <div class="row quiPadd">
            <div class="col-xs-12 quiPadd footer" style="background-color:black; height:100px;position: fixed;bottom: 0;">
                
                <footer class="footer">
                    <div class="col-xs-3 col-xs-offset-1 ImagPadd img_foot_left">
                        <asp:ImageButton ID="ImageButton2" ImageUrl="~/Image/icono_TCDL.png" CssClass="img-responsive footerimage" PostBackUrl="~/Paginas/Informacion.aspx" runat="server" />
                    </div>

                    <div class="col-xs-3 col-xs-offset-4 ImagPadd img_foot_right">
                        <asp:ImageButton ID="ImageButton1" ImageUrl="~/Image/icono_MP.png" CssClass="img-responsive Image10 footerimage"  PostBackUrl="http://www.marketingpersonal.com/" runat="server" />
                    </div>

                    <%--<asp:Image runat="server" ID="imgFooter" ImageUrl="~/Image/footer-login.png" CssClass="img-responsive" />--%>
                </footer>

            </div>
        </div>
        </div>
    </form>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
