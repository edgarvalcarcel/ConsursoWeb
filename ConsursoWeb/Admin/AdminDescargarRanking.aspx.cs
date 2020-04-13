using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using Entidades;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConsursoWeb.Admin
{
    public partial class AdminDescargarRanking : System.Web.UI.Page
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
        public long IdConcurso=0;
        public long IdCampaña=0;
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


                        DDLConcurso.Dispose();
                        AccesoDatos.ConcursoDatos COn = new ConcursoDatos();

                        ListItem L = new ListItem();
                        L.Text = "Seleccione";
                        L.Value = "0";
                        DDLConcurso.Items.Add(L);
                        DDLConcurso.DataSource = COn.ConsultarTodosConcursos(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        DDLConcurso.DataBind();

                        DDLCampaña.Items.Add(L);
                        DDLCampaña.DataBind();



                    }
                }
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
                DDLCampaña.Items.Clear();
                DDLCampaña.Dispose();
                CampañaDatos camp = new CampañaDatos();
                ListItem L = new ListItem();
                IdConcurso = long.Parse(DDLConcurso.SelectedValue);
                L.Text = "Seleccione";
                L.Value = "0";
                DDLCampaña.Items.Add(L);

                DDLCampaña.DataSource = camp.ConsultarCampañasConcurso(IdConcurso, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                DDLCampaña.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }
        
        
        protected void Descargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DDLConcurso.SelectedValue != "0" && DDLCampaña.SelectedValue != "0")
                {
                IdConcurso = long.Parse(DDLConcurso.SelectedValue);
                IdCampaña = long.Parse(DDLCampaña.SelectedValue);


                RankingDatos Rank = new RankingDatos();
                DataTable dt = new DataTable();

                dt = Rank.DescargarRanking(IdCampaña, IdConcurso, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                string csv = string.Empty;

                foreach (DataColumn column in dt.Columns)
                {
                    //Add the Header row for CSV file.
                    csv += column.ColumnName + ',';
                }

                //Add new line.
                csv += "\r\n";

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        //Add the Data rows.
                        csv += row[column.ColumnName].ToString().Replace(",", ";") + ',';
                    }
                    csv = csv.Replace(";", ",");
                    //Add new line.
                    csv += "\r\n";
                }

                //Download the CSV file.
                Response.Clear();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment;filename=SqlExport.csv");
                Response.Charset = "";
                Response.ContentType = "application/text";
                Response.Output.Write(csv);
                Response.Flush();
                Response.End();
                }
                else
                {
                    Response.Write("<script>alert('Debe Seleccionar un Concurso y Campaña');</script>");
                }
                //ExportToExcel("Ranking.xls",GVDescarga);
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                if (mensaje != "Subproceso anulado.")
                {
                    Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
                }
            }
        }
        protected void BtnCerrar_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Login.aspx", false);
        }
    }
}