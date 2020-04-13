using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private long usu_id;
        private string usu_identificacion;
        private string usu_dispositivo;
        private string usu_password;
        private string usu_perfil;

        public long Id
        {
            get
            {
                return usu_id;
            }
            set
            {
                usu_id = value;
            }
        }

        public string Identificacion
        {
            get
            {
                return usu_identificacion;
            }
            set
            {
                usu_identificacion = value;
            }
        }

        public string Dispositivo
        {
            get
            {
                return usu_dispositivo;
            }
            set
            {
                usu_dispositivo = value;
            }
        }

        
        public string Perfil
        {
            get
            {
                return usu_perfil;
            }
            set
            {
                usu_perfil = value;
            }
        }

        public string Password
        {
            get
            {
                return usu_password;
            }
            set
            {
                usu_password = value;
            }
        }

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public DateTime FechaCierre { get => fechaCierre; set => fechaCierre = value; }

        private string nombreCompleto;

        private DateTime fechaCierre;
    }
}
