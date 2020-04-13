using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsursoWeb
{
    public partial class pppp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReferenceConcurso.ConcursosClient Client = new ServiceReferenceConcurso.ConcursosClient();
            Entidades.Campana[] Listaaa = Client.ConsultarCampanas();
            string hh = "";
        }
    }
}