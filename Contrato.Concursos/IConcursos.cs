using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using System.ServiceModel.Web;

namespace Contrato
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IConcurso" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConcursos
    {
        [OperationContract]
        [WebGet(UriTemplate = "/ConsultaConcurso", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<Concurso> ConsultaConcurso();

        [OperationContract]
        [WebGet(UriTemplate = "/Top5Ranking/{Identificacion}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<Ranking> Top5Ranking(string Identificacion);

        [OperationContract]
        [WebGet(UriTemplate = "/ConsultarCampanas", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<Campana> ConsultarCampanas();

        [OperationContract]
        [WebGet(UriTemplate = "/ConsultaLogin?Identificacion={Identificacion}&PassWord={PassWord}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        Usuario ConsultaLogin(string Identificacion, string PassWord);

        [OperationContract]
        [WebGet(UriTemplate = "/RegistrarDispositivo?Identificacion={Identificacion}&Token={Token}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        void RegistrarDispositivo(string Identificacion, string Token);

        [OperationContract]
        [WebGet(UriTemplate = "/RegistrarUsuario?Identificacion={Identificacion}&Nombre={Nombre}&FechaCierre={FechaCierre}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        void RegistrarUsuario(string Identificacion, string Nombre, DateTime FechaCierre);

        [OperationContract]
        [WebGet(UriTemplate = "/RegistrarRanking?Identificacion={Identificacion}&ValorAnterior={ValorAnterior}&ValorActual={ValorActual}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        void RegistrarRanking(string Identificacion, string ValorAnterior, string ValorActual);

        [OperationContract]
        [WebGet(UriTemplate = "/PorcentajeActual/{Identificacion}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        String PorcentajeActual(string Identificacion);
    }
}
