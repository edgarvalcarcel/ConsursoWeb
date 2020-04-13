using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using Entidades;

namespace ConsursoWeb.Paginas
{
    public partial class PerfilRanking : System.Web.UI.Page 
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

                    ////Image1.ImageUrl = "../Admin/CargarImagen2.aspx?id=" + concActivo.Id + "&Tipo=Avatar";
                    //Image2.ImageUrl = "../Admin/CargarImagen2.aspx?id=" + concActivo.Id + "&Tipo=Avatar";


                    AccesoDatos.RankingDatos Rank = new RankingDatos();
                    List<Ranking> Lista = Rank.CrecimientoIndividualCampaña(UsuarioMercadeo.InfoUsuarioConcursoMercadeo.Cedula, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                    GVCamCrec.DataSource = Lista;
                    GVCamCrec.DataBind();
                    GridView1.DataSource = Lista;
                    GridView1.DataBind();
                    foreach (var item in Lista)
                    {
                        if (item.Posicion != 0)
                        {
                            Lblpuesto.Text = item.Posicion.ToString();
                            LabelPuesto.Text = item.Posicion.ToString();
                            break;
                        }
                    }

                    UsuarioDatos Usuarios = new UsuarioDatos();
                    Usuario usuario = new Usuario();


                    usuario = Usuarios.ConsultarUsuario(UsuarioMercadeo.InfoUsuarioConcursoMercadeo.Cedula, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                    string email = UsuarioMercadeo.InfoUsuarioConcursoMercadeo.Email;
                    string telefono = UsuarioMercadeo.InfoUsuarioConcursoMercadeo.TelefonoCelular;

                    LblNombreCompleto.Text = usuario.NombreCompleto;
                    LblIdentificacion.Text = usuario.Identificacion;
                    LblTelefono.Text = telefono;
                    LblEmail.Text = email;

                    LabelNombre.Text = usuario.NombreCompleto;
                    LabelIdentificacion.Text = usuario.Identificacion;
                    LabelTelefono.Text = telefono;
                    LabelEmail.Text = email;
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