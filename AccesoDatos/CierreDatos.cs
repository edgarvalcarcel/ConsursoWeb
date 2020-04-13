using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;


namespace AccesoDatos
{
    public class CierreDatos
    {
        public List<Cierre> ConsultarCierres(string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;


            List<Cierre> list = new List<Cierre>();
            Cierre item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CIERRE;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Cierre();

                    if (!dr.IsDBNull(dr.GetOrdinal("Cie_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Cie_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Cie_FechaInicio")))
                    {
                        item.FechaInicio = (DateTime)dr.GetDateTime(dr.GetOrdinal("Cie_FechaInicio"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Cie_Intentos")))
                    {
                        item.Intentos = int.Parse(dr.GetValue(dr.GetOrdinal("Cie_Intentos")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Cie_Estado")))
                    {
                        item.Estado = dr.GetString(dr.GetOrdinal("Cie_Estado"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Titulo")))
                    {
                        item.TituloConcurso = dr.GetString(dr.GetOrdinal("Conc_Titulo"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Descripcion")))
                    {
                        item.DescripcionCampaña = dr.GetString(dr.GetOrdinal("Camp_Descripcion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Cie_FechaFin")))
                    {
                        item.FechaFin = (DateTime)dr.GetDateTime(dr.GetOrdinal("Cie_FechaFin"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Id")))
                    {
                        item.IdCampaña = long.Parse(dr.GetValue(dr.GetOrdinal("Camp_Id")).ToString());
                    }
                    list.Add(item);
                }

                dr.Close();
                dr.Dispose();
            }
            catch (SqlException ex)
            {
                string name = this.GetType().FullName.ToString();
                System.Reflection.MethodBase currentMethod = System.Reflection.MethodBase.GetCurrentMethod();
                throw ex;
            }
            catch (Exception ex)
            {
                string name = this.GetType().FullName.ToString();
                System.Reflection.MethodBase currentMethod = System.Reflection.MethodBase.GetCurrentMethod();
                throw ex;
            }
            finally
            {
                if (Sqlcon != null)
                {
                    Sqlcon.Close();
                    Sqlcon.Dispose();
                }
                if (cmd != null)

                    cmd.Dispose();
            }

            return list;
        }
    }
}
