<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TopCinco.aspx.cs" Inherits="ConsursoWeb.Paginas.TopCinco" %>

<%@ Register Src="~/ControlesUsuario/Menu.ascx" TagPrefix="uc1" TagName="Menu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%-- <script src="https://cdn.onesignal.com/sdks/OneSignalSDK.js" async='async'></script>
  <script>
    var OneSignal = window.OneSignal || [];
    OneSignal.push(["init", {
        appId: "781b7399-2bf5-4496-9ca3-a770e7227053",
      autoRegister: false, /* Set to true to automatically prompt visitors */
      subdomainName: 'concursoweb',
      /*
      subdomainName: Use the value you entered in step 1.4: http://imgur.com/a/f6hqN
      */
      httpPermissionRequest: {
        enable: true
      },
      notifyButton: {
          enable: true /* Set to false to hide */
      }
    }]);
  </script>--%>
    <meta name="viewport" content="width=device-width, user-scalable=no" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        @font-face {
            font-family: "QueenOfCamelot";
            src: url("../fonts/queen_of_camelot-webfont.eot");
            src: url("../fonts/queen_of_camelot-webfont.eot?#amocristalab") format("embedded-opentype"), url("../fonts/queen_of_camelot-webfont.woff") format("woff"), url("../fonts/queen_of_camelot-webfont.ttf") format("truetype"), url("../fonts/queen_of_camelot-webfont.svg#queen_of_camelotregular") format("svg");
        }

        body {
            background-image: url(../Image/20-BG.png);
            font-family: 'Century Gothic';
        }

        .fonAz {
            background-color: #e23033;
            color: whitesmoke;
            /*border-radius:10px;*/
            font-family: 'Century Gothic';
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

        .fonAz0,
        .fonAz1 {
            padding: 5px;
        }

        .fonAz0 {
            background-color: #e23033;
            color: whitesmoke;
            border-radius: 15px 0px 0px 15px;
            -moz-border-radius: 15px 0px 0px 15px;
            -webkit-border-radius: 15px 0px 0px 15px;
            margin: 8px 0;
            box-sizing: border-box;
            border: none;
            border-bottom: 0px solid #ee474a;
            text-align: left;
            font-size: 12px;
            font-family: 'Century Gothic';
        }

        .fonAz1 {
            background-color: #e23033;
            color: whitesmoke;
            border-radius: 0px 15px 15px 0px;
            -moz-border-radius: 0px 15px 15px 0px;
            -webkit-border-radius: 0px 15px 15px 0px;
            margin: 8px 0;
            box-sizing: border-box;
            border: none;
            border-bottom: 0px solid #ee474a;
            text-align: center;
            font-size: 12px;
        }

        .nueva {
            z-index: 1;
            /*width: 60%;*/
            margin: 8px 0;
            box-sizing: border-box;
            border: none;
            border-bottom: 0px solid #ee474a;
            text-align: left;
            font-size: 12px;
            font-family: 'Century Gothic';
        }

        .nueva2 {
            z-index: 1;
            /*width: 40%;*/
            margin: 8px 0;
            box-sizing: border-box;
            border: none;
            border-bottom: 0px solid #ee474a;
            text-align: center;
            font-size: 12px;
            font-family: 'Century Gothic';
        }

        .top5 {
            font-size: 20px;
            text-align: center;
            font-family: 'Century Gothic';
        }

        .crecimiento {
            text-align: center;
            font-size: 8px;
            font-family: 'Century Gothic';
        }

        .red {
            background-color: #161415;
            color: whitesmoke;
            width: 90%;
            border:10px solid gray;
            border-radius: 20px;
            font-family: 'Century Gothic';
            margin-top: 16px;
        }

        @media only screen and (max-width : 480px){
            .red {
                width: 100%;
                margin: auto !important;
            }

        }

        td {
            padding: 3px;
        }

        .stabla {
            padding-left: 0px !important;
            padding-right: 0px !important;
        }
        .Contenedor {
            background-color:#e3e6e7;
            border-radius:15px;
            opacity:1;
            height: 100%; 
            padding-top:30px; 
            padding-bottom:100px;
        }
        /* Bootstrap point xs*/
        @media only screen and (max-width : 480px){
            .Contenedor {
                /*background-color: rgba(0, 191, 255, .8);*/
                background-color: rgba(227, 230, 231, 0.8);
                margin: 16px 10px;
            }
        }

        @media screen and (min-width:415px ) {
            .Contenedor {
                background-color:#e3e6e7;
                border-radius:15px;
                opacity:0.8;
                margin: auto 10px;
            }
            .nueva {
                z-index: 1;
                /*width: 60%;*/
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: left;
                font-size: 15px;
                font-family: 'Century Gothic';
            }

            .fonAz0 {
                background-color: #e23033;
                color: whitesmoke;
                border-radius: 15px 0px 0px 15px;
                -moz-border-radius: 15px 0px 0px 15px;
                -webkit-border-radius: 15px 0px 0px 15px;
                margin: 8px 0;
                padding-left: 15px;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: left;
                font-size: 15px;
                font-family: 'Century Gothic';
            }

            .fonAz1 {
                background-color: #e23033;
                color: whitesmoke;
                border-radius: 0px 15px 15px 0px;
                -moz-border-radius: 0px 15px 15px 0px;
                -webkit-border-radius: 0px 15px 15px 0px;
                margin: 8px 0;
                font-family: 'Century Gothic';
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: center;
                font-size: 15px;
            }

            .top5 {
                font-size: 30px;
                text-align: center;
                font-family: 'Century Gothic';
            }

            .crecimiento {
                text-align: center;
                font-size: 11px;
                font-family: 'Century Gothic';
            }

            .nueva2 {
                z-index: 1;
                /*width: 40%;*/
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: center;
                font-size: 15px;
                font-family: 'Century Gothic';
            }
        }
           .footerimage {
            max-width:80px !important;
        }
        .ImagPadd {
            padding:0px 0px !important;
        }
        @media screen and (min-width: 768px) {

             .Contenedor {
        background-color:transparent;border-radius:15px;opacity:1
        }
            .nueva2 {
                z-index: 1;
                /*width: 40%;*/
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: center;
                font-size: large;
                font-family: 'Century Gothic';
            }

            .nueva {
                z-index: 1;
                /*width: 60%;*/
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: left;
                font-size: large;
                font-family: 'Century Gothic';
            }

            .fonAz0 {
                background-color: #e23033;
                color: whitesmoke;
                border-radius: 15px 0px 0px 15px;
                -moz-border-radius: 15px 0px 0px 15px;
                -webkit-border-radius: 15px 0px 0px 15px;
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: left;
                font-size: large;
                font-family: 'Century Gothic';
            }

            .fonAz1 {
                background-color: #e23033;
                color: whitesmoke;
                border-radius: 0px 15px 15px 0px;
                -moz-border-radius: 0px 15px 15px 0px;
                -webkit-border-radius: 0px 15px 15px 0px;
                margin: 8px 0;
                font-family: 'Century Gothic';
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: center;
                font-size: large;
            }

            .crecimiento {
                text-align: center;
                font-size: 16px;
                font-family: 'Century Gothic';
            }
        }

        @media screen and (min-width: 940px) {
             .Contenedor {
        background-color:transparent;border-radius:15px;opacity:1
        }
            .nueva2 {
                z-index: 1;
                /*width: 40%;*/
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: center;
                font-size: 23px;
                font-family: 'Century Gothic';
            }

            .nueva {
                z-index: 1;
                /*width: 60%;*/
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: left;
                font-size: 23px;
                font-family: 'Century Gothic';
            }

            .fonAz0 {
                background-color: #e23033;
                color: white;
                font-family: 'Century Gothic';
                border-radius: 15px 0px 0px 15px;
                -moz-border-radius: 15px 0px 0px 15px;
                -webkit-border-radius: 15px 0px 0px 15px;
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: left;
                font-size: 23px;
            }

            .fonAz1 {
                background-color: #e23033;
                font-family: 'Century Gothic';
                color: white;
                border-radius: 0px 15px 15px 0px;
                -moz-border-radius: 0px 15px 15px 0px;
                -webkit-border-radius: 0px 15px 15px 0px;
                margin: 8px 0;
                box-sizing: border-box;
                border: none;
                border-bottom: 0px solid #ee474a;
                text-align: center;
                font-size: 23px;
            }

            .crecimiento {
                text-align: center;
                font-size: 19px;
                font-family: 'Century Gothic';
            }
        }

        .btn-logout {
            width: 100% !important;
        }

        .title-rojo {
            background: #e74737; /* Old browsers */
            background: -moz-linear-gradient(top, #e74737 0%, #c63134 100%); /* FF3.6-15 */
            background: -webkit-linear-gradient(top, #e74737 0%,#c63134 100%); /* Chrome10-25,Safari5.1-6 */
            background: linear-gradient(to bottom, #e74737 0%,#c63134 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#e74737', endColorstr='#c63134',GradientType=0 ); /* IE6-9 */
            border-radius: 10px;
            margin-top: 15px;
            text-align: center;
            padding: 5px;
            font-size: 14px;
            color: white;
        }

        .txt_title{
           background-color:black;
           border-radius:15px;
           color:white;
           text-align:center;
           height:40px;
           font-size:20px;
           padding-top:7px;
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
                        <div class="col-xs-12 txt_title">TOP 5</div>                                                       
                    </center>
                </div>
            </center>
        </div>

        <div class="col-xs-12">
            
            <div class="container Contenedor">

                <div class="row">
                    
                        <div class="col-xs-12 col-md-5">
                            <div class="" style="padding-top:20px;overflow: hidden;">
                                <div class="col-xs-12 stabla">
                                    <center>
                                    <asp:Image ID="Image1" CssClass="img-responsive " runat="server" ImageUrl="~/Image/banner.png" />
                                </center>
                                </div>
                            </div>

                            <h4 class="title-rojo">VISITA PERFIL Y POSICIÓN PARA CONOCER TUS METAS</h4>

                            <div class="row" style="margin-bottom: 16px;">
                                <div class="col-xs-12 stabla">
                                    <asp:Image ID="ImageWeb" CssClass="img-responsive " runat="server" Width="100%" Height="60%" />

                                </div>

                            </div>
                        </div>
                        
                        <div class="col-xs-12 col-md-7">
                            <div class="row red stabla" >
                                <div class="col-xs-12 stabla" style="text-align:center; padding-top:3%;padding-bottom:3%;    padding-left: 3% !important;padding-right: 3% !important" >
                                    <div class="col-xs-12 stabla">
                                        <div class="col-xs-7 stabla"> <asp:Image ID="Image2" ImageUrl="~/Image/cuadriculaTop5.png" CssClass="img-responsive " runat="server" /></div>
                                        <div  class="col-xs-5 stabla">  <asp:Image ID="Image3" ImageUrl="~/Image/cuadriculaCrecimiento.png" CssClass="img-responsive " runat="server" /></div>
                                    </div>
                                    <asp:GridView ID="GVTopCinco" ShowHeader="false" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" HorizontalAlign="Center" AllowPaging="True" PageSize="7" BorderStyle="None">
                                        <Columns>
                                             <asp:TemplateField  SortExpression="NombreUsuario" HeaderText="TOP 5" >
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Posicion") %>' Font-Bold="true"></asp:Label>
                                                    <asp:Label ID="Label3" runat="server" Text='.' Font-Bold="true"></asp:Label>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:Label>
                                                </ItemTemplate>
                                                
                                                <HeaderStyle BorderStyle="None" CssClass="col-xs-8 top5 stabla" />
                                                
                                                <ItemStyle CssClass="nueva col-xs-8 stabla"  HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="PorcentajeActual" HeaderText="% CRECIMIENTO" DataFormatString="{0:} %"  SortExpression="PorcentajeActual "  HtmlEncode="False" >
                                            
                                            <HeaderStyle BorderStyle="None" CssClass="col-xs-8 crecimiento stabla"/>
                                            
                                            <ItemStyle CssClass="nueva2 col-xs-4 stabla" HorizontalAlign="Center" Font-Bold="True"  Width="200px" />
                                            </asp:BoundField>
                                        </Columns>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <PagerSettings PageButtonCount="1" Visible="False" />
                                    </asp:GridView>

                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="TopCinco" TypeName="AccesoDatos.RankingDatos">
                                        <SelectParameters>
                                            <asp:Parameter Name="usu_identificacion" Type="Int64" />
                                            <asp:Parameter Name="conexion" Type="String" DefaultValue="Concurso"/>
                                        </SelectParameters>
                                    </asp:ObjectDataSource>

                                </div>
                                <%-- <div class="col-xs-10 col-xs-offset-1">
                                    <asp:Label runat="server" ID="lblTex">Haz clic </asp:Label><asp:LinkButton ID="lnkAqui" OnClick="lnkAqui_Click" runat="server" ForeColor="White"> aquí</asp:LinkButton><asp:Label runat="server" ID="Label4"> para conocer tus crecimientos</asp:Label>
                                </div>--%>
                            </div>
                    
                            <div class="row">

                            <div class="col-xs-10 col-xs-offset-1" style="text-align:center">
                                <div class="col-xs-8 col-xs-offset-2 col-md-offset-8  col-md-3 stabla"  style="padding:16px 0;">
                                    <asp:ImageButton ID="BtnCerrar" OnClick="BtnCerrar_Click" CssClass="img-responsive btn-logout" runat="server" ImageUrl="~/Image/clsssn.png"/>
                                </div>
                           </div>
                       </div>
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

    </form>


    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
