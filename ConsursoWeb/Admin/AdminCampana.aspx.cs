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
    public partial class AdminCampana : System.Web.UI.Page
    {
        private long Id;

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

                        CdEFin.SelectedDate = DateTime.Now;
                        CdEInicio.SelectedDate = DateTime.Now;

                        DDLConcurso.Dispose();
                        AccesoDatos.ConcursoDatos COn = new ConcursoDatos();

                        DDLConcurso.DataSource = COn.ConsultarTodosConcursos(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        DDLConcurso.DataBind();

                        Id = long.Parse(DDLConcurso.SelectedValue);

                        CargarCampañas();
                        
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        private void CargarCampañas()
        {
            try
            {
                ObjectDataSource1.SelectParameters.Clear();
                ObjectDataSource1.SelectParameters.Add(new Parameter() { Name = "idConcurso", DefaultValue = Id.ToString() });
                ObjectDataSource1.SelectParameters.Add(new Parameter() { Name = "conexion", DefaultValue = System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString() });

                GVCampana.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void DDLConcurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Id = long.Parse(DDLConcurso.SelectedValue);
                CargarCampañas();
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void GVCampana_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    BtnGuardar.Enabled = true;

                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow selectedRow = GVCampana.Rows[index];
                    TableCell id = selectedRow.Cells[0];
                    TableCell descripcion = selectedRow.Cells[1];
                    TableCell porcentajeCrecimiento = selectedRow.Cells[2];
                    TableCell estado = selectedRow.Cells[3];
                    TableCell fechaInicio = selectedRow.Cells[4];
                    TableCell fechaFin = selectedRow.Cells[5];
                    
                    if(estado.Text == "Abierta")
                    {
                        DDLConcurso.Enabled = false;
                    }
                    else
                    {
                        DDLConcurso.Enabled = true;
                    }

                    TxtId.Text = id.Text;

                    TxtDescripcion.Text = HttpUtility.HtmlDecode(descripcion.Text);
                    TxtDescripcion.Enabled = true;
                    TxtPorcentajeCrecimiento.Text = porcentajeCrecimiento.Text;
                    TxtPorcentajeCrecimiento.Enabled = true;
                    DdlEstado.SelectedValue = estado.Text;
                    DdlEstado.Enabled = true;
                    //TxtFechaInicio.Text = fechaFin.Text;
                    TxtFechaFin.Enabled = true;
                    TxtFechaInicio.Enabled = true;
                    CdEInicio.SelectedDate = Convert.ToDateTime( fechaInicio.Text);
                    
                    //TxtFechaFin.Text = fechaInicio.Text;
                    CdEFin.SelectedDate = Convert.ToDateTime(fechaFin.Text);
                    Id = long.Parse(DDLConcurso.SelectedValue);





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
                DDLConcurso.Enabled = true;
                TxtDescripcion.Text = string.Empty;
                TxtDescripcion.Enabled = true;
                TxtPorcentajeCrecimiento.Text = string.Empty;
                TxtPorcentajeCrecimiento.Enabled = true;
                TxtFechaInicio.Enabled = true;
                TxtFechaFin.Enabled = true;
                DdlEstado.SelectedValue = "Seleccione";
                DdlEstado.Enabled = true;
                Id = long.Parse(DDLConcurso.SelectedValue);
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
                if (Validar())
                {
                    var CampañaAbierta = "no";
                    long idCampañaAbierta = 0;
                    CampañaDatos campañas = new CampañaDatos();
                    Campana campaña = new Campana();
                    ConcursoDatos concursos = new ConcursoDatos();
                    Concurso concurso = new Concurso();
                    List<Campana> listCampañas = new List<Campana>();

                    Id = long.Parse(DDLConcurso.SelectedValue);

                    concurso = concursos.ConsultarConcursoEspecifico(Id, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                    listCampañas = campañas.ConsultarCampaña(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                    int tamLis = GVCampana.Rows.Count;

                    foreach (var item in listCampañas)
                    {
                        if (item.Estado == "Abierta")
                        {
                            idCampañaAbierta = item.Id;
                            CampañaAbierta = "si";
                        }

                    }



                    campaña.Id = long.Parse(TxtId.Text);
                    campaña.Descripcion = TxtDescripcion.Text;
                    campaña.PorcentajeCrecimiento = decimal.Parse(TxtPorcentajeCrecimiento.Text);
                    campaña.IdConcurso = Id;
                    campaña.Estado = DdlEstado.Text;
                    campaña.Inicio = Convert.ToDateTime(TxtFechaInicio.Text);
                    campaña.Fin = Convert.ToDateTime(TxtFechaFin.Text);

                    if ((CampañaAbierta == "si" && campaña.Estado == "Abierta" && campaña.Id != idCampañaAbierta) || (tamLis >= concurso.NumeroCampañas && long.Parse(TxtId.Text) == 0) || campaña.Estado=="Cerrada")
                    {
                        if (CampañaAbierta == "si" && campaña.Estado == "Abierta")
                        {
                            Response.Write("<script>alert('No se puede guardar la campaña con estado abierta, porque ya existe una campaña abierta');</script>");
                            
                        }
                        else
                        {
                            if (campaña.Estado == "Cerrada")
                            {
                                Response.Write("<script>alert('No se puede guardar la campaña con estado cerrada porque solo se puede cerrar desde el proceso automatizado de cierre');</script>");
                            }
                            else
                            { 
                                Response.Write("<script>alert('No se puede guardar la campaña porque ya estan creadas todas las campañas del concurso seleccionado');</script>");
                            }
                        }
                    }
                    else
                    {


                        campañas.ActualizarCampaña(campaña, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                        if (campañas.Estado == true)
                        {
                            Response.Write("<script>alert('Se Guardo Correctamente');</script>");
                            CargarCampañas();

                            TxtId.Text = "";
                            DDLConcurso.Enabled = true;
                            TxtDescripcion.Text = string.Empty;
                            TxtDescripcion.Enabled = false;
                            TxtPorcentajeCrecimiento.Text = string.Empty;
                            TxtPorcentajeCrecimiento.Enabled = false;
                            TxtFechaInicio.Enabled = false;
                            TxtFechaFin.Enabled = false;
                            DdlEstado.SelectedValue = "Seleccione";
                            DdlEstado.Enabled = false;
                            BtnGuardar.Enabled = false;
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
            if (TxtDescripcion.Text != "" && TxtDescripcion != null)
            {
                if (  TxtPorcentajeCrecimiento.Text != "" && TxtPorcentajeCrecimiento.Text != null)
                {
                    decimal numero;
                    if (decimal.TryParse(TxtPorcentajeCrecimiento.Text, out numero) && decimal.Parse(TxtPorcentajeCrecimiento.Text) > 0)
                    {
                        if(DdlEstado.Text != "Seleccione")
                        { 
                            return true;
                        }
                        else
                        {
                            Response.Write("<script>alert('No se puede guardar la campaña porque debe seleccionar un estado');</script>");
                            return false;
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('No se puede guardar la campaña porque el porcentaje de crecimiento no es valido');</script>");
                        return false;
                    }
                }
                else
                {
                    Response.Write("<script>alert('No se puede guardar la campaña sin un porcentaje de crecimiento');</script>");
                    return false;
                }

            }
            else
            {
                Response.Write("<script>alert('No se puede guardar la campaña sin una descripcion');</script>");
                return false;
            }    

        }

        protected void BtnCerrar_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Login.aspx", false);
        }
    }
}