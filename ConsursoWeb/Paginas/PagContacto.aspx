<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagContacto.aspx.cs" Inherits="ConsursoWeb.Paginas.PagContacto" %>

<%@ Register Src="~/ControlesUsuario/Menu.ascx" TagPrefix="uc1" TagName="Menu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, user-scalable=no" />
    <title></title>
    <style>
        @font-face {
            font-family:"QueenOfCamelot";
            src: url("../fonts/queen_of_camelot-webfont.eot"); 
            src: url("../fonts/queen_of_camelot-webfont.eot?#amocristalab") format("embedded-opentype"), 
                 url("../fonts/queen_of_camelot-webfont.woff") format("woff"), 
                 url("../fonts/queen_of_camelot-webfont.ttf") format("truetype"), 
                 url("../fonts/queen_of_camelot-webfont.svg#queen_of_camelotregular") format("svg");
        }
        body {
            background-image: url(../Image/20-BG.png);
            height: 600px;
        }
                .Image10 {
            float: right;
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
        .telefono {
            background:#000000;
            color:whitesmoke;
            border-radius:50px;
            width:90%;
            height:57px;
            font-size:16px;
            border:0;
            text-align:center;
            font-family:'Century Gothic';
            

                }

        .telefono a {
            color: white;
        }
        
         .texto
        {
            font-family:'Century Gothic';
            color: #ee474a;
            font-weight: 500;
            font-size:20px;
        }
         .texto2
        {
            font-family:'Century Gothic';
            color: #ee474a;
            font-weight: 500;
            font-size:12px;
        }
        .caja {
            border: 1px solid #ee474a;
            width:100%;
            height:250px;
            border-radius:20px;
            font-family:'Century Gothic';
            color: #ee474a;
        }

        .continuar {
            background:#93cbca;
            color:whitesmoke;
            border-radius:50px;
            width:100%;
            height:32px;
            font-size:15px;
            border:0;
            font-family:'Century Gothic';
        }
        .aceptar {

            background:#93cbca;
            color:whitesmoke;
            border-radius:50px;
            width:40%;
            height:36px;
            font-size:20px;
            border:0;
            font-family:'Century Gothic';
        }
        
        .bordes {

            background-color:transparent;padding-top:100%;opacity:0.2
        }
        .bordes3 {

            background-color:transparent;opacity:0.2; padding-top: 5%
        }
         .stabla {
            padding-left:0px !important;
            padding-right:0px !important;
        }
         .stabla2 {
            padding-left:0px !important;
            padding-right:0px !important;
        }
          .Contenedor {
        background-color:#e3e6e7;border-radius:15px;opacity:0.9
        }
                  .footerimage {
            max-width:80px !important;
        }
        .ImagPadd {
            padding:0px 0px !important;
        }
        @media screen and (min-width:415px ) {
                    .footerimage {
            max-width:80px !important;
        }
        .ImagPadd {
            padding:0px 0px !important;
        }
             .Contenedor {
        background-color:#e3e6e7;border-radius:15px;opacity:0.9
        }
            .texto
        {
            font-family:'Century Gothic';
            color: #ee474a;
            font-weight: 500;
            font-size:27px;
        }
            .texto2
        {
            font-family:'Century Gothic';
            color: #ee474a;
            font-weight: 500;
            font-size:18px;
        }
            .caja {
            border: 1px solid #ee474a;
            width:100%;
            height:300px;
            border-radius:20px;
        }
             .stabla {
            padding-left:0px !important;
            padding-right:0px !important;
        }
            body {
            background-image: url(../Image/20-BG.png);
            height: 800px;
        }
        }
        @media screen and (min-width: 600px) {
            .Contenedor {
                background-color:transparent;border-radius:15px;opacity:1
            }
                .continuar {
                background:#93cbca;
                color:whitesmoke;
                border-radius:50px;
                width:100%;
                height:36px;
                font-size:20px;
                border:0;
            }
                 .stabla {
                padding-left:16px !important;
                padding-right:16px !important;
            }
                   .caja {
                border: 1px solid #ee474a;
                width:100%;
                height:374px;
                border-radius:20px;
            }
                .telefono {
                    background:#000000;
                    color:whitesmoke;
                    border-radius:50px;
                    width:90%;
                    height:87px;
                    font-size:18px;
                    border:0;
                }

                   .texto
            {
                font-family:'Century Gothic';
                color: #ee474a;
                font-weight: 500;
                font-size:36px;
            }
                   .texto2
            {
                font-family:'Century Gothic';
                color: #ee474a;
                font-weight: 500;
                font-size:25px;
            }

        }
        
@media screen and (min-width: 768px) {
     .Contenedor {
        background-color:transparent;border-radius:15px;opacity:1
        }
                .bordes {
                    background-color: #93cbca;
                    padding-top: 145%;
                    opacity: 0.2
                }

                .bordes3 {
                    background-color: #93cbca;
                    opacity: 0.2;
                    padding-top: 13.4%
                }
                body {
            background-image: url(../Image/20-BG.png);
            height: 900px;
        }
}

@media screen and (min-width: 870px) {
     .Contenedor {
        background-color:transparent;border-radius:15px;opacity:1
        }
            .bordes {
                background-color: #93cbca;
                padding-top: 132%;
                opacity: 0.2
            }
}
@media screen and (min-width: 992px) {
     .Contenedor {
        background-color:transparent;border-radius:15px;opacity:1
        }
            .bordes {
                background-color: #93cbca;
                padding-top: 100%;
                opacity: 0.2
            }
            .bordes3 {
                    background-color: #93cbca;
                    opacity: 0.2;
                    padding-top: 10.7%
                }
}
        @media screen and (min-width: 1101px) {
             .Contenedor {
        background-color:transparent;border-radius:15px;opacity:1
        }
            .bordes {
                background-color: #93cbca;
                padding-top: 96%;
                opacity: 0.2
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

        /* Bootstrap point xs*/
        @media only screen and (max-width : 480px){
            .telefono {
                color:white;
                width:100%;
                height:auto;
                font-size:26px;
                padding: 10px;
            }


        }

        /* Bootstrap point xs*/
        @media only screen and (max-width : 480px){
            .Contenedor {
                /*background-color: rgba(0, 191, 255, .8);*/
                background-color: rgba(227, 230, 231, 0.8);
                margin: 16px 10px;
            }
        }
    </style>
</head>
<body >
    
         <div >
                <uc1:Menu runat="server" ID="Menu" />
            </div>
    
    <form id="form1" runat="server">
        <div class="container visible-xs-block " >
        <center>
            <div style="width:100%;">
                <center>
                    <div class="col-xs-10 col-xs-offset-1 txt_title">CONTÁCTANOS</div>                                                       
                </center>
            </div>
        </center>
    </div>
        <div class="row">
            <div class="row">
                <div class="container col-xs-10 col-xs-offset-1 col-md-6 col-md-offset-3 Contenedor">
            
                <div class="row">
                    <div class="col-xs-12 texto2" style="padding:20px 0px;">
                        <center>
                            <span style="color:black"> Contáctanos en nuestra linea nacional gratuita,</span>
                        </center>
                    </div>
                    <div class="col-xs-12">
                        <center>
                        <div class="telefono" style="padding-top:14px">
                            <a id="aTel" runat="server"></a>
                        </div>
                        </center>
                    </div>

                    <div class="col-xs-12 texto2" style="padding: 20px 0px">
                        <center>
                            <span style="color:black">Si estás en alguna de estas ciudades</span>
                        </center>
                    </div>

                    <div class="col-xs-12">
                        <center>
                            <asp:Image ID="Image1" CssClass="img-responsive" ImageUrl="~/Image/pop-up-contactenos.png" runat="server"></asp:Image>
                        </center>
                    </div>
                   <%-- <div class="col-xs-12 texto" style="padding-top:3%;">
                        <center>
                            ¿EN QUÉ TE PODEMOS AYUDAR?
                        </center>
                    </div>
                    <div class="col-xs-12" style="padding-top:3%;">
                        <center>
                            <asp:TextBox ID="TxtDescripcion"   runat="server" CssClass="caja" Rows="0" TextMode="MultiLine"></asp:TextBox>
                        </center>
                    </div>
                    <div class="col-xs-12 col-md-12" style="padding-top:3%;">
                                    <div class="col-xs-7 col-md-8"></div>
                                    <div class="col-xs-5 col-md-4 ImgCerrar stabla" >
                                        <asp:Button ID="Continuar" runat="server" Text="CONTINUAR" CssClass="continuar" />
                                    </div>
                                </div>
                    <div class="col-xs-12" style="padding-top:5%;">
                        <center>
                            <asp:Button ID="BtnEnviar" runat="server" Text="ENVIAR" CssClass="aceptar" OnClick="BtnEnviar_Click" />
                        </center>
                    </div>--%>
                    
                </div>
                <div class="col-xs-10 col-xs-offset-1">
                    <div class="col-xs-4 col-xs-offset-4 col-md-offset-4  col-md-3  stabla" >
                        </br>
                        <asp:ImageButton Visible="false" ID="BtnCerrar" OnClick="BtnCerrar_Click" CssClass=" img-responsive" runat="server" ImageUrl="~/Image/clsssn.png"/>
                        </br>
                        </br>
                        </br>
                        </br>
                    </div>
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
