using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using AccesoDatos;
using Entidades;
using System.Text;
using System.Net;
using System.Configuration;
using System.Text.RegularExpressions;

namespace ConsursoWeb.Paginas
{
    public partial class PagContacto : System.Web.UI.Page
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
        public Entidades.Concurso ConcursoActivo
        {
            get
            {
                return (Entidades.Concurso)Session["ConcursoActivo" + Session.SessionID];
            }
            set
            {
                Session["ConcursoActivo" + Session.SessionID] = value;
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
                    
                    ConcursoDatos concursos = new ConcursoDatos();
                    Concurso concurso = new Concurso();

                ConcursoActivo = concursos.ConsultarConcursoIniciado(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                    aTel.HRef = "tel:"+ConcursoActivo.Telefono;
                    aTel.InnerText = ConcursoActivo.Telefono;

                }
            }
            catch
            {
                Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador');</script>");
            }
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            //try
            //{

                //String expresion;
                //expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

                //if (TxtDescripcion.Text == "" || TxtDescripcion.Text == null || !Regex.IsMatch(TxtCorreo.Value, expresion) || TxtCorreo.Value == "")
                //{
                //    Response.Write("<script>alert('No se puede enviar el mensaje si no ha digitado ningun texto o un correo electronico valido ');</script>");
                //}
                //else
                //{
                //    //Configuración del Mensaje
                //    MailMessage mail = new MailMessage();
                //    SmtpClient SmtpServer = new SmtpClient();
                //    SmtpServer.UseDefaultCredentials = false;
                //    SmtpServer = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
                //    //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
                //    mail.From = new MailAddress(ConfigurationManager.AppSettings["MailAddressFrom"], ConfigurationManager.AppSettings["MailTitulo"], Encoding.UTF8);
                //    //Aquí ponemos el asunto del correo
                //    mail.Subject = ConfigurationManager.AppSettings["Subject"];
                //    //Aquí ponemos el mensaje que incluirá el correo
                //    mail.Body = TxtDescripcion.Text;
                //    //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
                //    mail.To.Add(ConcursoActivo.Mail);
                //    mail.To.Add(TxtCorreo.Value);
                //    //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
                //    //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));

                //    //Configuracion del SMTP
                //    SmtpServer.Port = int.Parse(ConfigurationManager.AppSettings["Puerto"]);// 587; //Puerto que utiliza Gmail para sus servicios
                //                           //Especificamos las credenciales con las que enviaremos el mail
                //    SmtpServer.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["NetworkCredentialUser"], ConfigurationManager.AppSettings["NetworkCredentialPass"]);
                //    SmtpServer.EnableSsl = true;
                    
                //    SmtpServer.Send(mail);

                //    TxtDescripcion.Text = string.Empty;
                //    TxtCorreo.Value = string.Empty;

                //    Response.Write("<script>alert('El mensaje se envio correctamente');</script>");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Response.Write("<script>alert('Ha ocurrido un error inesperado, si el problema persiste por favor contáctese con un administrador. " + ex.Message + "');</script>");
            //}
        }
        protected void BtnCerrar_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Login.aspx", false);
        }
    }
}