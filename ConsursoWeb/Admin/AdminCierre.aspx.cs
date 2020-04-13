using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsursoWeb.Admin
{

    public partial class AdminCierre : System.Web.UI.Page
    {
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
        protected void BtnCerrar_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Login.aspx", false);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogeado == (null))
                {
                    Response.Redirect("../Login.aspx", false);
                }
                else
                {
                    ObjectDataSource1.SelectParameters.Clear();
                    ObjectDataSource1.SelectParameters.Add(new Parameter() { Name = "conexion", DefaultValue = System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString() });

                    GVCierre.DataBind();
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }
    }
}