using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ranking
    {

        private long usu_id;
        private long camp_id;
        private string camp_descripcion;
        private decimal rank_porcentajeCrecimiento;
        private string usu_identificacion;
        private int rank_salvavidas;
        private long rank_valorActual;
        private long rank_meta;
        private decimal rank_porcentajeActual;
        private long rank_valorAnterior;
        private long rank_posicion;
        private string rank_aproboCampana;
        private string usu_nombre;

        public long IdUsuario
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

        public string IdentificacionUsuario
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
        public long Posicion
        {
            get
            {
                return rank_posicion;
            }
            set
            {
                rank_posicion = value;
            }
        }

        public long IdCampaña
        {
            get
            {
                return camp_id;
            }
            set
            {
                camp_id = value;
            }
        }

        public decimal PorcentajeCrecimiento
        {
            get
            {
                return rank_porcentajeCrecimiento;
            }
            set
            {
                rank_porcentajeCrecimiento = value;
            }
        }

        public int Salvavidas
        {
            get
            {
                return rank_salvavidas;
            }
            set
            {
                rank_salvavidas = value;
            }
        }

        public long ValorActual
        {
            get
            {
                return rank_valorActual;
            }
            set
            {
                rank_valorActual = value;
            }
        }

        public long Meta
        {
            get
            {
                return rank_meta;
            }
            set
            {
                rank_meta = value;
            }
        }

        public decimal PorcentajeActual
        {
            get
            {
                return rank_porcentajeActual;
            }
            set
            {
                rank_porcentajeActual = value;
            }
        }

        public long ValorAnterior
        {
            get
            {
                return rank_valorAnterior;
            }
            set
            {
                rank_valorAnterior = value;
            }
        }

        public string AproboCampana
        {
            get
            {
                return rank_aproboCampana;
            }
            set
            {
                rank_aproboCampana = value;
            }
        }
        public string NombreUsuario
        {
            get
            {
                return usu_nombre;
            }
            set
            {
                usu_nombre = value;
            }
        }

        public string DescripcionCampaña
        {
            get
            {
                return camp_descripcion;
            }
            set
            {
                camp_descripcion = value;
            }
        }
    }
}
