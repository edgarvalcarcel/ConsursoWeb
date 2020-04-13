using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cierre
    {
        private long cie_id;
        private DateTime cie_fechaInicio;
        private string cie_estado;
        private long camp_id;
        private DateTime cie_fechaFin;
        private int cie_intentos;
        private string conc_titulo;
        private string camp_descripcion;


        public string TituloConcurso
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
        public long Id
        {
            get
            {
                return cie_id;
            }
            set
            {
                cie_id = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return cie_fechaInicio;
            }
            set
            {
                cie_fechaInicio = value;
            }
        }

        public string Estado
        {
            get
            {
                return cie_estado;
            }
            set
            {
                cie_estado = value;
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

        public DateTime FechaFin
        {
            get
            {
                return cie_fechaFin;
            }
            set
            {
                cie_fechaFin = value;
            }
        }

        public int Intentos
        {
            get
            {
                return cie_intentos;
            }
            set
            {
                cie_intentos = value;
            }
        }
    }
}
