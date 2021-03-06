﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUsuario.aspx.cs" Inherits="ConsursoWeb.Admin.AdminUsuario" %>

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
        .texto {
            width:70%;
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
        .dtabla {
            padding-top:5%;
            background-color: #e5e6e7;
            border:2px solid black;
        }
        input[disabled="disabled"] {
            background:#ee474a;
            opacity: 0.7;
        }
        .tiTabla {
            background:#ee474a;
            color:whitesmoke;
            font-family:'Century Gothic';
        }
    </style>
</head>
<body style="background-image: url(../Image/20-BG.png)">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <uc1:MenuAdmin runat="server" ID="MenuAdmin" />
            </div>

            <h3>
            <div class="row" style="padding-top:5%">
                <div class="col-md-8 nombre">
                CREAR ACTUALIZAR USUARIO
                </div>
                <div class="col-md-4">
                    <asp:Button ID="BtnNuevo" CssClass="botones" runat="server" Text="Nuevo" OnClick="BtnNuevo_Click" />
                    <asp:Button ID="BtnGuardar" CssClass="botones" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                </div>
            </div>
        </h3>
        <div class="contenido col-md-10 col-md-offset-1">
            <asp:Label ID="LblId" CssClass="titulos" runat="server" Text="ID"></asp:Label><br />
            <asp:TextBox ID="TxtId" CssClass="combosFecha" runat="server" Enabled="false"></asp:TextBox><br />
            <asp:Label ID="LblNombreCompleto" CssClass="titulos" runat="server" Text="Nombre Completo"></asp:Label><br />
            <asp:TextBox ID="TxtNombreCompleto" CssClass="combosFecha  texto" runat="server" Enabled="false"></asp:TextBox><br />
            <asp:Label ID="LblIdentificacion" CssClass="titulos" runat="server" Text="Identificacion"></asp:Label><br />
            <asp:TextBox ID="TxtIdentificacion" CssClass="combosFecha" runat="server" Enabled="false"></asp:TextBox><br />
            <asp:Label ID="LblPassword" CssClass="titulos" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="TxtPassword" CssClass="combosFecha" runat="server" Enabled="false"></asp:TextBox><br />
            <asp:Label ID="LblPerfil" CssClass="titulos" runat="server" Text="Perfil"></asp:Label><br />
            <asp:DropDownList ID="DdlPerfil" CssClass="combosFecha" runat="server" Enabled="false">
                <asp:ListItem Value="Seleccione">Seleccione</asp:ListItem>
                <asp:ListItem Value="Admin">Administrador</asp:ListItem>
                <asp:ListItem Value="Gerente">Gerente</asp:ListItem>
            </asp:DropDownList><br />
            
        </div><br /><br />
        <div class="row col-md-10 col-md-offset-1" style="padding-top:5%">
            <center>
            <asp:GridView ID="GVUsuario" runat="server" 
                AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
                CssClass="table table-responsive dtabla" OnRowCommand="GVUsuario_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" >
                    <HeaderStyle CssClass="tiTabla" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" SortExpression="NombreCompleto" >
                    <HeaderStyle CssClass="tiTabla" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" SortExpression="Identificacion" >
                    <HeaderStyle CssClass="tiTabla" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" >
                    <HeaderStyle CssClass="tiTabla" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Perfil" HeaderText="Perfil" SortExpression="Perfil" >
                    <HeaderStyle CssClass="tiTabla" />
                    </asp:BoundField>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Editar" Text="Editar" >
                    <HeaderStyle CssClass="tiTabla" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ConsultarUsuariosEspeciale" TypeName="AccesoDatos.UsuarioDatos">
                <SelectParameters>
                    <asp:Parameter Name="conexion" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
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
    </form>

    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
