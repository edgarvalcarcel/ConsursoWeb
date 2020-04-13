using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Data.SqlClient;
using System.Data;

namespace ConsursoWeb
{
    public partial class PruebaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                AccesoDatos.UsuarioDatos Cierre = new AccesoDatos.UsuarioDatos();
                Cierre.UsuariosCierre();
            }
            catch (Exception EX)
            {
                string Valor = EX.Message;
                throw;
            }
        }
        
        public string SerializaToJson(object objeto)
        {
            string jsonResult = string.Empty;
            try
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(objeto.GetType());
                MemoryStream ms = new MemoryStream();
                jsonSerializer.WriteObject(ms, objeto);
                jsonResult = Encoding.Default.GetString(ms.ToArray());
            }
            catch { throw; }
            return jsonResult;
        }
        public T DeserializarJsonTo<T>(string jsonSerializado)
        {
            try
            {
                T obj = Activator.CreateInstance<T>();
                MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonSerializado));
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                obj = (T)serializer.ReadObject(ms);
                ms.Close();
                ms.Dispose();
                return obj;
            }
            catch { return default(T); }
        }
        public string Ejecutar(string Url, string Datos, string Metodo)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(Datos);

            HttpWebRequest request;
            request = WebRequest.Create(Url) as HttpWebRequest;
            request.Timeout = 10 * 1000;
            request.Method = Metodo;
            request.ContentLength = data.Length;
            request.ContentType = "application/json; charset=utf-8";
            Stream postStream = request.GetRequestStream();
            postStream.Write(data, 0, data.Length);

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            return json; // ClearJSON(json);
        }
    }
}