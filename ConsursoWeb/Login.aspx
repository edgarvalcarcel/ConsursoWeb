<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ConsursoWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, user-scalable=no" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title></title>
    <style>
        .inpUsu {
            background-color: transparent;
            width: 90%;
            border: none;
            border-bottom: 0px solid transparent;
            text-align: left;
            height: 45px;
            vertical-align: middle;
        }
        .lnkterminos{
            color:white;
            vertical-align:middle;
            padding-top:3%;
            font-size:12px
        }
        .lnkterminos:hover{
            color:white;
            vertical-align:middle;
            padding-top:3%;
        }
        .image {
            float:right;
        }
        input::-webkit-input-placeholder {
            color: whitesmoke;
        }
        /* WebKit */
        input:-moz-placeholder {
            color: whitesmoke;
        }
        /* Firefox 18- */
        input::-moz-placeholder {
            color: whitesmoke;
        }
        /* Firefox 19+ */
        input:-ms-input-placeholder {
            color: whitesmoke;
        }

        input:focus::-webkit-input-placeholder {
            color: #ee474a;
        }
        /* WebKit */
        input:focus:-moz-placeholder {
            color: #ee474a;
        }
        /* Firefox 18- */
        input:focus::-moz-placeholder {
            color: #ee474a;
        }
        /* Firefox 19+ */
        input:focus:-ms-input-placeholder {
            color: #ee474a;
        }

        .quiPadd {
            padding-left: 0px !important;
            padding-right: 0px !important;
        }

        .recuerda {
            font-size:8px;
            color:#ee474a;
            font-family:'Century Gothic';
            font-weight:600;
            text-align:center;
        }
        .telefono {
            background: #ee474a;
            color: whitesmoke;
            border-radius: 50px;
            width: 85%;
            height: 45px;
            font-size: 16px;
            border: 0px solid #ee474a;
            text-align: center;
        }
        .condiciones{
            background: #060606;
            color: whitesmoke;
            border-radius: 50px;
            height: 45px;
            font-size: 16px;
            border: 0px solid #ee474a;
            text-align: center;
        }

        .btnInicio {
            background: #060606;
            color: whitesmoke;
            border-radius: 50px;
            width: 85%;
            height: 50px;
            font-size: 16px;
            border: 0px solid #ee474a;
            text-align: center;
        }

            .btnInicio:hover {
                background: #060606;
                color: whitesmoke;
                border-radius: 50px;
                width: 85%;
                height: 50px;
                font-size: 16px;
                border: 0px solid #ee474a;
                text-align: center;
            }

        .imgMini {
            padding-left: 6%;
            height: 43px;
            padding-top: 2%
        }
       
        .ocultar {
                display: block !important;
            }
        @media screen and (min-width: 768px) {
            .lnkterminos{
            color:white;
            vertical-align:middle;
            padding-top:3%;
            font-size:20px
        }
            .ocultar {
                display: none !important;
            }
        .lnkterminos:hover{
            color:white;
            vertical-align:middle;
            padding-top:3%;
        }
            .inpUsu {
                background-color: transparent;
                width: 90%;
                border: none;
                border-bottom: 0px solid transparent;
                text-align: left;
                height: 70px;
                vertical-align: middle;
            }

            .telefono {
                background: #ee474a;
                color: whitesmoke;
                border-radius: 50px;
                width: 85%;
                height: 70px;
                font-size: 21px;
                border: 0px solid #ee474a;
                text-align: center;
            }
            .condiciones{
            background: #060606;
            color: whitesmoke;
            border-radius: 50px;
            height: 70px;
            font-size: 16px;
            border: 0px solid #ee474a;
            text-align: center;
        }

            .btnInicio {
                background: #060606;
                color: whitesmoke;
                border-radius: 50px;
                width: 85%;
                height: 70px;
                font-size: 21px;
                border: 0px solid #ee474a;
                text-align: center;
            }

                .btnInicio:hover {
                    background: #060606;
                    color: whitesmoke;
                    border-radius: 50px;
                    width: 85%;
                    height: 70px;
                    font-size: 21px;
                    border: 0px solid #ee474a;
                    text-align: center;
                }

            .imgMini {
                padding-left: 6% !important;
                height: 68px !important;
                padding-top: 3% !important;
            }
        }

        @media screen and (min-width: 992px) {
            .lnkterminos{
            color:white;
            vertical-align:middle;
            padding-top:3%;
                        font-size:20px
        }
        .lnkterminos:hover{
            color:white;
            vertical-align:middle;
            padding-top:3%;
        }
            .imgMini {
                padding-left: 6% !important;
                max-width: 88% !important;
                padding-top: 3% !important;
            }
            .recuerda {
            font-size:12px;
            color:#ee474a;
            font-family:'Century Gothic';
            font-weight:600;
            text-align:center;
        }
        }

        @media screen and (min-width: 1101px) {
            .lnkterminos{
            color:white;
            vertical-align:middle;
            padding-top:3%;
            font-size:20px
        }
        .lnkterminos:hover{
            color:white;
            vertical-align:middle;
            padding-top:3%;
        }
            .imgMini {
                padding-left: 8%;
                max-width: 84%;
                padding-top: 4%
            }
        }
        
        .img_p{
            text-align: left;
            padding-top: 5%;
            padding-bottom: 5%;
        }

        .footImg{
            background-color:black;
            height:140px;
            position: fixed;
        }
        .img_foot_right{
            padding-top:37px;
        }
        .img_foot_left{
            padding-top:50px
        }
        .col-xs-12.quiPadd.dw {
            bottom: 0;
        }

        @media(max-width: 450px){
            .img_p{
                padding-top: 0%;
            }
            .img_foot_right{
                padding-top:17px;
            }
            .img_foot_left{
                padding-top:30px;
            }
            .footImg{
            height:100px;
            position: relative
        }
        }

    </style>
</head>
<body style="background-image: url(../Image/20-BG.png);">
    <form id="form1" runat="server">
        <div class="row quiPadd">

            <div class="col-xs-12 quiPadd">

                <div class="col-xs-10 col-xs-offset-1  col-md-5 col-md-offset-0  quiPadd">
                    <div class="col-xs-12  quiPadd img_p">
                        <center>
                            <div>
                                <div class="hidden-xs">
                                    <asp:Image ID="Image1" runat="server" CssClass="img-responsive"/>
                                    </div>
                                <div class="visible-xs-block " >
                                    <asp:Image ID="Image4" runat="server" ImageUrl="~/Image/MOVIL-HOME.png" CssClass="img-responsive"/>
                                    </div>
                            </div>
                        </center>
                    </div>
                </div>
                <div class="col-xs-10 col-xs-offset-1 col-md-6 col-md-offset-1 quiPadd">
                    <div class="col-xs-12 quiPadd" style="padding-top: 2%;">
                        <h4>
                            <center>
                                <div class="telefono quiPadd">
                                    <div class="col-xs-2 quiPadd">
                                        <asp:Image ID="ImgUsuario" runat="server" CssClass="img-responsive imgMini" ImageUrl="~/Image/4.png"/>
                                    </div>
                                    <div class="col-xs-10 quiPadd ">
                                        <input runat="server" class="inpUsu" id="UsuarioTxt" placeholder="USUARIO"/>
                                    </div>
                                </div>
                            </center>
                        </h4>
                    </div>
                    <div class="col-xs-12 quiPadd" style="padding-top: 2%;">
                        <h4>
                            <center>
                                 <div class="telefono quiPadd">
                                    <div class="col-xs-2 quiPadd">
                                        <asp:Image ID="Image3" runat="server" CssClass="img-responsive imgMini" ImageUrl="~/Image/5.png"/>
                                    </div>
                                    <div class="col-xs-10 quiPadd ">
                                        <input runat="server" class="inpUsu" id="ContraseñaTxt" type="password" placeholder="CONTRASEÑA"/>
                                    </div>
                                </div>
                            </center>

                        </h4>
                    </div>
                    <div class="col-xs-12 quiPadd" style="padding-top: 1%;">
                        <center>
                            <asp:Label runat="server" Font-Size="Small" CssClass="recuerda">Recuerda que tu usuario y contraseña son los mismos de la web de MP</asp:Label>
                        </center>
                    </div>
                    <div class="col-xs-12 quiPadd" style="padding-top: 1%;">
                        <h4>
                            <center>
                                 <div class="quiPadd">
                                    <asp:Button ID="Button1" CssClass="btn btnInicio" runat="server" Text="INICIAR SESIÓN" OnClick="Registrarse_Click"></asp:Button>
                                </div>
                            </center>
                        </h4>
                    </div>
                    <div class="col-xs-10 col-xs-offset-1 quiPadd container" style="padding-top: 2%;">
                         <center>
                                 <div class="condiciones quiPadd">
                                    <div class="col-xs-2 quiPadd">
                                        <asp:ImageButton ID="Image2" OnClick="Image2_Click" runat="server" CssClass="img-responsive imgMini" ImageUrl="~/Image/check_out.png"/>
                                    </div>
                                    <div class="col-xs-10 quiPadd" style="padding-top:4%;">
                                        <asp:LinkButton runat="server" CssClass="inpUsu lnkterminos" id="TerCon" data-toggle="modal" data-target="#myModal" Text="TÉRMINOS Y CONDICIONES" />
                                    </div>
                                </div>
                            
                            <asp:Label Font-Size="Small" runat="server" CssClass="recuerda">Debes leer y aceptar para continuar</asp:Label>
                        </center>
                        <center>
                            
                         <%--<asp:LinkButton runat="server" ID="lnkChecV" data-toggle="modal" data-target="#myModal">Términos y Condiciones</asp:LinkButton>--%>
                             
                         <br />
                         </center>
                        <div class="modal fade" style="width:97%" id="myModal" role="dialog">
                            <div class="modal-dialog">

                                <!-- Modal content-->
                                <div style="width:100%" class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                                        <h3 class="modal-title" style="font-weight: 700;">Términos y Condiciones</h3>
                                    </div>
                                    <div  class="modal-body">
                                        <asp:Panel ID="pane" runat="server"  Height="500px" ScrollBars="Vertical">
                                            <div style="font-weight: 600; text-align: justify">
                                                <h2>TÉRMINOS Y CONDICIONES </h2>
<h3>LA CASA CON LA QUE SIEMPRE SOÑASTE, MP LA HACE REALIDAD</h3>

<h3>TU CASA DE LUJO MP</h3>
<h3>EL CONCURSO CON EL QUE PODRÁS GANARTE UNA REMODELACIÓN DE TU CASA HASTA POR CINCUENTA MILLONES DE PESOS COLOMBIANOS ($ 50.000.000)
GANAR ES MUY FÁCIL</h3>

<p>Para participar debes:</p>
<ul>
	<li>
		Haber realizado pedido efectivo o más en Campaña 9 de 2.017. 
	</li>
	<li>
		En Campaña 10 crecer mínimo en un 10% el puntaje que realizaste en Campaña 9 de 2017. 
	</li>
	<li>
		Continuar creciendo mínimo en un 10% el puntaje de tu pedido versus el puntaje del pedido de la Campaña inmediatamente anterior; durante las Campañas 10, 11, 12, 13, 14 y 15  de 2.017.
	</li>	
</ul>

<p>LAS 5 ASESORAS QUE EN CAMPAÑA 15 DE 2.017, HAYAN TENIDO EL MAYOR CRECIMIENTO EN SU PUNTAJE, CUMPLIENDO CON LAS CONDICIONES DEL CONCURSO, VIAJARÁN A MEDELLÍN A COMPETIR EN LA GRAN FINAL DE TU CASA DE LUJO MP.</p>

<h3>PODRÁS HACERLE SEGUIMIENTO A TU DESEMPEÑO Y POSICIÓN EN EL CONCURSO</h3>

<p>Para este concurso hemos desarrollado una aplicación que podrás instalar en el celular (Smart Phone) o en el computador, en la que ingresando y activándote con tu mismo usuario y contraseña con los que haces pedido por la web de MP, podrás conocer:</p>
<ul>
	<li>
		La posición en la que te encuentras versus las demás Asesoras de Imagen que están compitiendo en TU CASA DE LUJO MP. 
	</li>
	<li>
		El puntaje que realizas en cada Campaña. 
	</li>
	<li>
		El puntaje mínimo que debes realizar en la Campaña siguiente para continuar participando en el concurso.
	</li>
	<li>
		Si continuas activa para la próxima campaña o no.
	</li>
	<li>
		Las devoluciones que realices, te aparecerán reflejadas dos Campañas después y no sumarán puntos.
	</li>
</ul>

<h2>TÉRMINOS Y CONDICIONES:</h2>

<ul>
	<li>
		<p>Si en una  de las 5 campañas que aplican para el concurso TU CASA DE LUJO MP, no alcanzaste a crecer mínimo el 10%, pero no decreciste en tu puntaje, tienes la campaña inmediatamente siguiente para crecer un 20% con relación a la Campaña inmediatamente anterior para continuar participando. (esta condición no aplica para las Campañas 10 y 15 de 2.017) Salvavidas</p>
	</li>
	<li>
		<p>Este concurso aplica únicamente para Asesoras que estén activas en MP a Campaña 9 de 2017. (las asesoras nuevas de campaña 9 de 2.017 también aplican para este concurso.</p>
	</li>
	<li>
		<p>Las devoluciones descuentan para el puntaje que llevas acumulado.</p>
	</li>
	<li>
		<p>Los agotados anunciados no suman puntos. </p>
	</li>
	<li>
		<p>Si la Asesora ganadora tiene casa o apartamento propio, los cincuenta millones de pesos colombianos ($50.000.000) se invertirán en remodelación y amoblamiento del inmueble</p>
	</li>
	<li>
		<p>Las Asesoras con casa o apartamento propio en caso de estar entre las 5 semifinalistas deben entregar el 7 de noviembre de 2.017 el certificado de libertad y tradición vigente, donde se certifique que el inmueble está a nombre de la persona que tiene registrada su cédula como Asesora de Imagen MP, su cónyuge o que está a nombre de una persona que tenga primer grado de consanguinidad con la persona que tiene registrada la cédula como Asesora de Imagen MP.</p>
	</li>
	<li>
		<p>Si la Asesora ganadora vive en una casa o apartamento arrendado, los cincuenta millones de pesos colombianos ($50.000.000) se invertirán únicamente en amoblamiento; o en caso de vivir en casa o apartamento arrendado la Asesora ganadora también podrá decidir realizar la remodelación en la casa de un familiar, con su respectiva autorización. </p>
	</li>
	<li>
		<p>El concurso TU CASA DE LUJO MP se realizará a partir del 22 de mayo de 2017 hasta el 15 de noviembre de 2017.</p>
	</li>
	<li>
		<p>El 7 de noviembre de 2017 se anunciará en el Facebook de MP y se contactarán telefónicamente las 5 Asesoras finalistas, que serán quienes tengan el mayor crecimiento en puntaje durante las campañas 10, 11, 12, 13, 14 y 15 de 2.017 y hayan cumplido con todas las condiciones del concurso.</p>
	</li>
	<li>
		<p>Las Gerentes de Zona de cada una de las 5 semifinalistas, les entregaran oficialmente el 8 de noviembre de 2017 la invitación para participar en la gran final del concurso TU CASA DE LUJO MP.</p>
	</li>
	<li>
		<p>Las 5 Asesoras Finalistas viajarán a Medellín, el 14 de noviembre de 2.017 para vivir una experiencia en las instalaciones de Marketing Personal y participar en el Desafío TU CASA DE LUJO MP donde competirán a través de retos dinámicos, por el premio final del concurso TU CASA DE LUJO MP. </p>
	</li>
	<li>
		<p>Marketing Personal asumirá los gastos de traslados desde y hacia el domicilio de las 5 finalistas, así como todos los desplazamientos en la ciudad de Medellín durante las actividades el día 15 de noviembre de 2.017.</p>
	</li>
	<li>
		<p>En caso de requerirse y de acuerdo a los itinerarios de vuelo de la ciudad de las 5 finalistas y en caso que las finalistas deban amanecer en Medellín, Marketing Personal asumirá los gastos de hospedaje y alimentación, no incluirá consumos de minibar y servicios adicionales que no estén incluidos en el hospedaje.</p>
	</li>
	<li>
		<p>Marketing Personal no se hace responsable por accidentes, reacciones alérgicas entre otras adversidades que puedan presentarse durante las actividades, el consumo de alimentos y los productos que utilicen las 5 semifinalistas. </p>
	</li>
	<li>
		<p>A la gran final del concurso solamente podrá asistir la asesora de imagen, por lo que el premio solo aplica para Asesoras de Imagen en excelentes condiciones de salud físicas y mentales para desplazarse a la ciudad de Medellín, además se requiere que estén afiliadas al sistema de seguridad social. En caso de estar afiliada como independiente, deben estar al día con el pago). </p>
	</li>
	<li>
		<p>La remodelación y/o amoblamiento, se realizará entre el 20 y el 26 de noviembre de 2017. (un experto en remodelación y adecuación de interiores definirá los cambios que se le realizarán a la casa o apartamento de la Asesora ganadora, estos cambios deben ser aprobados por La Asesora de Imagen ganadora)</p>
	</li>
	<li>
		<p>La entrega de la casa o apartamento remodelado y/o amoblado, se realizará entre el 27 de noviembre y el 4 de diciembre de 2017; para el momento de la entrega la ganadora deberá estar a Paz y Salvo con la Compañía.</p>
	</li>
	<li>
		<p>La Asesora de Imagen ganadora, acepta de manera anticipada el uso de sus datos y fotografías que sean tomadas como resultado del concurso, para actividades publicitarias de Marketing Personal S.A. así como las publicaciones que se realicen en la página web y redes sociales de la compañía.  </p>
	</li>
	<li>
		<p>El premio se le entregará a la persona que tenga la cédula registrada como Asesora de Imagen de Marketing Personal.</p>
	</li>
	<li>
		<p>El premio no se puede cambiar por dinero, ni por ningún otro premio.</p>
	</li>
	<li>
		<p>Marketing Personal asumirá la garantía de la remodelación, siempre y cuando los daños o defectos no sean causados por mal uso o por fenómenos naturales.</p>
	</li>
	<li>
		<p>Los cincuenta millones de pesos colombianos ($50.000.000) serán utilizados en su totalidad en la remodelación y/o amoblamiento de la casa de la Asesora ganadora; por lo tanto, no se realizará entrega de dinero en efectivo.</p>
	</li>
	<li>
		<p>Durante el tiempo de remodelación y/o amoblamiento, se considerará la reubicación de la Asesora Ganadora.</p>
	</li>
	<li>
		<p>En caso de evidenciarse fraude o conductas poco éticas de la asesora de imagen será automáticamente eliminada del concurso. </p>
	</li>
</ul>


</div>

                                        </asp:Panel>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                                    </div>
                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
         </div>
        <div class="row quiPadd">
            <div class="col-xs-12 quiPadd dw footImg">
                <footer>
                    <div class="col-xs-3 col-xs-offset-1 img_foot_right">
                        <asp:ImageButton ID="ImageButton2" ImageUrl="~/Image/icono_TCDL.png" CssClass="img-responsive" runat="server" />
                    </div>
                    <div class="col-xs-3 col-xs-offset-4 img_foot_left">
                       <asp:ImageButton ID="ImageButton1" ImageUrl="~/Image/icono_MP.png" CssClass="img-responsive image" PostBackUrl="http://www.marketingpersonal.com/" runat="server" />
                    </div>
                    <%--<asp:Image runat="server" ID="imgFooter" ImageUrl="~/Image/footer-login.png" CssClass="img-responsive" />--%>
                </footer>
            </div>
        </div>

        <script src="Scripts/bootstrap.min.js"></script>
        <script src="Scripts/jquery-1.9.1.min.js"></script>
    </form>

</body>
</html>
