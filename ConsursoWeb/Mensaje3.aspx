<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mensaje3.aspx.cs" Inherits="ConsursoWeb.Mensaje3" %>

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
        .red {
            background-color:#ee474a;
            color:whitesmoke;
            font-size:10px;
            border-radius:30px 0px;
            font-family:'Century Gothic';
                        
        }
        
        ::-webkit-input-placeholder { color: whitesmoke; } /* WebKit */
        :-moz-placeholder { color: whitesmoke; } /* Firefox 18- */
        ::-moz-placeholder { color: whitesmoke; } /* Firefox 19+ */
        :-ms-input-placeholder { color: whitesmoke; } 

        .quiPadd {
            padding-left:0px !important;
            padding-right:0px !important;
        }
        .imgClose {
            width: 50%
        }
        .imgCont{
            width: 60%
        }
        .imgMensaje {
            width:80%
        }
        .bordes {
                background-color: transparent;
                padding-top: 100%;
                opacity: 0.2
            }
        
        .bordes3 {
                    background-color: transparent;
                    opacity: 0.2;
                    padding-top: 11%
             }
        .btnInicio {
            background:#91c8c8;
            color:whitesmoke;
            border-radius:50px;
            width:100%;
            height:20px;
            font-size:12px;
            border:0px solid #ee474a;
            text-align:center;
            vertical-align:middle;
        }
        .imgMini {

                padding-left: 6%;
                height:43px;
                padding-top: 2%

                }
        @media screen and (min-width: 400px) {
            .btnInicio {
            background:#91c8c8;
            color:whitesmoke;
            border-radius:50px;
            width:100%;
            height:30px;
            font-size:16px;
            border:0px solid #ee474a;
            text-align:center;
            
        }
            .red {
                background-color: #ee474a;
                color: whitesmoke;
                font-size: 13px;
                border-radius: 30px 0px;
                font-family:'Century Gothic';
            }
        }
        @media screen and (min-width: 768px) {

                .red {
                    background-color:#ee474a;
                    color:whitesmoke;
                    font-size:25px;
                    border-radius:30px 0px;
                    font-family:'Century Gothic';
                        
                }
                .imgCont{
                    width: 40%
                }
                .btnInicio {
                    background:#91c8c8;
                    color:whitesmoke;
                    border-radius:50px;
                    width:85%;
                    height:50px;
                    font-size:21px;
                    border:0px solid #ee474a;
                    text-align:center;
            
                }    
                .bordes {
                    background-color: #93cbca;
                    padding-top: 124%;
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
                .imgMini {

                padding-left: 6% !important;
                height:68px !important;
                padding-top: 3% !important;

                }
}

@media screen and (min-width: 870px) {

            .bordes {
                background-color: #93cbca;
                padding-top: 120%;
                opacity: 0.2
            }
            
}
@media screen and (min-width: 992px) {
            
            .red {
                background-color:#ee474a;
                color:whitesmoke;
                font-size:21px;
                border-radius:30px 0px;
                font-family:'Century Gothic';
                        
            }
            .bordes {
                background-color: #93cbca;
                padding-top: 93%;
                opacity: 0.2
            }
            .bordes3 {
                    background-color: #93cbca;
                    opacity: 0.2;
                    padding-top: 10.7%
                }
            .imgMini {

                padding-left: 6% !important;
                max-width:88% !important;
                padding-top: 3% !important;

                }
}
        @media screen and (min-width: 1101px) {

            .bordes {
                background-color: #93cbca;
                padding-top: 90%;
                opacity: 0.2
            }
            .imgMini {
                padding-left: 8%;
                max-width: 84%;
                padding-top: 4%


                }
        }

    </style>
</head>
<body style="background-image: url(../Image/20-BG.png);" >
    <form id="form1" runat="server">
        <div class="row" >

            <div class="row quiPadd" >
                <div class="col-xs-10 col-md-6 col-md-offset-1 quiPadd">
                    <div class="col-xs-8 col-xs-offset-2 quiPadd" style="padding-bottom:5%">
                        <center>
                            <div style="width:85%; text-align:center">
                                    <asp:Image ID="Image1" runat="server" CssClass="img-responsive"/>
                            </div>
                        </center>    
                    </div>
                    <center>
                    <div class="col-xs-10 col-xs-offset-1 quiPadd" >
                       <asp:ImageButton CssClass="img-responsive" ID="Image3" ImageUrl="~/Image/pop-up-2.png" OnClick="Button1_Click" runat="server"></asp:ImageButton>
                    </div>
                    </center>
                    
                </div>
            </div>
<div class="row quiPadd">
            <div class="col-xs-12 quiPadd footer" style="background-color:black; height:100px;position: fixed;bottom: 0;">
                
                <footer class="footer">
                    <div class="col-xs-6 col-md-6" style="padding:4px 90px">
                        <asp:ImageButton ID="ImageButton2" ImageUrl="~/Image/icono_TCDL.png" CssClass="img-responsive" PostBackUrl="~/Paginas/Informacion.aspx" runat="server" />
                    </div>

                    <div class="col-xs-6 col-md-6" style="padding:19px 90px">
                        <asp:ImageButton ID="ImageButton1" ImageUrl="~/Image/icono_MP.png" CssClass="img-responsive Image10"  PostBackUrl="http://www.marketingpersonal.com/" runat="server" />
                    </div>

                    <%--<asp:Image runat="server" ID="imgFooter" ImageUrl="~/Image/footer-login.png" CssClass="img-responsive" />--%>
                </footer>

            </div>
        </div>
        </div>

        <script src="Scripts/bootstrap.min.js"></script>
        <script src="Scripts/jquery-1.9.1.min.js"></script>

    </form>

</body>
</html>
