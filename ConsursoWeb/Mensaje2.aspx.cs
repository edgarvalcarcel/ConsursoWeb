using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using Entidades;

namespace ConsursoWeb
{
    public partial class Mensaje2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConcursoDatos concursos1 = new ConcursoDatos();
            Concurso concActivo = new Concurso();

            concActivo = concursos1.ConsultarConcursoIniciado(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

            Image1.ImageUrl = "Admin/CargarImagen2.aspx?id=" + concActivo.Id + "&Tipo=Aplicacion";

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);
        }
    }
}