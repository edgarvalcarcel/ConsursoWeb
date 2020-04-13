<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDescargarRanking.aspx.cs" Inherits="ConsursoWeb.Admin.AdminDescargarRanking" %>

<%@ Register Src="~/ControlesUsuario/MenuAdmin.ascx" TagPrefix="uc1" TagName="MenuAdmin" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
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
                .ImgCerrar {
            max-width:100%;height:70px;
            padding-left:1%;
            padding-right:0;
            display:table-cell;
            float:none;

        }
        .nombre {
            font-family:'Century Gothic';
            color: #ee474a;
            font-weight: 400;
            text-align:left;
            font-size:35px;
            padding-bottom:2%;

            
        }
        .titulos {
            font-family:'Century Gothic';
            color: #ee474a;
            font-weight: 200;
            text-align:center;
            font-size:20px;
            padding-bottom:2%;
            
            
        }
        .contenido {
            background-color: #e5e6e7;
            color:whitesmoke;
            padding-left:5%;
            padding-top:3%;
            padding-bottom:3%;
            font-family:'Century Gothic';
        }
       
        .combosFecha {
            color:white;
            background-color: #ee474a;
            font-family:'Century Gothic';
        }
        
        .botones {
            background:#91c8c8;
            color:whitesmoke;
            border-radius:50px;
            height:35px;
            font-size:28px;
            width:70%;
            border:0px solid #ee474a;
            text-align:center;
            font-family:'Century Gothic';
        }
        
        input[disabled="disabled"] {
            background:#ee474a;
            opacity: 0.7;
        }
        
    </style>
</head>
<body style="background-image: url(../Image/20-BG.png)">
    
    <form id="form1" runat="server">
        <div class="container ">
            <div class="row">
                <uc1:MenuAdmin runat="server" ID="MenuAdmin" />
            </div>
            <br />
            <div class="row col-md-10 col-md-offset-1 nombre" style="padding-top:5%">
                DESCARGAR RANKING
            </div>
            <div class="row contenido col-md-10 col-md-offset-1" style="padding-top:5%">
                <div class="col-md-4 col-md-offset-2">
                    <center>
                    <asp:Label ID="LblConcurso" CssClass="titulos" runat="server" Text="Seleccione Un Concurso"></asp:Label><br />
                    <asp:DropDownList ID="DDLConcurso" CssClass="combosFecha" runat="server" AppendDataBoundItems="True" 
                    DataTextField="Titulo" DataValueField="Id" 
                    OnSelectedIndexChanged="DDLConcurso_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList><br />
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                    <asp:Label ID="LblCampaña" CssClass="titulos" runat="server" Text="Seleccione Una Campaña"></asp:Label><br />
                    <asp:DropDownList ID="DDLCampaña" CssClass="combosFecha" runat="server" AppendDataBoundItems="True" 
                    DataTextField="Descripcion" DataValueField="Id" >
                    </asp:DropDownList><br />
                    </center>
                </div>
            
            <div class="row col-md-4 col-md-offset-4" style="padding-top:5%">
                <asp:Button ID="Descargar" CssClass="botones" runat="server" Text="Descargar" OnClick="Descargar_Click" />
            </div>
         </div>
            
        </div>
         <div class="row">
             <div class="col-xs-10 col-xs-offset-1">
                                <div class="col-xs-6 col-md-9"></div>
                                <div class="col-xs-6  col-md-3 ImgCerrar stabla" >
                                    <asp:ImageButton ID="BtnCerrar" OnClick="BtnCerrar_Click" CssClass="ImgCerrar" runat="server" ImageUrl="~/Image/clsssn.png"/>
                                </div>
                            </div>
                </div>
    </form>

    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
