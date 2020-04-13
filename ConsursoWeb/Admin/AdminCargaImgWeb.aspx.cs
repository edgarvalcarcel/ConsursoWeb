using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using System.IO;

namespace ConsursoWeb.Admin
{
    public partial class AdminCargaImgWeb : System.Web.UI.Page
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

        public static byte[] imagen1;
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
                        DDLConcurso.Dispose();
                        AccesoDatos.ConcursoDatos COn = new ConcursoDatos();
                        ListItem L = new ListItem();
                        L.Text = "Seleccione";
                        L.Value = "0";
                        DDLConcurso.Items.Add(L);
                        DDLConcurso.DataSource = COn.ConsultarTodosConcursos(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        DDLConcurso.DataBind();
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    HttpPostedFile archivo = FileUpload1.PostedFile;
                    int i = archivo.ContentLength;
                    if (i > 0)
                    {
                        string ext = Path.GetExtension(FileUpload1.PostedFile.FileName);
                        if (ext.ToUpper() == ".JPG" || ext.ToUpper() == ".PNG" || ext.ToUpper() == ".GIF" || ext.ToUpper() == ".JPEG")
                        {
                            string imgName = archivo.FileName;
                            byte[] imgBinaryData = new byte[i];
                            int n = archivo.InputStream.Read(imgBinaryData, 0, i);
                            //Image_Usuario.
                            imagen1 = imgBinaryData;
                            //Session["CargarImagen"] = imgBinaryData;
                            //Image_Usuario.ImageUrl = "CargarImagen.aspx";

                            //Image_Usuario.ToolTip = archivo.FileName;
                            System.Drawing.Image im;
                            using (MemoryStream ms = new MemoryStream(imgBinaryData, 0, imgBinaryData.Length))
                            {
                                ms.Write(imgBinaryData, 0, imgBinaryData.Length);
                                im = System.Drawing.Image.FromStream(ms, true);
                                //Image_Usuario.ToolTip = im.Width.ToString() + " X " + im.Height.ToString();
                            }

                            ConcursoDatos Concurso = new ConcursoDatos();
                            Concurso.ActualizarImagenWeb(long.Parse(DDLConcurso.SelectedValue), imagen1, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                        }
                        else
                        {
                            //Make sure we are dealing with a JPG or GIF file
                            string extension = Path.GetExtension(FileUpload1.PostedFile.FileName).ToLower();
                            byte[] imageBytes = new byte[FileUpload1.PostedFile.InputStream.Length + 1];
                            FileUpload1.PostedFile.InputStream.Read(imageBytes, 0, imageBytes.Length);

                        }
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
                ImageAplicacion.ImageUrl = "CargarImagen2.aspx?id=" + DDLConcurso.SelectedValue + "&Tipo=Web";
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }
    }
}