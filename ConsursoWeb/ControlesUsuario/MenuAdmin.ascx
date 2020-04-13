<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuAdmin.ascx.cs" Inherits="ConsursoWeb.ControlesUsuario.MenuAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <style>
        @font-face {
            font-family:"QueenOfCamelot";
            src: url("../fonts/queen_of_camelot-webfont.eot"); 
            src: url("../fonts/queen_of_camelot-webfont.eot?#amocristalab") format("embedded-opentype"), 
                 url("../fonts/queen_of_camelot-webfont.woff") format("woff"), 
                 url("../fonts/queen_of_camelot-webfont.ttf") format("truetype"), 
                 url("../fonts/queen_of_camelot-webfont.svg#queen_of_camelotregular") format("svg");
        }
        .navbar-header {
            font-family:'Century Gothic';
            border-radius:17px;
            background-color:#ee474a;
        }
        .navbar-toggle {
            float:left;
            margin-left:0px;
            padding-left:0px;
            text-align:left;
            font-family:'Century Gothic';
            align-items:initial;
        }
        .navbar-default {
    background-color: transparent;
    border-color: #E7E7E7;
    font-family:'Century Gothic';
}
/* Title */
/*.navbar-default .navbar-brand {
    color: red;
}*/
.navbar-default .navbar-brand:hover,
.navbar-default .navbar-brand:focus {
    color: #5E5E5E;
    font-family:'Century Gothic';
}
/* Link */
.navbar-default .navbar-nav > li > a {
    color: #ee474a;
    font-family:'Century Gothic';
}
.navbar-default .navbar-nav > li > a:hover,
.navbar-default .navbar-nav > li > a:focus {
    color: #333;
    font-family:'Century Gothic';
}
.navbar-default .navbar-nav > .active > a,
.navbar-default .navbar-nav > .active > a:hover,
.navbar-default .navbar-nav > .active > a:focus {
    color: #ee474a;
    background-color: #ee474a;
    font-family:'Century Gothic';
}
.navbar-default .navbar-nav > .open > a,
.navbar-default .navbar-nav > .open > a:hover,
.navbar-default .navbar-nav > .open > a:focus {
    color: #555;
    background-color: #D5D5D5;
    font-family:'Century Gothic';
}
/* Caret */
.navbar-default .navbar-nav > .dropdown > a .caret {
    border-top-color: #777;
    border-bottom-color: #777;
    font-family:'Century Gothic';
}
.navbar-default .navbar-nav > .dropdown > a:hover .caret,
.navbar-default .navbar-nav > .dropdown > a:focus .caret {
    border-top-color: #333;
    border-bottom-color: #333;
    font-family:'Century Gothic';
}
.navbar-default .navbar-nav > .open > a .caret,
.navbar-default .navbar-nav > .open > a:hover .caret,
.navbar-default .navbar-nav > .open > a:focus .caret {
    border-top-color: #555;
    border-bottom-color: #555;
    font-family:'Century Gothic';
}
        .nav-pills > li.active > a, .nav-pills > li.active > a:hover, .nav-pills > li.active > a:focus {
            color: #fff;
            background-color: #ee474a;
            border-radius:17px;
            font-family:'Century Gothic';
            height:55px;
        }
/* Mobile version */
.navbar-default .navbar-toggle {
    border-color: #ee474a;
    font-family:'Century Gothic';
}
.navbar-default .navbar-toggle:hover,
.navbar-default .navbar-toggle:focus {
    background-color: #ee474a;
    font-family:'Century Gothic';
}
.navbar-default .navbar-toggle .icon-bar {
    background-color: #CCC;
    font-family:'Century Gothic';
}

@media (max-width: 767px) {
    .navbar-default .navbar-nav .open .dropdown-menu > li > a {
        color: #ee474a;
        font-family:'Century Gothic';
    }
    .navbar-default .navbar-nav .open .dropdown-menu > li > a:hover,
    .navbar-default .navbar-nav .open .dropdown-menu > li > a:focus {
          color: #ee474a;
          font-family:'Century Gothic';
    }

}
    </style>

</head>
<body>

    <div class="container col-md-10 col-md-offset-1 col-sm-10 col-xs-10 hidden-xs">
        <div class="row ">
            <ul class="nav nav-pills nav-justified">
                <li role="presentation" class="active "><a href="../Admin/AdminConcurso.aspx">Concursos</a></li>
                <li role="presentation" class="active "><a href="../Admin/AdminCampana.aspx">Campaña</a></li>
                <li role="presentation" class="active "><a href="../Admin/AdminUsuario.aspx">Usuario</a></li>
                <li role="presentation" class="active "><a href="../Admin/CargarImgAplicacion.aspx">Imagen Aplicacion</a></li>
                <li role="presentation" class="active "><a href="../Admin/AdminCargarImgAvatar.aspx">Imagen Avatar</a></li>
                <li role="presentation" class="active "><a href="../Admin/AdminCargaImgMovil.aspx">Imagen Premio</a></li>
                <li role="presentation" class="active "><a href="../Admin/AdminCargaImgWeb.aspx">Imagen Web</a></li>
                <li role="presentation" class="active "><a href="../Admin/AdminCierre.aspx">Cierre</a></li>
                <li role="presentation" class="active "><a href="../Admin/AdminDescargarRanking.aspx">Descargar Ranking</a></li>
                
            </ul>

        </div>
    </div>
    
    <div class="container visible-xs-block " >
        <nav class="navbar navbar-default" role="navigation">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse"
                    data-target=".navbar-ex1-collapse">
                    <span class="sr-only">Desplegar navegación</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                
            </div>
            <div class="row collapse navbar-collapse navbar-ex1-collapse">
                <ul class="nav nav-pills nav-stacked ">
                    <li role="presentation" class="active "><a href="../Admin/AdminConcurso.aspx">Concursos</a></li>
                    <li role="presentation" class="active "><a href="../Admin/AdminCampana.aspx">Campaña</a></li>
                    <li role="presentation" class="active "><a href="../Admin/AdminUsuario.aspx">Usuario</a></li>
                    <li role="presentation" class="active "><a href="../Admin/CargarImgAplicacion.aspx">Imagen Aplicacion</a></li>
                    <li role="presentation" class="active "><a href="../Admin/AdminCargarImgAvatar.aspx">Imagen Avatar</a></li>
                    <li role="presentation" class="active "><a href="../Admin/AdminCargaImgMovil.aspx">Imagen Premio</a></li>
                    <li role="presentation" class="active "><a href="../Admin/AdminCargaImgWeb.aspx">Imagen Web</a></li>
                    <li role="presentation" class="active "><a href="../Admin/AdminCierre.aspx">Cierre</a></li>
                    <li role="presentation" class="active "><a href="../Admin/AdminDescargarRanking.aspx">Descargar Ranking</a></li>
                    
                </ul>

            </div>
        </nav>
    </div>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"> </script>
</body>
</html>
