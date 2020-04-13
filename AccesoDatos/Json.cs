using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;

namespace AccesoDatos
{
    public class Json
    {
        public Boolean Estado;
        ///
        /// Método extensor para serializar un string a JSON
        ///
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

        private string ClearJSON(string Json, string Mappear)
        {
            if (Json.IndexOf("{\"MuestraEstudiantesResult\":") > -1)
            {
                Json = Json.Replace("{\"MuestraEstudiantesResult\":", "");
                Json = Json.Remove(Json.Length - 1);
            }
            return Json;
        }
    }    
}

