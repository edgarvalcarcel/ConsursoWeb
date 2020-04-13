using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsursoWeb
{
    public partial class Bienvenidos : System.Web.UI.Page
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
            if (UsuarioMercadeo == (null))
            {
                Response.Redirect("../Login.aspx", false);
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("Paginas/Informacion.aspx", false);

        }
    }
}