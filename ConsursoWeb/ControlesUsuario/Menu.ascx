<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="ConsursoWeb.ControlesUsuario.Menu" %>

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
            
            border-radius:17px;
            -moz-border-radius: 17px;
            -webkit-border-radius: 17px;
            font-family:'Century Gothic';
            background-color: #2a292a;
        }
        .navbar-toggle {
            float:left;
            margin-left:0px;
            padding-left:0px;
            text-align:left;
            align-items:initial;
            font-family:'Century Gothic';
        }
        .navbar-default .navbar-toggle {
            border-color:transparent;
        }
        .navbar-default {
    background-color: transparent;
    border-color: transparent;
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
            border-bottom: 3px solid red;
            background-color: #2a292a;
            border-radius:17px;
            -moz-border-radius: 17px;
            -webkit-border-radius: 17px;
            font-family:'Century Gothic';
        }
/* Mobile version */
.navbar-default .navbar-toggle {
    background-color: #2a292a;
    padding-left: 3%;
    font-family:'Century Gothic';
}
.navbar-default .navbar-toggle:hover,
.navbar-default .navbar-toggle:focus {
    background-color: #2a292a;
    font-family:'Century Gothic';
}
.navbar-default .navbar-toggle .icon-bar {
    background-color: #CCC;
    font-family:'Century Gothic';
}

.bordes1 {

            background-color:#93cbca;height:50px;opacity:0.2
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
    .bordes1 {
            background-color:transparent;opacity:0.2
            
        }
}
    </style>

</head>
<body>
    <div class="row">
        <div class="row">
    <div class="container col-sm-10 col-sm-offset-1 col-xs-12 hidden-xs">
        <div class="row " style="padding-top:1%">
                <ul class="nav nav-pills nav-justified">
                        <li role="presentation" data-toggle="tooltip" title="Informate" class="active "><a href="../Paginas/Informacion.aspx"><span style="font-size:17px">INFORMACIÓN</span></a></li>                     
                        <li role="presentation" data-toggle="tooltip" title="Conoce tu posición en Tu casa de lujo MP" class="active "><a href="../Paginas/TopCinco.aspx"><span style="font-size:17px">TOP CINCO</span></a></li>
                        <li role="presentation" data-toggle="tooltip" title="Revisa tu perfil, crecimiento y metas" class="active "><a href="../Paginas/PerfilRanking.aspx"><span style="font-size:17px">PERFIL Y POSICIÓN</span></a></li>
                        <li role="presentation" data-toggle="tooltip" title="Conoce el premio de Tu casa de lujo MP" class="active "><a href="../Paginas/Premio.aspx"><span style="font-size:17px">PREMIO</span></a></li>
                        <li role="presentation" data-toggle="tooltip" title="¿Necesitas ayuda?" class="active "><a href="../Paginas/PagContacto.aspx"><span style="font-size:17px">CONTÁCTANOS</span></a></li>

                     
                </ul>
       
        </div>
    </div>
    </div>
    <div class="container visible-xs-block " >
        <center>
        <div style="width:90%;padding-top:2%">
            
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
                       <li role="presentation" data-toggle="tooltip" title="Informate" class="active "><a href="../Paginas/Informacion.aspx">INFORMACIÓN</a></li>
                    <li role="presentation" data-toggle="tooltip" title="Conoce tu posición en Tu casa de lujo MP" class="active "><a href="../Paginas/TopCinco.aspx">TOP CINCO</a></li>
                        <li role="presentation" data-toggle="tooltip" title="Revisa tu perfil, crecimiento y metas" class="active "><a href="../Paginas/PerfilRanking.aspx">PERFIL Y POSICIÓN</a></li>
                        <li role="presentation" data-toggle="tooltip" title="Conoce el premio de Tu casa de lujo MP" class="active "><a href="../Paginas/Premio.aspx">PREMIO</a></li>
                        <li role="presentation" data-toggle="tooltip" title="¿Necesitas ayuda?" class="active "><a href="../Paginas/PagContacto.aspx">CONTÁCTANOS</a></li>
                     
                     
                </ul>

            </div>
        </nav>
         
          </div>
            </center>
    </div>
    </div>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-1.9.1.min.js"> </script>
    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip;   
});
</script>

</body>
</html>
