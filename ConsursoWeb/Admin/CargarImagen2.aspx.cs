using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using Entidades;

namespace ConsursoWeb.Admin
{
    public partial class CargarImagen2 : System.Web.UI.Page
    {

        public static byte[] imagen;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                ConcursoDatos concursoDatos = new ConcursoDatos();
                Concurso concurso = new Concurso();
                switch (Request.QueryString["Tipo"])
                {
                    case "Aplicacion":
                        concurso = concursoDatos.ConsultarImageAplicacion(long.Parse(Request.QueryString["id"]), System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        imagen = concurso.ImageAplicacion;
                        break;
                    case "Avatar":
                        concurso = concursoDatos.ConsultarImageAvatar(long.Parse(Request.QueryString["id"]), System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        imagen = concurso.ImageAvatar;
                        break;
                    case "Web":
                        concurso = concursoDatos.ConsultarImageWeb(long.Parse(Request.QueryString["id"]), System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        imagen = concurso.ImageWeb;
                        break;
                    case "Movil":
                        concurso = concursoDatos.ConsultarImageMovil(long.Parse(Request.QueryString["id"]), System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        imagen = concurso.ImageMovil;
                        break;
                    default:
                        concurso = concursoDatos.ConsultarImageAplicacion(long.Parse(Request.QueryString["id"]), System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        imagen = concurso.ImageAplicacion;
                        break;
                }
                
                Response.BinaryWrite(imagen);
            }
            catch 
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }
    }
}