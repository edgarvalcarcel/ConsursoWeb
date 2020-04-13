<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCampana.aspx.cs" Inherits="ConsursoWeb.Admin.AdminCampana" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<%@ Register Src="~/ControlesUsuario/MenuAdmin.ascx" TagPrefix="uc1" TagName="MenuAdmin" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container">
            <div class="row">
                <uc1:MenuAdmin runat="server" id="MenuAdmin" />
            </div>
            
            <div class="row" style="padding-top:5%">
                <h3>
                    <div class="col-md-8 nombre">
                        CREAR ACTUALIZAR CAMPAÑA
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="BtnNuevo" CssClass="botones" runat="server" Text="Nuevo" OnClick="BtnNuevo_Click" />
                        <asp:Button ID="BtnGuardar" CssClass="botones" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                    </div>
                </h3>
            </div>
            <div class="contenido col-md-10 col-md-offset-1">
                <asp:Label ID="LblConcurso" CssClass="titulos" runat="server" Text="Seleccione Un Concurso"></asp:Label><br />
                <asp:DropDownList ID="DDLConcurso" CssClass="combosFecha" runat="server" AppendDataBoundItems="True" DataTextField="Titulo" DataValueField="Id" OnSelectedIndexChanged="DDLConcurso_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList><br />
                <asp:Label ID="LblId" CssClass="titulos" runat="server" Text="Id"></asp:Label><br />
                <asp:TextBox ID="TxtId" CssClass="combosFecha" runat="server" Enabled="false"></asp:TextBox><br />
                <asp:Label ID="LblDescripcion" CssClass="titulos" runat="server" Text="Descripcion"></asp:Label><br />
                <asp:TextBox ID="TxtDescripcion" CssClass="texto combosFecha" runat="server" Enabled="false"></asp:TextBox><br />
                <asp:Label ID="LblPorcentajeCrecimiento" CssClass="titulos" runat="server" Text="Porcentaje Crecimiento"></asp:Label><br />
                <asp:TextBox ID="TxtPorcentajeCrecimiento" CssClass="combosFecha" runat="server" Enabled="false"></asp:TextBox><br />
                <asp:Label ID="LblEstado" CssClass="titulos" runat="server" Text="Estado"></asp:Label><br />
                <asp:DropDownList ID="DdlEstado" CssClass="combosFecha" runat="server" Enabled="false">
                    <asp:ListItem Value="Seleccione">Seleccione</asp:ListItem>
                    <asp:ListItem Value="Abierta">Abierta</asp:ListItem>
                    <asp:ListItem Value="Cerrada">Cerrada</asp:ListItem>
                    <asp:ListItem Value="Sin Iniciar">Sin Iniciar</asp:ListItem>
                </asp:DropDownList><br />
                <asp:Label ID="LblFechaInicio" CssClass="titulos" runat="server" Text="Fecha Inicio"></asp:Label><br />
                <asp:TextBox ID="TxtFechaInicio" CssClass="combosFecha" runat="server"  Enabled="false"  ></asp:TextBox><br />
                <ajaxToolkit:CalendarExtender CssClass="combosFecha" ID="CdEInicio" runat="server" TargetControlID="TxtFechaInicio" Format="dd/MM/yyyy HH:mm:ss" />
                
                <asp:Label ID="LblFechaFin" CssClass="titulos" runat="server" Text="Fecha Fin"></asp:Label><br />
                <asp:TextBox ID="TxtFechaFin" CssClass="combosFecha" runat="server" Enabled="false" ></asp:TextBox><br />
                <ajaxToolkit:CalendarExtender CssClass="combosFecha" ID="CdEFin" runat="server" TargetControlID="TxtFechaFin" Format="dd/MM/yyyy HH:mm:ss"/>
                
            </div><br /><br />
            <div class="row" style="padding-top:5%">
                <br />
                <br />
                <center>
                <div class="col-md-10 col-md-offset-1" style="padding-top:5%">
                    <asp:GridView ID="GVCampana" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="ObjectDataSource1" OnRowCommand="GVCampana_RowCommand"
                        CssClass="table table-responsive dtabla">
                        <Columns>
                            <asp:BoundField DataField="Id"  HeaderText="Id" SortExpression="Id" >
                            <HeaderStyle CssClass="tiTabla" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" >
                            <HeaderStyle CssClass="tiTabla" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PorcentajeCrecimiento" HeaderText="PorcentajeCrecimiento" SortExpression="PorcentajeCrecimiento" >
                            <HeaderStyle CssClass="tiTabla" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" >
                            <HeaderStyle CssClass="tiTabla" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Inicio" HeaderText="Inicio" SortExpression="Inicio" >
                            <HeaderStyle CssClass="tiTabla" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Fin" HeaderText="Fin" SortExpression="Fin" >
                            <HeaderStyle CssClass="tiTabla" />
                            </asp:BoundField>
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Editar" Text="Editar" >
                            <HeaderStyle CssClass="tiTabla" />
                            </asp:ButtonField>
                        </Columns>
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ConsultarCampañasConcurso" TypeName="AccesoDatos.CampañaDatos">
                        <SelectParameters>
                            <asp:Parameter Name="idConcurso" Type="Int64" />
                            <asp:Parameter Name="conexion" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
                    </center>
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
    </form>

    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
