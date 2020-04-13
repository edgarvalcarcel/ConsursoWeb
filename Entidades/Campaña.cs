using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Campana
    {
        private long camp_id;
        private string camp_descripcion;
        private decimal camp_porcentajeCrecimiento;
        private string camp_estado;
        private long conc_id;
        private DateTime camp_inicio;
        private DateTime camp_fin;


        public long Id
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

        public string Descripcion
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

        public decimal PorcentajeCrecimiento
        {
            get
            {
                return camp_porcentajeCrecimiento;
            }
            set
            {
                camp_porcentajeCrecimiento = value;
            }
        }

        public string Estado
        {
            get
            {
                return camp_estado;
            }
            set
            {
                camp_estado = value;
            }
        }

        public long IdConcurso
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

        public DateTime Inicio
        {
            get
            {
                return camp_inicio;
            }
            set
            {
                camp_inicio = value;
            }
        }

        public DateTime Fin
        {
            get
            {
                return camp_fin;
            }
            set
            {
                camp_fin = value;
            }
        }
    }
}
