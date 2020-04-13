<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCargarImgAvatar.aspx.cs" Inherits="ConsursoWeb.Admin.AdminCargarImgAvatar" %>

<%@ Register Src="~/ControlesUsuario/MenuAdmin.ascx" TagPrefix="uc1" TagName="MenuAdmin" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <link href="../Content/bootstrap.css"  rel="stylesheet"/>
    
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
            font-family:'Century Gothic';
            padding-left:5%;
            padding-top:3%;
            padding-bottom:3%;
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
            width:40%;
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
        <div class="container">
        <div class="row">
            <uc1:MenuAdmin runat="server" ID="MenuAdmin" />
        </div>
        <div class="row">
           <div class="col-xs-10 col-xs-offset-1 nombre" style="padding-top:5%">
                    CARGAR IMAGEN AVATAR
                </div>
                <div class="col-xs-10 col-xs-offset-1 contenido">
            
                <center>
                <asp:Label ID="LblCargarImg" CssClass="titulos" runat="server" Text="Seleccionar Concurso"></asp:Label><br />
            
                <asp:DropDownList ID="DDLConcurso" CssClass="combosFecha" runat="server" AppendDataBoundItems="True" DataTextField="Titulo" DataValueField="Id" OnSelectedIndexChanged="DDLConcurso_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <asp:Image ID="ImageAplicacion" runat="server" Width="20%" Height="20%" CssClass="img-responsive"/>
                <br />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Cargar" runat="server" Text="Guardar Nueva Imagen" OnClick="Cargar_Click" />

                </center>
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
        </div>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    </form>

    
    </body>
</html>
