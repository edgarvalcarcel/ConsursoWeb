using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsursoWeb.Paginas
{
    public partial class Premio : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioMercadeo == (null))
                {
                    Response.Redirect("../Login.aspx", false);
                }
                else
                {
                    ConcursoDatos concursos1 = new ConcursoDatos();
                    Concurso concActivo = new Concurso();

                    concActivo = concursos1.ConsultarConcursoIniciado(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                    Image1.ImageUrl = "../Admin/CargarImagen2.aspx?id=" + concActivo.Id + "&Tipo=Movil";
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }
        protected void BtnCerrar_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Login.aspx", false);
        }
    }
}