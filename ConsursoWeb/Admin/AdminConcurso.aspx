<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminConcurso.aspx.cs" Inherits="ConsursoWeb.Admin.AdminConcurso" %>

<%@ Register src="../ControlesUsuario/MenuAdmin.ascx" tagname="MenuAdmin" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.css" rel="stylesheet"/>
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
    <div class="container">
    <form id="form1" runat="server">
    <div class="row">
            <uc1:MenuAdmin ID="MenuAdmin" runat="server" />
            </div>
        <h3>
            <div class="row" style="padding-top:5%">
                <div class="col-md-8 nombre">
                CREAR ACTUALIZAR CONCURSO
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
            <asp:Label ID="LblTitulo" CssClass="titulos " runat="server" Text="Titulo"></asp:Label><br />
            <asp:TextBox ID="TxtTitulo" CssClass="combosFecha texto" runat="server" Enabled="false"></asp:TextBox><br />
            <asp:Label ID="LblDescripcionPremio" CssClass="titulos " runat="server" Text="Descripción Premio"></asp:Label><br />
            <asp:TextBox ID="TxtDescripcionPremio" CssClass="combosFecha texto" runat="server" Enabled="false"></asp:TextBox><br />
            <asp:Label ID="LblEstado" CssClass="titulos" runat="server" Text="Estado"></asp:Label><br />
            <asp:DropDownList CssClass="combosFecha" ID="DdlEstado" runat="server" Enabled="false">
                <asp:ListItem Value="Seleccione">Seleccione</asp:ListItem>
                <asp:ListItem Value="Sin Iniciar">Sin Iniciar</asp:ListItem>
                <asp:ListItem Value="Iniciado">Iniciado</asp:ListItem>
                <asp:ListItem Value="Terminado">Terminado</asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="LblNumeroCampanas" CssClass="titulos" runat="server" Text="Numero Campañas"></asp:Label><br />
            <asp:TextBox ID="TxtNumeroCampana" CssClass="combosFecha" runat="server" Enabled="false"></asp:TextBox><br />
            <asp:Label ID="LblTelefono" CssClass="titulos" runat="server" Text="Telefono"></asp:Label><br />
            <asp:TextBox ID="TxtTelefono" CssClass="combosFecha" runat="server" Enabled="false"></asp:TextBox><br />
            <asp:Label ID="LblMail" CssClass="titulos" runat="server" Text="Mail"></asp:Label><br />
            <asp:TextBox ID="TxtMail" CssClass="combosFecha texto" runat="server" Enabled="false"></asp:TextBox><br />
            
        </div><br /><br />
        <center>
        <div class="col-md-10 col-md-offset-1" style="padding-top:5%">

            <asp:GridView ID="GVConcurso" runat="server" style="padding-top:5%" 
                AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
                OnRowCommand="GVConcurso_RowCommand" CssClass="table table-responsive dtabla">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" >
                    <HeaderStyle CssClass="tiTabla " />
                    </asp:BoundField>
                    <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" >
                    <HeaderStyle CssClass="tiTabla " />
                    </asp:BoundField>
                    <asp:BoundField DataField="NumeroCampañas" HeaderText="NumeroCampañas" SortExpression="NumeroCampañas" >
                    <HeaderStyle CssClass="tiTabla " />
                    </asp:BoundField>
                    <asp:BoundField DataField="DescripcionPremio" HeaderText="DescripcionPremio" SortExpression="DescripcionPremio" >
                    <HeaderStyle CssClass="tiTabla " />
                    </asp:BoundField>
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" >
                    <HeaderStyle CssClass="tiTabla " />
                    </asp:BoundField>
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" >
                    <HeaderStyle CssClass="tiTabla " />
                    </asp:BoundField>
                    <asp:BoundField DataField="Mail" HeaderText="Mail" SortExpression="Mail" >
                    <HeaderStyle CssClass="tiTabla " />
                    </asp:BoundField>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Editar" Text="Editar" >
                    <HeaderStyle CssClass="tiTabla " />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ConsultarTodosConcursos" TypeName="AccesoDatos.ConcursoDatos">
                <SelectParameters>
                    <asp:Parameter Name="conexion" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
            </center>
         <div class="row">
             <div class="col-xs-10 col-xs-offset-1">
                                <div class="col-xs-6 col-md-9"></div>
                                <div class="col-xs-6  col-md-3 ImgCerrar stabla" >
                                    <asp:ImageButton ID="BtnCerrar" OnClick="BtnCerrar_Click" CssClass="ImgCerrar" runat="server" ImageUrl="~/Image/clsssn.png"/>
                                </div>
                            </div>
                </div>
    </form>
        </div>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
