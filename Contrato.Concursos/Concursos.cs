using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using System.ServiceModel.Activation;

namespace Contrato
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Concurso" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Concurso.svc o Concurso.svc.cs en el Explorador de soluciones e inicie la depuración.  
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Concursos : IConcursos
    {
        List<Concurso> IConcursos.ConsultaConcurso()
        {
            AccesoDatos.ConcursoDatos A = new AccesoDatos.ConcursoDatos();
            List<Concurso> ListConcurso = A.ConsultarConcurso(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
            return ListConcurso;
        }

        List<Ranking> IConcursos.Top5Ranking(string Identificacion)
        {
            AccesoDatos.RankingDatos A = new AccesoDatos.RankingDatos();
            List<Ranking> ListRanking = A.TopCinco(Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
            return ListRanking;
        }

        List<Campana> IConcursos.ConsultarCampanas()
        {
            AccesoDatos.CampañaDatos A = new AccesoDatos.CampañaDatos();
            List<Campana> ListCampana = A.ConsultarCampaña(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
            return ListCampana;
        }

        Usuario IConcursos.ConsultaLogin(string Identificacion, string PassWord)
        {
            AccesoDatos.UsuarioDatos A = new AccesoDatos.UsuarioDatos();
            Usuario UsuarioR = A.ConsultarLogin(Identificacion, PassWord, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
            return UsuarioR;
        }

        void IConcursos.RegistrarDispositivo(string Identificacion, string Token)
        {
            AccesoDatos.UsuarioDatos A = new AccesoDatos.UsuarioDatos();
            A.RegistraDispositivo(Identificacion, Token, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());            
        }

        void IConcursos.RegistrarUsuario(string Identificacion, string Nombre, DateTime FechaCierre)
        {
            AccesoDatos.UsuarioDatos A = new AccesoDatos.UsuarioDatos();
            Entidades.Usuario Usu = new Usuario();
            Usu.Identificacion = Identificacion;
            Usu.Perfil = "Vendedor";
            Usu.NombreCompleto = Nombre;
            Usu.FechaCierre = FechaCierre;
            A.ActualizarUsuario(Usu, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
        }

        void IConcursos.RegistrarRanking(string Identificacion, string ValorAnterior, string ValorActual)
        {
            AccesoDatos.RankingDatos A = new AccesoDatos.RankingDatos(); 
            Entidades.Ranking Ran = new Ranking();
            Ran.IdentificacionUsuario = Identificacion;
            Ran.ValorActual = long.Parse(ValorActual);
            Ran.ValorAnterior = long.Parse(ValorAnterior);

            A.InsertarRanking(Ran.ValorAnterior, Ran.ValorActual, Ran.IdentificacionUsuario, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
        }

        string IConcursos.PorcentajeActual(string Identificacion)
        {
            AccesoDatos.RankingDatos A = new AccesoDatos.RankingDatos();
            Ranking ListRanking = A.PorcentajeActual(Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
            string retornar;
            if (ListRanking.Meta >= ListRanking.ValorActual)
            {
                retornar = "Felicidades Cumpliste tu Meta";
            }
            else
            {
                retornar = "Estas cerca de cumplir tu Meta, te falta ($" + (ListRanking.Meta - ListRanking.ValorActual).ToString() + ")"; 
            } 

            return retornar;
        }
    }
}
