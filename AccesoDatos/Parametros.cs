using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.Web;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Parametros
    {
        private string empresa;
        private string usuarioenviado;

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string UsuarioEnviado
        {
            get { return usuarioenviado; }
            set { usuarioenviado = value; }
        }

        //Insertar
        public static string fi_SPI_INSERTAR_RANKING = "MpSp_InsertarRanking";

        //Actualizar
        public static string fu_SPU_ACTUALIZAR_CONCURSO = "MpSp_ActualizarConcurso";
        public static string fu_SPU_ACTUALIZAR_IMAGEN_WEB = "MpSp_ActualizarImagenWeb";
        public static string fu_SPU_ACTUALIZAR_IMAGEN_MOVIL = "MpSp_ActualizarImagenMovil";
        public static string fu_SPU_ACTUALIZAR_IMAGEN_AVATAR = "MpSp_ActualizarImagenAvatar";
        public static string fu_SPU_ACTUALIZAR_IMAGEN_APLICACION = "MpSp_ActualizarImagenAplicacion";
        public static string fu_SPU_ACTUALIZAR_CAMPAÑA = "MpSp_ActualizarCampana";
        public static string fu_SPU_ACTUALIZAR_USUARIO = "MpSp_ActualizarUsuario";
        public static string fu_SPU_REGISTRA_DISPOSITIVO = "MpSp_RegistraDispositivo";
        //Parametricas Consulta
        public static string fc_SPS_CAMPAÑA = "MpSp_Campana";
        public static string fc_SPS_CAMPAÑAS_CONCURSO = "MpSp_CampanasConcurso";
        public static string fc_SPS_CAMPAÑA_ABIERTA = "MpSp_CampanaAbierta";
        public static string fc_SPS_CONCURSO = "MpSp_Concurso";
        public static string fc_SPS_CONCURSO_INICIADO = "MpSp_ConcursoIniciado";
        public static string fc_SPS_CONCURSO_ESPECIFICO = "MpSp_ConcursoEspecifico";
        public static string fc_SPS_IMAGEN_WEB = "MpSp_ImagenWeb";
        public static string fc_SPS_IMAGEN_MOVIL = "MpSp_ImagenMovil";
        public static string fc_SPS_IMAGEN_AVATAR = "MpSp_ImagenAvatar";
        public static string fc_SPS_IMAGEN_APLICACION = "MpSp_ImagenAplicacion";
        public static string fc_SPS_LOGIN = "MpSp_Login";
        public static string fc_SPS_CIERRE = "MpSp_Cierre";
        public static string fc_SPS_USUARIOS_ESPECIALES = "MpSp_UsuariosEspeciales";
        public static string fc_SPS_USUARIOS_PROCESAR = "MpSp_UsuariosProcesar";
        public static string fc_SPS_USUARIOS_CIERRE = "MpSp_UsuariosCierre";
        public static string fc_SPS_USUARIO = "MpSp_Usuario";
        public static string fc_SPS_TOP_CINCO = "MpSp_TopCinco";
        public static string fc_SPS_PORCENTAJE_ACTUAL = "MpSp_PorcentajeActual"; 
        public static string fc_SPS_DESCARGAR_RANKING = "MpSp_DescargarRanking";
        public static string fc_SPS_CRECIMIENTO_INDIVIDUAL_CAMPANAS = "MpSp_CrecimientoIndividualCampanas";

    }
}
