using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging;
using Quartz;

namespace Worker
{
    /// <summary>
    /// A Hello World Job
    /// </summary>
    public class HelloWorldJob : IJob
    {
        private const string fileName = "log";

        public void Execute(IJobExecutionContext context)
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
    }
}
