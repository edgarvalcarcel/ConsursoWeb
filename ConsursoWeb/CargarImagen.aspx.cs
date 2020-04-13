using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos;
using Entidades;
public partial class Administracion_CargarImagen : System.Web.UI.Page
{
    public static byte[] imagen1;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           
            ConcursoDatos concursoDatos = new ConcursoDatos();
            Concurso concurso = new Concurso();
            concurso = concursoDatos.ConsultarImageAplicacion(2, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
            imagen1 = concurso.ImageAplicacion;
            Response.BinaryWrite(imagen1);
        }
        catch (Exception ex)
        {
            string name = this.GetType().FullName.ToString();
            System.Reflection.MethodBase currentMethod = System.Reflection.MethodBase.GetCurrentMethod();
           
        }
    }
}