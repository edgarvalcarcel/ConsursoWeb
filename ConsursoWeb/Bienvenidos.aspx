<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenidos.aspx.cs" Inherits="ConsursoWeb.Bienvenidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style>
        @font-face {
            font-family:"QueenOfCamelot";
            src: url("fonts/queen_of_camelot-webfont.eot"); 
            src: url("fonts/queen_of_camelot-webfont.eot?#amocristalab") format("embedded-opentype"), 
                 url("fonts/queen_of_camelot-webfont.woff") format("woff"), 
                 url("fonts/queen_of_camelot-webfont.ttf") format("truetype"), 
                 url("fonts/queen_of_camelot-webfont.svg#queen_of_camelotregular") format("svg");
        }
           .TopLogo {
            position:fixed;
            top:100px
        }
        .normalize-row {
            margin-right: 0px !important;
            margin-left: 0px !important;
        }

        .imgBienvenidos {
           /* width:80%;
            padding-top:10%;
            padding-bottom:12%;*/
           max-width: 50%;
        }
        .image10 {
            float:right;
        }
        .stabla {
            padding-left:0px !important;
            padding-right:0px !important;
        }
        .txtBienvenido {
            font-family:'Century Gothic';
            color: #ee474a;
            font-weight: 500;
            font-size:34px;
        }
        .progress-bar-danger {
            background-color: #ee474a;
            }
        /*.TopLogo {
            width:300px
        }*/
        @media screen and (min-width: 600px) {
            .imgBienvenidos {
           /* width:80%;
            padding-top:10%;
            padding-bottom:12%;*/
           max-width: 100%;
        }
        }
@media screen and (min-width: 992px) {
        .TopLogo {
            position:fixed;
            top:100px
        }
        .TopBienv {
        position:fixed;
            top:300px
        }
                                .TopBarr {
        position:fixed;
            top:450px
        }
        .imgBienvenidos {
           /* width:80%;
            padding-top:10%;
            padding-bottom:12%;*/
           max-width: 80%;
        }
}
        @media screen and (min-width: 1051px) {
            .TopLogo {
            position:fixed;
            top:100px
        }
            .TopBienv {
        position:fixed;
            top:370px
        }
                                    .TopBarr {
        position:fixed;
            top:450px
        }
        .imgBienvenidos {
           /* width:80%;
            padding-top:10%;
            padding-bottom:12%;*/
           max-width: 70%;
        }
        }
        @media screen and (min-width: 1151px) {
            .TopLogo {
            position:fixed;
            top:100px
        }
            .TopBienv {
        position:fixed;
            top:370px
        }
                                    .TopBarr {
        position:fixed;
            top:450px
        }
                                    .imgBienvenidos {
           /* width:80%;
            padding-top:10%;
            padding-bottom:12%;*/
           max-width: 70%;
        }
        }
        @media screen and (min-width: 1251px) {
            .TopLogo {
            position:fixed;
            top:100px;
            
        }
            .TopBienv {
        position:fixed;
            top:400px
        }
                        .TopBarr {
        position:fixed;
            top:450px
        }
                        .imgBienvenidos {
           /* width:80%;
            padding-top:10%;
            padding-bottom:12%;*/
           max-width: 70%;
        }
        }
    </style>
</head>
<body style="background-image: url( Image/20-BG.png);" >
      
    <form id="form1" runat="server">  
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Enabled="true" Interval="3000" OnTick="Timer1_Tick">
                </asp:Timer>
        <div class="row normalize-row">
            <div class="col-md-12  col-xs-12 stabla">
                <div class="col-md-12  col-xs-12 stabla">
                    <center>
                        <asp:Image ID="Image1" CssClass="img-responsive " ImageUrl="~/Image/22.png" runat="server" />
                    </center>
                </div>
                <div class="col-sm-6 col-sm-offset-3 col-md-4 col-md-offset-4 col-xs-12 TopLogo">
                    <center>
                        <asp:Image ID="ImgBienvenidos" CssClass="img-responsive imgBienvenidos" ImageUrl="~/Image/2.png" runat="server" />
                        <div  class="col-md-8 col-md-offset-2 txtBienvenido">
                                BIENVENIDO
                        </div>
                        <div class="progress progress-striped col-md-10 col-md-offset-1 col-xs-12" style="border:1px solid lightgray; border-radius:10px; ">
                      <div class="progress-bar progress-bar-danger" role="progressbar"
                           aria-valuenow="80" aria-valuemin="0" aria-valuemax="100"
                           style="width: 80%;">
                        <span class="sr-only">80% completado (peligro / error)</span>
                      </div>
                    </div>
                    </center>
                </div>
                <div class="TopBienv ">
                    <center>
                            
                    </center>
                </div>
                <div class=" col-md-4 col-md-offset-4 col-xs-10 col-xs-offset-1 TopBarr">
                    
                </div>
                       <div class="row normalize-row  quiPadd">
            <div class="col-xs-12 quiPadd" style="background-color:black; height:140px; bottom:0; position:fixed">
                <footer>
                    <div class="col-xs-3 col-xs-offset-1" style="padding-top:30px">
                        <asp:ImageButton ID="ImageButton2" CssClass="img-responsive"  ImageUrl="~/Image/icono_TCDL.png" runat="server" />
                    </div>
                    <div class="col-xs-3 col-xs-offset-4" style="padding-top:45px">
                        <asp:ImageButton ID="ImageButton1" CssClass="img-responsive image10"  ImageUrl="~/Image/icono_MP.png" PostBackUrl="http://www.marketingpersonal.com/" runat="server" />
                    </div>
                    <%--<asp:Image runat="server" ID="imgFooter" ImageUrl="~/Image/footer-login.png" CssClass="img-responsive" />--%>
                </footer>
            </div>
        </div>
            </div>
        </div>
    </form>

    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
