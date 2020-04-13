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
    public partial class AdminUsuario : System.Web.UI.Page
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
                    if (!IsPostBack)
                    {
                        BtnGuardar.Enabled = false;
                        CargarGVUsuario();
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        private void CargarGVUsuario()
        {
            try
            {
                ObjectDataSource1.SelectParameters.Clear();

                ObjectDataSource1.SelectParameters.Add(new Parameter() { Name = "conexion", DefaultValue = System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString() });

                GVUsuario.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                BtnGuardar.Enabled = true;
                TxtId.Text = "0";
                TxtIdentificacion.Text = string.Empty;
                TxtIdentificacion.Enabled = true;
                TxtNombreCompleto.Text = string.Empty;
                TxtNombreCompleto.Enabled = true;
                TxtPassword.Text = string.Empty;
                TxtPassword.Enabled = true;
                DdlPerfil.SelectedValue = "Seleccione";
                DdlPerfil.Enabled = true;
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
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    UsuarioDatos usuarios = new UsuarioDatos();
                    Usuario usuario = new Usuario();

                    usuario.Id = long.Parse(TxtId.Text);
                    usuario.NombreCompleto = TxtNombreCompleto.Text;
                    usuario.Identificacion = TxtIdentificacion.Text;
                    usuario.Password = TxtPassword.Text;
                    usuario.Perfil = DdlPerfil.SelectedValue;
                    usuario.Dispositivo = null;

                    DateTime thisDate = new DateTime(1900, 1, 01);
                    usuario.FechaCierre = thisDate;


                    usuarios.ActualizarUsuario(usuario, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                    if (usuarios.Estado == true)
                    {
                        Response.Write("<script>alert('Se Guardo Correctamente');</script>");
                        CargarGVUsuario();

                        BtnGuardar.Enabled = false;
                        TxtId.Text = string.Empty;
                        TxtNombreCompleto.Text = string.Empty;
                        TxtNombreCompleto.Enabled = false;
                        TxtIdentificacion.Text = string.Empty;
                        TxtIdentificacion.Enabled = false;
                        TxtPassword.Text = string.Empty;
                        TxtPassword.Enabled = false;
                        DdlPerfil.SelectedValue = "Seleccione";
                        DdlPerfil.Enabled = false;
                    }
                    else
                    {
                        Response.Write("alert('No Se Guardo Correctamente');");
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void GVUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    BtnGuardar.Enabled = true;
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow selectedRow = GVUsuario.Rows[index];
                    TableCell id = selectedRow.Cells[0];
                    TableCell nombreCompleto = selectedRow.Cells[1];
                    TableCell identificacion = selectedRow.Cells[2];
                    TableCell password = selectedRow.Cells[3];
                    TableCell perfil = selectedRow.Cells[4];

                    
                    
                    TxtId.Text = id.Text;

                    TxtIdentificacion.Text = HttpUtility.HtmlDecode(identificacion.Text);
                    TxtNombreCompleto.Text = HttpUtility.HtmlDecode(nombreCompleto.Text);
                    TxtNombreCompleto.Enabled = true;
                    TxtIdentificacion.Enabled = false;
                    TxtPassword.Text = HttpUtility.HtmlDecode(password.Text);
                    TxtPassword.Enabled = true;
                    DdlPerfil.SelectedValue = perfil.Text;
                    DdlPerfil.Enabled = true;
                    
                }
            }
            catch 
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        private bool Validar()
        {
            if (TxtNombreCompleto.Text != "" && TxtNombreCompleto.Text != null)
            {
                if (TxtIdentificacion.Text != "" && TxtIdentificacion.Text != null)
                {
                    long numero2;
                    if (long.TryParse(TxtIdentificacion.Text, out numero2) && long.Parse(TxtIdentificacion.Text) > 0)
                    {
                        if (TxtPassword.Text != "" && TxtPassword.Text != null)
                        {
                            if (DdlPerfil.Text != "Seleccione")
                            {
                                return true;
                            }
                            else
                            {
                                Response.Write("<script>alert('No se puede guardar el usuario sin seleccionar un perfil');</script>");
                                return false;
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('No se puede guardar el usuario sin un password');</script>");
                            return false;
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('No se puede guardar el usuario porque el número de la identificacíon no es valido');</script>");
                        return false;
                    }
                }
                else
                {
                    Response.Write("<script>alert('No se puede guardar el usuario sin una identificacíon');</script>");
                    return false;
                }
            }
            else
            {
                Response.Write("<script>alert('No se puede guardar el usuario sin un nombre');</script>");
                return false;
            }
        }
    }
}