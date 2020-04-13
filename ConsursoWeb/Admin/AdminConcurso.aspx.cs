using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using Entidades;
using System.Text.RegularExpressions;

namespace ConsursoWeb.Admin
{
    public partial class AdminConcurso : System.Web.UI.Page
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
                    if (!IsPostBack)
                    {
                        BtnGuardar.Enabled = false;
                        CargarGVConcurso();
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        private void CargarGVConcurso()
        {
            try
            {
                ObjectDataSource1.SelectParameters.Clear();

                ObjectDataSource1.SelectParameters.Add(new Parameter() { Name = "conexion", DefaultValue = System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString() });

                GVConcurso.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void GVConcurso_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    BtnGuardar.Enabled = true;
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow selectedRow = GVConcurso.Rows[index];
                    TableCell id = selectedRow.Cells[0];
                    TableCell titulo = selectedRow.Cells[1];
                    TableCell descripcion = selectedRow.Cells[3];
                    TableCell numeroCampañas = selectedRow.Cells[2];
                    TableCell estado = selectedRow.Cells[4];
                    TableCell telefono = selectedRow.Cells[5];
                    TableCell mail = selectedRow.Cells[6];

                    TxtId.Text = id.Text;

                    TxtTitulo.Text = HttpUtility.HtmlDecode(titulo.Text);
                    TxtTitulo.Enabled = true;
                    TxtDescripcionPremio.Text = HttpUtility.HtmlDecode(descripcion.Text);
                    TxtDescripcionPremio.Enabled = true;
                    TxtNumeroCampana.Text = numeroCampañas.Text;
                    TxtNumeroCampana.Enabled = true;
                    TxtTelefono.Text = telefono.Text;
                    TxtTelefono.Enabled = true;
                    TxtMail.Text = mail.Text;
                    TxtMail.Enabled = true;
                    DdlEstado.SelectedValue = estado.Text;
                    DdlEstado.Enabled = true;

                    if (estado.Text == "Iniciado")
                    {
                        TxtNumeroCampana.Enabled = false;
                    }                    
                }
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

                TxtTitulo.Text = string.Empty;
                TxtTitulo.Enabled = true;
                TxtDescripcionPremio.Text = string.Empty;
                TxtDescripcionPremio.Enabled = true;
                TxtNumeroCampana.Text = string.Empty;
                TxtNumeroCampana.Enabled = true;
                TxtTelefono.Text = string.Empty;
                TxtTelefono.Enabled = true;
                TxtMail.Text = string.Empty;
                TxtMail.Enabled = true;
                DdlEstado.SelectedValue = "Seleccione";
                DdlEstado.Enabled = true;
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() )
                {
                    var ConcursoIniciado = "no";
                    ConcursoDatos concursos = new ConcursoDatos();
                    Concurso concurso = new Concurso();
                    string IdConcursoRegistrado = "";
                    for (int i = 0; i < GVConcurso.Rows.Count; i++)
                    {
                        if (GVConcurso.Rows[i].Cells[4].Text == "Iniciado")
                        {
                            IdConcursoRegistrado = GVConcurso.Rows[i].Cells[0].Text;
                            ConcursoIniciado = "si";
                        }
                    }

                    concurso.Id = long.Parse(TxtId.Text);
                    concurso.Titulo = TxtTitulo.Text;
                    concurso.DescripcionPremio = TxtDescripcionPremio.Text;
                    concurso.NumeroCampañas = int.Parse(TxtNumeroCampana.Text);
                    concurso.Estado = DdlEstado.Text;
                    concurso.Telefono = TxtTelefono.Text;
                    concurso.Mail = TxtMail.Text;

                    if (ConcursoIniciado == "si" && concurso.Estado == "Iniciado" && IdConcursoRegistrado != TxtId.Text)
                    {
                        Response.Write("<script>alert('No se puede guardar el concurso con estado iniciado, porque ya existe un concurso iniciado');</script>");

                    }
                    else
                    {
                        concursos.ActualizarConcurso(concurso, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                        if (concursos.Estado == true)
                        {
                            Response.Write("<script>alert('Se Guardo Correctamente');</script>");
                            CargarGVConcurso();

                            BtnGuardar.Enabled = false;
                            TxtId.Text = string.Empty;
                            TxtTitulo.Text = string.Empty;
                            TxtTitulo.Enabled = false;
                            TxtDescripcionPremio.Text = string.Empty;
                            TxtDescripcionPremio.Enabled = false;
                            TxtNumeroCampana.Text = string.Empty;
                            TxtNumeroCampana.Enabled = false;
                            TxtTelefono.Text = string.Empty;
                            TxtTelefono.Enabled = false;
                            TxtMail.Text = string.Empty;
                            TxtMail.Enabled = false;
                            DdlEstado.SelectedValue = "Seleccione";
                            DdlEstado.Enabled = false;
                        }
                        else
                        {
                            Response.Write("alert('No Se Guardo Correctamente');");
                        }
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        private bool Validar()
        {
            if (TxtTitulo.Text != "" && TxtTitulo.Text != null)
            {
                if (TxtDescripcionPremio.Text != "" && TxtDescripcionPremio.Text != null)
                {
                    if (DdlEstado.Text != "Seleccione")
                    {
                        if (TxtNumeroCampana.Text != "" && TxtNumeroCampana.Text != null)
                        {
                            int numero;
                            if (int.TryParse(TxtNumeroCampana.Text, out numero) && int.Parse(TxtNumeroCampana.Text) > 0)
                            {
                                if(TxtTelefono.Text != "" && TxtTelefono.Text != null)
                                {
                                    long numero2;
                                    if (long.TryParse(TxtTelefono.Text,out numero2) && long.Parse(TxtTelefono.Text) > 0)
                                    {
                                        String expresion;
                                        expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

                                        if (TxtMail.Text != "" && Regex.IsMatch(TxtMail.Text, expresion))
                                        {
                                            return true; 
                                        }
                                        else
                                        {
                                            Response.Write("<script>alert('No se puede crear el concurso sin un correo electronico valido ');</script>");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        Response.Write("<script>alert('No se puede guardar el concurso porque el número de telefono no es valido');</script>");
                                        return false;
                                    }
                                }
                                else
                                {
                                    Response.Write("<script>alert('No se puede guardar el concurso sin un número de telefono');</script>");
                                    return false;
                                }
                            }
                            else
                            {
                                Response.Write("<script>alert('No se puede guardar el concurso porque el número de campañas establecido no es valido');</script>");
                                return false;
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('No se puede guardar el concurso sin un número de campañas establecido');</script>");
                            return false;
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('No se puede guardar el concurso sin seleccionar un estado');</script>");
                        return false;
                    }
                }
                else
                {
                    Response.Write("<script>alert('No se puede guardar el concurso sin una descripcion del premio');</script>");
                    return false;
                }
            }
            else
            {
                Response.Write("<script>alert('No se puede guardar el concurso sin un titulo');</script>");
                return false;
            }
        }
    }
}