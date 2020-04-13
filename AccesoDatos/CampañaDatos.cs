using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
namespace AccesoDatos
{
    public class CampañaDatos
    {
        public bool Estado;
        public void ActualizarCampaña(Campana campaña, string conexion)
        {

            this.Estado = false;
            object retval = null;
            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlTransaction tran = null;
            SqlParameter param;

            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();

                tran = Sqlcon.BeginTransaction();

                cmd = Sqlcon.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = Parametros.fu_SPU_ACTUALIZAR_CAMPAÑA;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                param = cmd.CreateParameter();
                param.ParameterName = "@camp_id";
                param.Value = campaña.Id;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@camp_descripcion";
                param.Value = campaña.Descripcion;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@camp_porcentajeCrecimiento";
                param.Value = campaña.PorcentajeCrecimiento;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@camp_estado";
                param.Value = campaña.Estado;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = campaña.IdConcurso;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@camp_inicio";
                param.Value = campaña.Inicio;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@camp_fin";
                param.Value = campaña.Fin;
                cmd.Parameters.Add(param);

                retval = cmd.ExecuteScalar();

                tran.Commit();

                this.Estado = true;
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
                    tran.Dispose();
                }
                if (cmd != null)

                    cmd.Dispose();
            }


        }
        public List<Campana> ConsultarCampaña( string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            


            List < Campana >  lista = new List<Campana>();
            Campana item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CAMPAÑA;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    item = new Campana();

                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Camp_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Descripcion")))
                    {
                        item.Descripcion = dr.GetString(dr.GetOrdinal("Camp_Descripcion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_PorcentajeCrecimiento")))
                    {
                        item.PorcentajeCrecimiento = decimal.Parse(dr.GetValue(dr.GetOrdinal("Camp_PorcentajeCrecimiento")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Estado")))
                    {
                        item.Estado = dr.GetString(dr.GetOrdinal("Camp_Estado"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.IdConcurso = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Inicio")))
                    {
                        item.Inicio = (DateTime)dr.GetDateTime(dr.GetOrdinal("Camp_Inicio"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Fin")))
                    {
                        item.Fin = (DateTime)dr.GetDateTime(dr.GetOrdinal("Camp_Fin"));
                    }

                    lista.Add(item);
                    
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

            return lista ;
        }

        public List<Campana> ConsultarCampañasConcurso(long idConcurso, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;


            List<Campana> lista = new List<Campana>();
            Campana item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CAMPAÑAS_CONCURSO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@idConcurso";
                param.Value = idConcurso;
                cmd.Parameters.Add(param);


                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Campana();

                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Camp_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Descripcion")))
                    {
                        item.Descripcion = dr.GetString(dr.GetOrdinal("Camp_Descripcion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_PorcentajeCrecimiento")))
                    {
                        item.PorcentajeCrecimiento = decimal.Parse(dr.GetValue(dr.GetOrdinal("Camp_PorcentajeCrecimiento")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Estado")))
                    {
                        item.Estado = dr.GetString(dr.GetOrdinal("Camp_Estado"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.IdConcurso = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Inicio")))
                    {
                        item.Inicio = (DateTime)dr.GetDateTime(dr.GetOrdinal("Camp_Inicio"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Fin")))
                    {
                        item.Fin = (DateTime)dr.GetDateTime(dr.GetOrdinal("Camp_Fin"));
                    }

                    lista.Add(item);

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

            return lista;
        }


        public Campana ConsultarCampañaAbierta( string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;


            Campana item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CAMPAÑA_ABIERTA;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Campana();

                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Camp_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Descripcion")))
                    {
                        item.Descripcion = dr.GetString(dr.GetOrdinal("Camp_Descripcion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_PorcentajeCrecimiento")))
                    {
                        item.PorcentajeCrecimiento = decimal.Parse(dr.GetValue(dr.GetOrdinal("Camp_PorcentajeCrecimiento")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Estado")))
                    {
                        item.Estado = dr.GetString(dr.GetOrdinal("Camp_Estado"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.IdConcurso = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Inicio")))
                    {
                        item.Inicio = (DateTime)dr.GetDateTime(dr.GetOrdinal("Camp_Inicio"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Fin")))
                    {
                        item.Fin = (DateTime)dr.GetDateTime(dr.GetOrdinal("Camp_Fin"));
                    }


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

            return item;
        }


    }
}
