<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PerfilRanking.aspx.cs" Inherits="ConsursoWeb.Paginas.PerfilRanking" %>

<%@ Register Src="~/ControlesUsuario/Menu.ascx" TagPrefix="uc1" TagName="Menu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        @font-face {
            font-family: "QueenOfCamelot";
            src: url("../fonts/queen_of_camelot-webfont.eot");
            src: url("../fonts/queen_of_camelot-webfont.eot?#amocristalab") format("embedded-opentype"), url("../fonts/queen_of_camelot-webfont.woff") format("woff"), url("../fonts/queen_of_camelot-webfont.ttf") format("truetype"), url("../fonts/queen_of_camelot-webfont.svg#queen_of_camelotregular") format("svg");
        }

                .Image10 {
            float: right;
        }
       .footer_dw {
            position: absolute;
            right: 0;
            bottom: 0;
            left: 0;
            padding: 1rem;
            background-color: black;
            text-align: center;
            margin-top: 30px;
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
        .txt_tab{
            font-size: 15px;
        }
        /* Modal Header */
        .modal-header {
            padding: 2px 16px;
            background-color: #5cb85c;
            color: white;
        }

        /* Modal Body */
        .modal-body {
            padding: 2px 16px;
        }

        /* Modal Footer */
        .modal-footer {
            padding: 2px 16px;
            background-color: #5cb85c;
            color: white;
        }

        /* Modal Content */
        .modal-content {
            position: relative;
            background-color: #fefefe;
            margin: auto;
            padding: 0;
            border: 1px solid #888;
            width: 80%;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
            -webkit-animation-name: animatetop;
            -webkit-animation-duration: 0.4s;
            animation-name: animatetop;
            animation-duration: 0.4s
        }
          .footerimage {
            max-width:80px !important;
        }
        .ImagPadd {
            padding:0px 0px !important;
        }
        /* Add Animation */
        @-webkit-keyframes animatetop {
            from {
                top: -300px;
                opacity: 0
            }

            to {
                top: 0;
                opacity: 1
            }
        }

        @keyframes animatetop {
            from {
                top: -300px;
                opacity: 0
            }

            to {
                top: 0;
                opacity: 1
            }
        }

        body {
            background-image: url(../Image/20-BG.png);
            height: 630px;
        }

        .modal-body #pane center img {
            width: 80%;
        }

        .cuerpo {
            background-color: #e5e6e7;
            height: 600px;
            font-family: 'Century Gothic';
        }

        .marg {
            padding-top: 5%;
            padding-bottom: 15px;
        }

        .img1 {
            float: right;
        }

        .img2 {
            vertical-align: text-bottom;
            text-align: center;
            max-width: 100%;
        }

        .ImgCerrar {
            max-width: 100%;
            padding-left: 1%;
            padding-right: 0;
            display: table-cell;
            float: none;
        }

        .tabless {
            color: white;
        }

        .puesto {
            font-family: 'Century Gothic';
            color: whitesmoke;
            font-weight: 500;
            text-align: left;
            font-size: 15px;
            margin-top: 20px;
            margin-bottom: 10px;
        }

        .bordes {
            background-color: transparent;
            height: 650px;
            opacity: 0.2
        }

        .bordes3 {
            background-color: transparent;
            opacity: 0.2;
            padding-top: 5%
        }

        .salvavidas {
            font-family: 'Century Gothic';
            color: #ee474a;
            font-weight: 400;
            text-align: left;
            font-size: 15px;
            padding: 10%;
        }

        .nombre {
            font-family: 'Century Gothic';
            color: whitesmoke;
            font-weight: 400;
            text-align: left;
            font-size: 15px;
        }

        .descripcion {
            font-family: 'Century Gothic';
            color: #ee474a;
            font-weight: 400;
            text-align: center;
            font-size: 15px;
            padding-top: 6%;
            padding-bottom: 5%;
        }

        .a2 {
            font-family: 'Century Gothic';
            background-color: #ee474a;
            color: whitesmoke;
            font-weight: 400;
        }

        .nav-tabs > li.active > .a2, .nav-tabs > li.active > .a2:hover, .nav-tabs > li.active > .a2:focus {
            background-color: #e5e6e7;
            color: #ee474a;
            font-weight: 400;
            font-family: 'Century Gothic';
        }

        .a2:hover {
            background-color: #e5e6e7;
            color: #ee474a;
            font-weight: 400;
            font-family: 'Century Gothic';
        }

        .titulos {
            background-color: #0d0d0d;
            color: whitesmoke;
            font-weight: 400;
            font-size: 13px;
            height: 20px;
            border-radius: 5px;
            width: 90%;
            vertical-align: central;
            text-align: center;
            font-family: 'Century Gothic';
        }

        .titulos2 {
            background-color: #0d0d0d;
            color: whitesmoke;
            font-weight: 400;
            font-size: 13px;
            height: 20px;
            border-radius: 5px;
            width: 100%;
            vertical-align: central;
            text-align: center;
            font-family: 'Century Gothic';
            padding-left:0px !important;
            padding-right:0px !important;
        }
        .ccr {
            margin-top: 1px;
            height: 20px;
            font-size: 7px;
            text-align: center !important;
            padding-left: 0px !important;
            padding-right: 0px !important;
        }

        .izquierdo {
            font-family: 'Century Gothic';
            border-right: 1px solid black;
            border-top: 1px solid black !important;
            border-bottom: 1px solid black;
            border-left: 0px hidden;
            text-align: left;
            height: 34px;
            font-weight: 400;
            font-size: 14px;
            color:whitesmoke;
        }

        .izquierdoTi {
            font-family: 'Century Gothic';
            border: 0px hidden;
            height: 0px;
            visibility: hidden;
        }

        .derecho {
            border-right: 1px solid black;
            border-top: 1px solid black !important;
            border-bottom: 1px solid black;
            border-left: 1px solid black;
            text-align: center;
            height: 34px;
            font-family: 'Century Gothic';
            font-weight: 400;
            font-size: 13px;
            padding-left: 0px !important;
            padding-right: 0px !important;
            color:whitesmoke;
        }
        .derecho2 {
            border-right: 1px solid #C64B4D;
            border-top: 1px solid black !important;
            border-bottom: 1px solid black;
            border-left: 1px solid black;
            text-align: center;
            height: 34px;
            font-family: 'Century Gothic';
            font-weight: 400;
            font-size: 13px;
            padding-left: 0px !important;
            padding-right: 0px !important;
            color:whitesmoke;
        }
        .derechoTi {
            border: 0px hidden;
            height: 0px;
            visibility: hidden;
            font-family: 'Century Gothic';
        }

        .stabla {
            padding-left: 0px !important;
            padding-right: 0px !important;
        }

        .stabla2 {
            padding-left: 0px !important;
            padding-right: 0px !important;
        }

        .margtop {
            padding: 3%;
        }

        @media screen and (min-width:415px ) {
              .footerimage {
            max-width:80px !important;
        }
        .ImagPadd {
            padding:0px 0px !important;
        }
            .puesto {
                font-family: 'Century Gothic';
                color:whitesmoke;
                font-weight: 500;
                padding-top: 3%;
                text-align: left;
                font-size: 30px;
                margin-top: 20px;
                margin-bottom: 10px;
            }

            body {
                background-image: url(../Image/background.png);
                background-repeat: no-repeat;
                height: 800px;
            }

            .cuerpo {
                font-family: 'Century Gothic';
                background-color: #e5e6e7;
                height: 750px;
            }

            .izquierdo {
                border-right:1px solid black;
                border-top:1px solid black !important;
                border-bottom:1px solid black;
                border-left: 0px hidden;
                text-align: left;
                height: 34px;
                font-weight: 400;
                font-size: 18px;
                font-family: 'Century Gothic';
                color:whitesmoke;
            }

            .derecho {
                border-right:1px solid black;
                border-top: 1px solid black !important;
                border-bottom: 1px solid black;
                border-left: 1px solid black;
                text-align: center;
                height: 34px;
                font-weight: 400;
                font-size: 16px;
                padding-left: 0px !important;
                padding-right: 0px !important;
                font-family: 'Century Gothic';
                color:whitesmoke;
            }
            .derecho2 {
                border-right:1px solid #C64B4D;
                border-top: 1px solid black !important;
                border-bottom: 1px solid black;
                border-left: 1px solid black;
                text-align: center;
                height: 34px;
                font-weight: 400;
                font-size: 16px;
                padding-left: 0px !important;
                padding-right: 0px !important;
                font-family: 'Century Gothic';
                color:whitesmoke;
            }

            .salvavidas {
                font-family: 'Century Gothic';
                color: #ee474a;
                font-weight: 500;
                text-align: right;
                font-size: 22px;
                padding: 13%;
            }

            .nombre {
                font-family: Queen of Camelot;
                color: whitesmoke;
                font-weight: 400;
                text-align: left;
                font-size: 15px;
                font-family: 'Century Gothic';
            }

            .stabla {
                padding-left: 0px !important;
                padding-right: 0px !important;
            }
        }

        @media screen and (min-width: 500px) {

            .stabla {
                padding-left: 15px !important;
                padding-right: 15px !important;
            }

            .ccr {
                margin-top: 1px;
                height: 20px;
                font-size: 11px;
                text-align: center !important;
                padding-left: 0px !important;
                padding-right: 0px !important;
            }

            .puesto {
                font-family: 'Century Gothic';
                color: whitesmoke;
                font-weight: 500;
                padding-top: 3%;
                text-align: left;
                font-size: 38px;
                margin-top: 20px;
                margin-bottom: 10px;
            }

            body {
                background-image: url(../Image/20-BG.png);
                height: 900px;
            }

            .cuerpo {
                font-family: 'Century Gothic';
                background-color: #e5e6e7;
                height: 750px;
            }

            .izquierdo {
                border-right:1px solid black;
                border-top: 1px solid black !important;
                border-bottom:1px solid black;
                border-left: 0px hidden;
                text-align: left;
                height: 34px;
                font-weight: 400;
                font-size: 20px;
                font-family: 'Century Gothic';
                color:whitesmoke;
            }

            .derecho {
                border-right: 1px solid black;
                border-top:1px solid black !important;
                border-bottom:1px solid black;
                border-left: 1px solid black;
                text-align: center;
                height: 34px;
                font-weight: 400;
                font-size: 20px;
                font-family: 'Century Gothic';
                color:whitesmoke;
            }
            .derecho2 {
                border-right: 1px solid #C64B4D;
                border-top:1px solid black !important;
                border-bottom:1px solid black;
                border-left: 1px solid black;
                text-align: center;
                height: 34px;
                font-weight: 400;
                font-size: 20px;
                font-family: 'Century Gothic';
                color:whitesmoke;
            }
            .salvavidas {
                font-family: 'Century Gothic';
                color: #ee474a;
                font-weight: 500;
                text-align: right;
                font-size: 22px;
                padding: 13%;
            }

            .nombre {
                color: whitesmoke;
                font-weight: 400;
                text-align: left;
                font-size: 20px;
                font-family: 'Century Gothic';
            }
        }

        @media screen and (min-width: 600px) {


            .titulos {
                font-family: 'Century Gothic';
                background-color: black;
                color: whitesmoke;
                font-weight: 400;
                font-size: 20px;
                height: 50px;
                border-radius: 5px;
                width: 86%;
                vertical-align: central;
                text-align: center;
            }

            .cuerpo {
                font-family: 'Century Gothic';
                background-color: #e5e6e7;
                height: 950px;
            }

            .ccr {
                
                height: 40px;
                text-align: center !important;
                font-size: 10px;
                padding-left: 15px !important;
            }

            .descripcion {
                font-family: 'Century Gothic';
                color: #ee474a;
                font-weight: 500;
                text-align: center;
                font-size: 20px;
                padding-top: 6%;
                padding-bottom: 5%;
            }

            .nombre {
                font-family: 'Century Gothic';
                color: white;
                font-weight: 400;
                text-align: left;
                font-size: 24px;
            }
        }

        @media screen and (min-width: 768px) {

            .bordes {
                background-color: #93cbca;
                height: 1320px;
                opacity: 0.2
            }

            .cuerpo {
                font-family: 'Century Gothic';
                background-color: #e5e6e7;
                height: 950px;
            }

            .bordes3 {
                background-color: #93cbca;
                opacity: 0.2;
                padding-top: 13.5%
            }

            .img2 {
                vertical-align: text-bottom;
                text-align: center;
                max-width: 80%;
            }

            body {
                background-image: url(../Image/20-BG.png);
                height: 900px;
            }
        }

        @media screen and (min-width: 992px) {
            .bordes3 {
                background-color: #93cbca;
                padding-top: 10.8%;
                opacity: 0.2
            }

            .cuerpo {
                font-family: 'Century Gothic';
                background-color: #e5e6e7;
                height: 1100px;
            }

            .img2 {
                vertical-align: text-bottom;
                text-align: center;
                max-width: 95%;
            }
        }

        .img_foot_right{
            padding-top:17px !important;
        }
        .img_foot_left{
            padding-top:0px !important;
        }

        @media(max-width: 450px){
            .img_foot_right{
                padding-top: 11px !important;
            }
            .img_foot_left{
            padding-top:0px !important;
            }
            .txt_tab{
            font-size: 7px;
            }
            .footer_dw {
            position: relative !important;
            }
        }

    </style>
</head>


<body>
    <div>
        <uc1:Menu runat="server" ID="Menu" />
    </div>
    <form id="form1" runat="server">
                          <div class="container visible-xs-block " >
                    <center>
                        <div style="width:100%;">
                            <center>
                                <div class="col-xs-10 col-xs-offset-1 txt_title">PERFIL Y POSICIÓN</div>                                                       
                            </center>
                        </div>
                    </center>
                </div>
        <div class="row stabla2">
            <div class="row stabla2 hidden-sm hidden-xs">

                <div class="container">
                    <div class="row" style="background-image: url(../Image/Fondo_gris_.png); border-radius: 15px; padding: 30px 10px; margin: 20px 0px">
                        <div class="col-md-12">
                            <div class="col-md-4" style="text-align: center;">
                                <img class="img-responsive" src="../Image/Logo_.png" style="margin: 0 auto; width: 40%; display: initial;">
                                <div class="row">
                                    <!-- user info -->
                                    <div class="col-md-12" style="background-color: black; border-radius: 25px; text-align: -webkit-center; margin: 20px 0px;">
                                        <div class="col-xs-12 margtop">
                                            <h3 style="color: white">TU PERFIL</h3>

                                            <div class="col-xs-2 col-xs-offset-1 stabla" style="vertical-align: middle;">
                                                <right>
                                                        <img class="img-responsive" src="../Image/name.png" />
                                                        </right>
                                            </div>
                                            <div class="col-xs-9 " style="height: 0">
                                            </div>
                                            <div class="col-xs-9 nombre " style="vertical-align: middle; color: white; font-size: 13px">
                                                <asp:Label ID="LblNombreCompleto" runat="server" Text=""></asp:Label>
                                            </div>
                                        </div>
                                        <div class="col-xs-12 margtop">

                                            <div class="col-xs-2 col-xs-offset-1 stabla" style="vertical-align: middle; color: white; font-size: 13px">
                                                <right>
                                                        <img class="img-responsive" src="../Image/id.png" />
                                                        </right>
                                            </div>
                                            <div class="col-xs-9 " style="height: 0">
                                            </div>
                                            <div class="col-xs-9 nombre" style="vertical-align: middle; color: white; font-size: 13px">
                                                <asp:Label ID="LblIdentificacion" runat="server" Text=""></asp:Label>
                                            </div>
                                        </div>

                                        <div class="col-xs-12 margtop">

                                            <div class="col-xs-2 col-xs-offset-1 stabla" style="vertical-align: middle; color: white; font-size: 13px">
                                                <right>
                                                        <img class="img-responsive" src="../Image/mobile.png" />
                                                        </right>
                                            </div>
                                            <div class="col-xs-9 " style="height: 0">
                                            </div>
                                            <div class="col-xs-9 nombre" style="vertical-align: middle; color: white; font-size: 13px">
                                                <asp:Label ID="LblTelefono" runat="server" Text=""></asp:Label>
                                            </div>
                                        </div>

                                        <div class="col-xs-12 margtop">

                                            <div class="col-xs-2 col-xs-offset-1 stabla" style="vertical-align: middle; color: white; font-size: 13px">
                                                <right>
                                                        <img class="img-responsive" src="../Image/mail.png" />
                                                        </right>
                                            </div>
                                            <div class="col-xs-9 " style="height: 0">
                                            </div>
                                            <div class="col-xs-9 nombre" style="vertical-align: middle; color: white; font-size: 13px">
                                                <asp:Label ID="LblEmail" runat="server" Text=""></asp:Label>
                                            </div>
                                        </div>

                                    </div>
                                    <!-- user info -->
                                    <!-- Modal content -->

                                    <asp:Image runat="server" CssClass="img-responsive" ImageUrl="~/Image/Btn_Salvavidas.png" data-toggle="modal" data-target="#myModal" />
                                </div>

                            </div>
                            <div class="modal fade" style="" id="myModal" role="dialog">
                                <div class="modal-dialog modal-lg">

                                    <div style="" class="modal-content">
                                        <%--                                                    <div class="modal-header">
                                                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                        <h3 class="modal-title" style="font-weight: 700;">Imagen</h3>
                                                    </div>--%>
                                        <div class="modal-body">
                                            <asp:Panel ID="pane" runat="server" Height="" ScrollBars="Vertical">
                                                <center>
                                                            <asp:Image runat="server" ImageUrl="../Image/lifesafe.png" />
                                                            </center>
                                            </asp:Panel>
                                        </div>
                                        <div class="modal-footer" style="background-color: black">
                                            <center>
                                                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                                                        </center>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-7 col-md-offset-1" style="background-color: #C64B4D; border-radius: 25px; margin-top: 10px">
                                <div>
                                    <center> <!-- user position -->
                                                    <div class="col-xs-12" >
                                                        <div class="raw">
                                                            <div class="col-md-4">
                                                                <h2 style="text-align: -webkit-right; color:white">POSICIÓN</h2>
                                                            </div>
                                                            <div class="col-md-2">
                                                                <img class="img-responsive" src="../Image/Logo_.png" style="width: 50%; margin-top: 10px; float: left;">
                                                            </div>
                                                            <div class="col-md-6" style="text-align:left;font-size:40px;color:white">
                                                                <asp:Label runat="server" Text="">Nº </asp:Label>
                                                                 <asp:Label ID="Lblpuesto" runat="server" Text=""></asp:Label>
                                                            </div>
                                                        </div>
                                                         

                                                    </div>
                                                    <center>
                                                    <div class="col-xs-12 titulos" >
                                                        <div class="col-xs-3 ccr">
                                                            CAMPAÑA  
                                                         </div>
                                                        <div class="col-xs-3 ccr " style="text-align:right" >
                                                            TU CRECIMIENTO
                                                        </div>
                                                        <div class="col-xs-2 ccr " style="text-align:right" >
                                                            TU META
                                                        </div>
                                                        <div class="col-xs-2 ccr " style="text-align:right" >
                                                            TUS PUNTOS
                                                        </div>
                                                        <div class="col-xs-2 ccr " style="text-align:right" >
                                                            SALVAVIDAS
                                                        </div>
                                                        
                                                    </div>
                                                        </center>

                                                    <div class="col-xs-12 stabla" >
                                                        <center style="margin-top:-1px;">
                                                            <asp:GridView ID="GVCamCrec" runat="server" 
                                                                AutoGenerateColumns="False" 
                                                                CssClass="tabless table table-responsive" ShowHeader="False">
                                                                <Columns>
                                                                    <asp:BoundField DataField="DescripcionCampaña" SortExpression="DescripcionCampaña" >
                                                                    <HeaderStyle  CssClass="col-xs-3 izquierdoTi" Height="0px"/>
                                                                    <ItemStyle CssClass="col-xs-3 izquierdo" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="PorcentajeActual" SortExpression="PorcentajeActual"  DataFormatString="{0:} %">
                                                                    <ControlStyle CssClass="col-xs-6"></ControlStyle>

                                                                    <HeaderStyle  CssClass="col-xs-3 derechoTi" Height="0px"/>
                                                                    <ItemStyle CssClass="col-xs-3 derecho" />
                                                                    </asp:BoundField>
                                                                 
                                                                    <asp:BoundField DataField="Meta"  HeaderText="Meta" SortExpression="Meta" >
                                                                    <ControlStyle CssClass="col-xs-2"></ControlStyle>

                                                                    <HeaderStyle  CssClass="col-xs-2 derechoTi" Height="0px"/>
                                                                    <ItemStyle CssClass="col-xs-2 derecho" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="ValorActual"  HeaderText="ValorActual" SortExpression="ValorActual" >
                                                                    <ControlStyle CssClass="col-xs-2"></ControlStyle>
                                                                        
                                                                    <HeaderStyle  CssClass="col-xs-2 derechoTi" Height="0px"/>
                                                                    <ItemStyle CssClass="col-xs-2 derecho" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Salvavidas"  HeaderText="Salvavidas" SortExpression="Salvavidas" >
                                                                    <ControlStyle CssClass="col-xs-2"></ControlStyle>

                                                                    <HeaderStyle  CssClass="col-xs-2 derechoTi" Height="0px"/>
                                                                    <ItemStyle CssClass="col-xs-2 derecho2" />
                                                                    </asp:BoundField>
                                                                </Columns>
                                                            </asp:GridView>
                                                        </center>
                                                    </div>
                                                </center>
                                </div>
                            </div>

                            <div class="col-xs-10 col-xs-offset-1">
                                <div class="col-xs-8 col-md-9"></div>
                                <div class="col-xs-4  col-md-3 ImgCerrar stabla">
                                    <asp:ImageButton ID="BtnCerrar" OnClick="BtnCerrar_Click" CssClass="ImgCerrar" runat="server" ImageUrl="~/Image/clsssn.png" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- container-->

            </div>

            <div class="hidden-lg hidden-md">

                <div class="row stabla2">
                    
                    <div class="container col-xs-10 col-xs-offset-1  col-md-6 col-md-offset-3">
                        <center>
                    <div style="width:100%;">

                    <ul class="nav nav-tabs">
                        <li >
                            <a href="#primera" class="a2" data-toggle="tab">TU PERFIL</a>
                        </li>
                        <li class="active">
                            <a href="#segunda" class="a2" data-toggle="tab">MI POSICIÓN</a>
                        </li>
                    </ul>
                    <div class="tab-content clearfix  ">

                        <div class="tab-pane cuerpo " id="primera">
                            <div class="row">

                            <div class="col-xs-12" style="padding-bottom:7%">
                                <br />
                                
                                <br />
                                <center>
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/Logo_.png" CssClass="img-responsive"/>
                                
                                </center>
                            </div>
                                
                            <div class="col-xs-10 col-xs-offset-1"  style=" color:whitesmoke; background-color: black; border-radius: 25px; text-align: -webkit-center; ">
                            <h3>
                                TU PERFIL
                            </h3>
                            <div class="col-xs-12 margtop" >
                                
                            <div class="col-xs-12 nombre " style="text-align:center; vertical-align:middle">
                                <asp:Label ID="LabelNombre" runat="server" Text=""></asp:Label>
                            </div>
                            </div>
                            <div class="col-xs-12 margtop" >
                                
                            <div class="col-xs-2 col-xs-offset-1 stabla" style=" vertical-align: middle;">
                                <right>
                                <img class="img-responsive" src="../Image/id.png" />
                                </right>
                            </div>
                            <div class="col-xs-9 " style=" height:10px">
                               
                            </div>
                            <div class="col-xs-9 nombre" style=" vertical-align:middle">
                               <asp:Label ID="LabelIdentificacion" runat="server" Text=""></asp:Label>
                            </div>
                            </div>

                            <div class="col-xs-12 margtop" >
                                
                            <div class="col-xs-2 col-xs-offset-1 stabla" style=" vertical-align: middle;">
                                <right>
                                <img class="img-responsive" src="../Image/mobile.png" />
                                </right>
                            </div>
                            <div class="col-xs-9 " style=" height:10px">
                               
                            </div>
                            <div class="col-xs-9 nombre" style=" vertical-align:middle">
                               <asp:Label ID="LabelTelefono" runat="server" Text=""></asp:Label>
                            </div>
                            </div>

                            <div class="col-xs-12 margtop" >
                                
                            <div class="col-xs-2 col-xs-offset-1 stabla" style=" vertical-align: middle;">
                                <right>
                                <img class="img-responsive" src="../Image/mail.png" />
                                </right>
                            </div>
                            <div class="col-xs-9 " style=" height:10px">
                               
                            </div>
                            <div class="col-xs-9 nombre" style=" vertical-align:middle">
                               <asp:Label ID="LabelEmail" runat="server" Text=""></asp:Label>
                            </div>
                            </div>
                            </div>
                            <div class="col-xs-10 col-xs-offset-1" style="padding-top:20px;">
                                <div class="col-xs-12 col-md-offset-4  col-md-3 ImgCerrar stabla" >
                                    <asp:ImageButton ID="ImageButton3" OnClick="BtnCerrar_Click" CssClass="ImgCerrar" runat="server" ImageUrl="~/Image/clsssn.png"/>
                                </div>
                            </div>
                            </div>
                        </div>
                        <div class="tab-pane cuerpo active" id="segunda">
      
                            <div class="col-xs-12 " >
                            <center>
                                <div style="background-color:#C64B4D; float:left; border-radius:15px; width:100%; margin-top:5%">
                            
                            <div class="col-xs-5 puesto">
                                
                                POSICIÓN 
                            </div>
                            <div class="col-xs-2 marg" style="margin-top:3%">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/Image/Logo_.png" CssClass="img-responsive img-circle img1"/>
                                
                            </div>
                            <div class="col-xs-5 nombre" style="margin-top:6%; color:whitesmoke" >
                                N° <asp:Label ID="LabelPuesto" runat="server" CssClass="puesto" Text=""></asp:Label>
                            </div>
                            <center>
                            <center>
                            <div class="col-xs-10 col-xs-offset-1 titulos2" >
                                <div class="col-xs-3 ccr stabla">
                                    <span class="txt_tab">Campaña</span>  
                                 </div>
                                <div class="col-xs-3 ccr stabla" style="text-align:right" >
                                    <span class="txt_tab">%Crecimiento</span>
                                </div>
                                <div class="col-xs-2 ccr stabla" style="text-align:right" >
                                    <span class="txt_tab">Meta</span>
                                </div>
                                <div class="col-xs-2 ccr stabla" style="text-align:right" >
                                    <span class="txt_tab">Actual</span>
                                </div>
                                <div class="col-xs-2 ccr stabla" style="text-align:right" >
                                    <span class="txt_tab">Salvavidas</span>
                                </div>
                                
                            </div>
                                </center>
                                </center>
                            <div class="col-xs-10 col-xs-offset-1 stabla" >
                                <center>
                                    <asp:GridView ID="GridView1" runat="server" 
                                        AutoGenerateColumns="False" 
                                        CssClass="table table-responsive" ShowHeader="False">
                                        <Columns>
                                            <asp:BoundField DataField="DescripcionCampaña" SortExpression="DescripcionCampaña" >
                                            <HeaderStyle  CssClass="col-xs-3 izquierdoTi" Height="0px"/>
                                            <ItemStyle CssClass="col-xs-3 izquierdo" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="PorcentajeActual" SortExpression="PorcentajeActual"  DataFormatString="{0:} %">
                                            <ControlStyle CssClass="col-xs-6"></ControlStyle>

                                            <HeaderStyle  CssClass="col-xs-3 derechoTi" Height="0px"/>
                                            <ItemStyle CssClass="col-xs-3 derecho" />
                                            </asp:BoundField>
                                         
                                            <asp:BoundField DataField="Meta"  HeaderText="Meta" SortExpression="Meta" >
                                            <ControlStyle CssClass="col-xs-2"></ControlStyle>

                                            <HeaderStyle  CssClass="col-xs-2 derechoTi" Height="0px"/>
                                            <ItemStyle CssClass="col-xs-2 derecho" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="ValorActual"  HeaderText="ValorActual" SortExpression="ValorActual" >
                                            <ControlStyle CssClass="col-xs-2"></ControlStyle>
                                                
                                            <HeaderStyle  CssClass="col-xs-2 derechoTi" Height="0px"/>
                                            <ItemStyle CssClass="col-xs-2 derecho" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Salvavidas"  HeaderText="Salvavidas" SortExpression="Salvavidas" >
                                            <ControlStyle CssClass="col-xs-2"></ControlStyle>

                                            <HeaderStyle  CssClass="col-xs-2 derechoTi" Height="0px"/>
                                            <ItemStyle CssClass="col-xs-2 derecho2" />
                                            </asp:BoundField>
                                        </Columns>
                                    </asp:GridView>
                                  
                                </center>
                            </div>
                                
                            </div>
                                </center>
                            </div>    
                            <div class="col-xs-10 col-xs-offset-1 stabla" >
                                <div class="col-xs-10 col-xs-offset-1 stabla" style="padding-top:5%">
                                    <center>
                                    <asp:Image runat="server" CssClass="img-responsive" ImageUrl="~/Image/Btn_Salvavidas.png" data-toggle="modal" data-target="#myModal2" />
                                   </center>
                                </div>
<%--<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">Popup image</button>--%>
                              <div class="col-xs-8 col-md-offset-4  col-md-3 ImgCerrar stabla" style="padding-top:5%; margin-left: 42px !important;">
                                         <asp:ImageButton ID="ImageButton4" OnClick="BtnCerrar_Click" CssClass="ImgCerrar img-responsive" runat="server" ImageUrl="~/Image/clsssn.png"/>
                              </div>
                            </div>
                            <div class="modal fade" style="" id="myModal2" role="dialog">
                                <div class="modal-dialog modal-lg">

                                    <div style="" class="modal-content">
                                        <%--                                                    <div class="modal-header">
                                                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                        <h3 class="modal-title" style="font-weight: 700;">Imagen</h3>
                                                    </div>--%>
                                        <div class="modal-body">
                                            <asp:Panel ID="Panel1" runat="server" Height="" ScrollBars="Vertical">
                                                <center>
                                                            <img runat="server" class="img-responsive" src="../Image/lifesafe.png" />
                                                            </center>
                                            </asp:Panel>
                                        </div>
                                        <div class="modal-footer" style="background-color: black">
                                            <center>
                                                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                                                        </center>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                        
                    </div>
                        </center>
                    </div>
                    
                </div>

            </div>
<div class="row quiPadd">
            <div class="col-xs-12 quiPadd footer_dw" style="background-color:black; height:100px;position: fixed;bottom: 0;">
                
                <footer class="footer">
                    <div class="col-xs-6 col-md-6 ImagPadd img_foot_left">
                        <asp:ImageButton ID="ImageButton2" ImageUrl="~/Image/icono_TCDL.png" CssClass="img-responsive footerimage" PostBackUrl="~/Paginas/Informacion.aspx" runat="server" />
                    </div>

                    <div class="col-xs-6 col-md-6 ImagPadd img_foot_right">
                        <asp:ImageButton ID="ImageButton1" ImageUrl="~/Image/icono_MP.png" CssClass="img-responsive Image10 footerimage"  PostBackUrl="http://www.marketingpersonal.com/" runat="server" />
                    </div>

                    <%--<asp:Image runat="server" ID="imgFooter" ImageUrl="~/Image/footer-login.png" CssClass="img-responsive" />--%>
                </footer>

            </div>
        </div>
        </div>
    </form>

    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
