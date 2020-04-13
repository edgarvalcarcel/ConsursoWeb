using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using Entidades;
using System.Security.Cryptography;
using System.Text;

namespace ConsursoWeb
{
    public partial class Login : System.Web.UI.Page
    {
        public ServiciosUsuarioa.UsuarioConcursoMercadeo UsuarioMercadeo
        {
            get
            {
                return (ServiciosUsuarioa.UsuarioConcursoMercadeo)Session["UsuarioMercadeo" + Session.SessionID];
            }
            set
            {
                Session["UsuarioMercadeo" + Session.SessionID] = value;
            }
        }
        public string Usuario
        {
            get
            {
                return (string)Session["Usuario" + Session.SessionID];
            }
            set
            {
                Session["Usuario" + Session.SessionID] = value;
            }
        }
        public string Pass
        {
            get
            {
                return (string)Session["Pass" + Session.SessionID];
            }
            set
            {
                Session["Pass" + Session.SessionID] = value;
            }
        }
        public int Intentos
        {
            get
            {
                return (int)Session["Intentos" + Session.SessionID];
            }
            set
            {
                Session["Intentos" + Session.SessionID] = value;
            }
        }
        public AccesoDatos.CampañaDatos Campana
        {
            get
            {
                return (AccesoDatos.CampañaDatos)Session["Campana" + Session.SessionID];
            }
            set
            {
                Session["Campana" + Session.SessionID] = value;
            }
        }
        public AccesoDatos.ServicioMercadeo.RealityCrucero1 InformacionFacturacion
        {
            get
            {
                return (AccesoDatos.ServicioMercadeo.RealityCrucero1)Session["InformacionFacturacion" + Session.SessionID];
            }
            set
            {
                Session["InformacionFacturacion" + Session.SessionID] = value;
            }
        }
        public Entidades.Usuario UsuarioLogeado
        {
            get
            {
                return (Entidades.Usuario)Session["UsuarioLogeado" + Session.SessionID];
            }
            set
            {
                Session["UsuarioLogeado" + Session.SessionID] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    UsuarioTxt.Value = Usuario ;
                    ContraseñaTxt.Value = Pass ;
                }
                ConcursoDatos concursos1 = new ConcursoDatos();
                Concurso concActivo = new Concurso();

                concActivo = concursos1.ConsultarConcursoIniciado(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                Image1.ImageUrl = "Admin/CargarImagen2.aspx?id=" + concActivo.Id + "&Tipo=Aplicacion";
                
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void Registrarse_Click(object sender, EventArgs e)
        {
            try
            {
                if (Intentos == 0)
                {
                    Intentos = 0;
                }
            }
            catch (Exception)
            {
                Intentos = 0;
            }
            try
            {
                UsuarioTxt.Value = long.Parse(UsuarioTxt.Value).ToString();
                Usuario = UsuarioTxt.Value;
                Pass = ContraseñaTxt.Value;

                if (Image2.ImageUrl == "~/Image/check_in.png")
                {
                    if (Intentos == 2)
                    {
                        Intentos = 0;
                        Response.Redirect("Mensaje.aspx", false);
                    }
                    else if (UsuarioTxt.Value == "" || ContraseñaTxt.Value == "")
                    {
                        
                    }
                    else
                    {

                        ServiciosUsuarioa.UsuariosClient Service = new ServiciosUsuarioa.UsuariosClient();
                        ServiciosUsuarioa.LoginUsuario LoginU = new ServiciosUsuarioa.LoginUsuario();
                        LoginU.Request = new ServiciosUsuarioa.LoginUsuario1();
                        string Identificacion = "00000000000" + UsuarioTxt.Value;
                        LoginU.Request.NombreUsuario = Identificacion.Substring(Identificacion.Length - 11, Identificacion.Length - UsuarioTxt.Value.Length); // "00000012345"; //"00003744866";
                        Identificacion = LoginU.Request.NombreUsuario;
                        using (MD5 md5Hash = MD5.Create())
                        {
                            string hash = GetMd5Hash(md5Hash, ContraseñaTxt.Value);
                            LoginU.Request.Clave = hash;
                        }
                        //LoginU.Request.Clave = "MP12345";// "651c94799b5c806673916690eae62ad7";
                        LoginU.SesionId = UsuarioTxt.Value;
                        LoginU.UsuarioApp = System.Configuration.ConfigurationManager.AppSettings["UsuarioSistema"];
                        LoginU.PwdApp = System.Configuration.ConfigurationManager.AppSettings["PwdSistema"];
                        UsuarioMercadeo = Service.ConsutarUsuarioMercadeo(LoginU);

                        if (UsuarioMercadeo.InfoUsuarioConcursoMercadeo.Cedula != null)
                        {
                            AccesoDatos.ServicioMercadeo.MercadeoClient CliM = new AccesoDatos.ServicioMercadeo.MercadeoClient();

                            //AccesoDatos.ServicioMercadeo.RealityCrucero ReaL = new AccesoDatos.ServicioMercadeo.RealityCrucero();
                            //ReaL.Request = new AccesoDatos.ServicioMercadeo.RealityCruceroConsulta();
                            //ReaL.Request.Cedula = Identificacion;
                            //ReaL.Request.Campana = "201708";
                            //ReaL.SesionId = Identificacion;
                            //ReaL.UsuarioApp = System.Configuration.ConfigurationManager.AppSettings["UsuarioSistema"];
                            //ReaL.PwdApp = System.Configuration.ConfigurationManager.AppSettings["PwdSistema"];
                            //InformacionFacturacion = CliM.ConsultarRealityCrucero(ReaL);

                            //string contenido = InformacionFacturacion.Response.First().ValorDevolucionCampana10.ToString() + InformacionFacturacion.Response.First().ValorDevolucionCampana9.ToString() + InformacionFacturacion.Response.First().ValorDevolucionCampana8 + InformacionFacturacion.Response.First().ValorPedidoCampana10 + InformacionFacturacion.Response.First().ValorPedidoCampana9 + InformacionFacturacion.Response.First().ValorPedidoCampana8 + InformacionFacturacion.Response.First().Campana + InformacionFacturacion.Response.First().Cedula;

                            AccesoDatos.UsuarioDatos Usu = new UsuarioDatos();
                            Entidades.Usuario EUsu = new Entidades.Usuario();
                            EUsu.Identificacion = UsuarioTxt.Value;
                            EUsu.Perfil = "Vendedor";
                            EUsu.NombreCompleto = UsuarioMercadeo.InfoUsuarioConcursoMercadeo.NombreAsesor;
                            EUsu.FechaCierre = UsuarioMercadeo.InfoUsuarioConcursoMercadeo.FechaFinalMailgroup;
                            UsuarioMercadeo.InfoUsuarioConcursoMercadeo.Cedula = UsuarioTxt.Value;
                            Usu.ActualizarUsuario(EUsu, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                            AccesoDatos.RankingDatos Rank = new RankingDatos();
                            List<Ranking> ListRan = Rank.CrecimientoIndividualCampaña(UsuarioTxt.Value, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                            if (ListRan.Find(T => T.AproboCampana == "Sin Concursar") != null)
                            {
                                Intentos = Intentos + 1;
                                Response.Redirect("Mensaje2.aspx", false);
                            }
                            else if (Usu.ActualizaRanking(UsuarioTxt.Value))
                            {

                                if (ListRan.FindAll(T => T.AproboCampana == "Perdida").Count() >= 2)
                                {
                                    Intentos = Intentos + 1;
                                    Response.Redirect("Mensaje1.aspx", false);
                                }
                                else
                                {
                                    Intentos = Intentos + 1;
                                    Response.Redirect("Bienvenidos.aspx", false);
                                }
                            }
                            else
                            {
                                Intentos = Intentos + 1;
                                AccesoDatos.RankingDatos R = new RankingDatos();
                                R.InsertarRanking(999999999999999, 999999999999999, UsuarioTxt.Value, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                                Response.Redirect("Mensaje2.aspx", false);
                            }


                        }
                        else
                        {
                            AccesoDatos.UsuarioDatos UsuD = new UsuarioDatos();
                            UsuarioLogeado = UsuD.ConsultarLogin(UsuarioTxt.Value, ContraseñaTxt.Value, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                            if (UsuarioLogeado != null && UsuarioLogeado.Id != 0) //& Logi.Id != 0
                            {
                                // cargar variables de session
                                Response.Redirect("Admin/AdminConcurso.aspx", false);
                            }
                            else
                            {
                                //mensaje del sistema propuesto en el documetno
                                Intentos = Intentos + 1;
                                Response.Redirect("Mensaje5.aspx", false);
                            }

                        }
                    }
                }
                else
                {
                    Response.Redirect("Mensaje6.aspx", false);
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {


                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
        }

            // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
                // Hash the input.
                string hashOfInput = GetMd5Hash(md5Hash, input);

                // Create a StringComparer an compare the hashes.
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                if (0 == comparer.Compare(hashOfInput, hash))
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        protected void Image2_Click(object sender, ImageClickEventArgs e)
        {
            if (Image2.ImageUrl == "~/Image/check_out.png")
            {
                Image2.ImageUrl = "~/Image/check_in.png";
            }
            else {
                Image2.ImageUrl = "~/Image/check_out.png";
            }
        }
    }
}