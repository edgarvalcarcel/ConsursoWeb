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
    public partial class TopCinco : System.Web.UI.Page
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

                    ImageWeb.ImageUrl = "../Admin/CargarImagen2.aspx?id=" + concActivo.Id + "&Tipo=Web";


                    ObjectDataSource1.SelectParameters.Clear();

                    ObjectDataSource1.SelectParameters.Add(new Parameter() { Name = "usu_identificacion", DefaultValue = UsuarioMercadeo.InfoUsuarioConcursoMercadeo.Cedula });
                    ObjectDataSource1.SelectParameters.Add(new Parameter() { Name = "conexion", DefaultValue = System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString() });

                    GVTopCinco.DataBind();

                    foreach (GridViewRow row in GVTopCinco.Rows)
                    {
                        if (row.RowIndex.Equals(5))
                        {

                            row.Cells[0].Text = "TU POSICIÓN";
                            row.Cells[0].Style.Add("text-align", "right");
                            row.Cells[0].Style.Add("padding-top", "5%");
                            row.Cells[0].Style.Add("border", "0 solid");
                            row.Cells[0].Style.Add("font-weight", "600");
                            row.Cells[0].CssClass = "top5";
                            row.Cells[1].Text = "";
                            //row.CssClass = "fonAz";
                            //row.Cells[0].CssClass = "fonAz0";
                            //row.Cells[1].CssClass = "fonAz1";
                        }
                        if (row.RowIndex.Equals(6))
                        {
                            row.CssClass = "fonAz";
                            row.Cells[0].CssClass = "fonAz0";
                            row.Cells[1].CssClass = "fonAz1";
                        }
                    }

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

        protected void lnkAqui_Click(object sender, EventArgs e)
        {
            Response.Redirect("PerfilRanking.aspx", false);
        }
    }
}