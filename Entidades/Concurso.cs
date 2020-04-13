using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concurso
    {
        private long conc_id;
        private string conc_titulo;
        private int conc_numeroCampanas;
        private string conc_descripcionPremio;
        private string conc_estado;
        private string conc_telefono;
        private string conc_mail;
        private byte[] conc_imageWeb;
        private byte[] conc_imageMovil;
        private byte[] conc_imageAvatar;
        private byte[] conc_imageAplicacion;


        public long Id
        {
            get
            {
                return conc_id;
            }
            set
            {
                conc_id = value;
            }
        }

        public string Titulo
        {
            get
            {
                return conc_titulo;
            }
            set
            {
                conc_titulo = value;
            }
        }
        public int NumeroCampañas
        {
            get
            {
                return conc_numeroCampanas;
            }
            set
            {
                conc_numeroCampanas = value;
            }
        }

        public string DescripcionPremio
        {
            get
            {
                return conc_descripcionPremio;
            }
            set
            {
                conc_descripcionPremio = value;
            }
        }

        public string Estado
        {
            get
            {
                return conc_estado;
            }
            set
            {
                conc_estado = value;
            }
        }

        public string Telefono
        {
            get
            {
                return conc_telefono;
            }
            set
            {
                conc_telefono = value;
            }
        }

        public string Mail
        {
            get
            {
                return conc_mail;
            }
            set
            {
                conc_mail = value;
            }
        }

        public byte[] ImageWeb
        {
            get
            {
                return conc_imageWeb;
            }
            set
            {
                conc_imageWeb = value;
            }
        }

        public byte[] ImageMovil
        {
            get
            {
                return conc_imageMovil;
            }
            set
            {
                conc_imageMovil = value;
            }
        }

        public byte[] ImageAvatar
        {
            get
            {
                return conc_imageAvatar;
            }
            set
            {
                conc_imageAvatar = value;
            }
        }

        public byte[] ImageAplicacion
        {
            get
            {
                return conc_imageAplicacion;
            }
            set
            {
                conc_imageAplicacion = value;
            }
        }
    }
}
