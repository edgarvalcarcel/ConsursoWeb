using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace AccesoDatos
{
    public class RankingDatos
    {
        private bool Estado;
        public List<Ranking> TopCinco(string usu_identificacion, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;

            List<Ranking> list = new List<Ranking>();
            Ranking item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_TOP_CINCO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_identificacion";
                param.Value = usu_identificacion;
                cmd.Parameters.Add(param);

                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Ranking();

                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Id")))
                    {
                        item.IdUsuario = long.Parse(dr.GetValue(dr.GetOrdinal("Usu_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Nombre")))
                    {
                        item.NombreUsuario = dr.GetString(dr.GetOrdinal("Usu_Nombre"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Identificacion")))
                    {
                        item.IdentificacionUsuario = dr.GetValue(dr.GetOrdinal("Usu_Identificacion")).ToString();
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Id")))
                    {
                        item.IdCampaña = long.Parse(dr.GetValue(dr.GetOrdinal("Camp_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_PorcentajeCrecimiento")))
                    {
                        item.PorcentajeCrecimiento = decimal.Parse(dr.GetValue(dr.GetOrdinal("Rank_PorcentajeCrecimiento")).ToString());
                    }
                    //if (!dr.IsDBNull(dr.GetOrdinal("Rank_Salvavidas")))
                    //{
                    //    item.Salvavidas = int.Parse(dr.GetValue(dr.GetOrdinal("Rank_Salvavidas")).ToString());
                    //}
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_ValorActual")))
                    {
                        item.ValorActual = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_ValorActual")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Meta")))
                    {
                        item.Meta = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_Meta")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_PorcentajeActual")))
                    {
                        item.PorcentajeActual = decimal.Parse(dr.GetValue(dr.GetOrdinal("Rank_PorcentajeActual")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_ValorAnterior")))
                    {
                        item.ValorAnterior = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_ValorAnterior")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Posicion")))
                    {
                        item.Posicion = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_Posicion")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_AproboCampana")))
                    {
                        item.AproboCampana = dr.GetString(dr.GetOrdinal("Rank_AproboCampana"));
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

        public Ranking PorcentajeActual(string usu_identificacion, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;

            Ranking item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_PORCENTAJE_ACTUAL;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_identificacion";
                param.Value = usu_identificacion;
                cmd.Parameters.Add(param);

                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                item = new Ranking();

                while (dr.Read())
                {

                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Id")))
                    {
                        item.IdUsuario = long.Parse(dr.GetValue(dr.GetOrdinal("Usu_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Nombre")))
                    {
                        item.NombreUsuario = dr.GetString(dr.GetOrdinal("Usu_Nombre"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Identificacion")))
                    {
                        item.IdentificacionUsuario = dr.GetValue(dr.GetOrdinal("Usu_Identificacion")).ToString();
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Id")))
                    {
                        item.IdCampaña = long.Parse(dr.GetValue(dr.GetOrdinal("Camp_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_PorcentajeCrecimiento")))
                    {
                        item.PorcentajeCrecimiento = decimal.Parse(dr.GetValue(dr.GetOrdinal("Rank_PorcentajeCrecimiento")).ToString());
                    }
                    //if (!dr.IsDBNull(dr.GetOrdinal("Rank_Salvavidas")))
                    //{
                    //    item.Salvavidas = int.Parse(dr.GetValue(dr.GetOrdinal("Rank_Salvavidas")).ToString());
                    //}
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_ValorActual")))
                    {
                        item.ValorActual = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_ValorActual")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Meta")))
                    {
                        item.Meta = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_Meta")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_PorcentajeActual")))
                    {
                        item.PorcentajeActual = decimal.Parse(dr.GetValue(dr.GetOrdinal("Rank_PorcentajeActual")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_ValorAnterior")))
                    {
                        item.ValorAnterior = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_ValorAnterior")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Posicion")))
                    {
                        item.Posicion = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_Posicion")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_AproboCampana")))
                    {
                        item.AproboCampana = dr.GetString(dr.GetOrdinal("Rank_AproboCampana"));
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

        public List<Ranking> CrecimientoIndividualCampaña(string usu_identificacion, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;

            List<Ranking> list = new List<Ranking>();
            Ranking item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CRECIMIENTO_INDIVIDUAL_CAMPANAS;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_identificacion";
                param.Value = usu_identificacion;
                cmd.Parameters.Add(param);

                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Ranking();

                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Identificacion")))
                    {
                        item.IdentificacionUsuario = dr.GetValue(dr.GetOrdinal("Usu_Identificacion")).ToString();
                    }
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_PorcentajeActual")))
                    {
                        item.PorcentajeActual = decimal.Parse(dr.GetValue(dr.GetOrdinal("Rank_PorcentajeActual")).ToString());
                    }
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Posicion")))
                    {
                        item.Posicion = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_Posicion")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Descripcion")))
                    {
                        item.DescripcionCampaña = dr.GetString(dr.GetOrdinal("Camp_Descripcion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_AproboCampana")))
                    {
                        item.AproboCampana = dr.GetString(dr.GetOrdinal("Rank_AproboCampana"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Salvavidas")))
                    {
                        item.Salvavidas = int.Parse(dr.GetValue(dr.GetOrdinal("Rank_Salvavidas")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Meta")))
                    {
                        item.Meta = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_Meta")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Rank_ValorActual")))
                    {
                        item.ValorActual = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_ValorActual")).ToString());
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

        public DataTable DescargarRanking(long camp_id,long conc_id,string conexion)
        {
            SqlDataReader dr;
            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;
            DataTable dt = new DataTable();
            //List<Ranking> list = new List<Ranking>();
            //Ranking item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_DESCARGAR_RANKING;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@camp_id";
                param.Value = camp_id;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                SqlDataAdapter da = new SqlDataAdapter();
                dr = cmd.ExecuteReader();

                dt.Load(dr);
                //while (dr.Read())
                //{
                //    item = new Ranking();
                //    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Id")))
                //    {
                //        item.IdUsuario = long.Parse(dr.GetValue(dr.GetOrdinal("Usu_Id")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Identificacion")))
                //    {
                //        item.IdentificacionUsuario = long.Parse(dr.GetValue(dr.GetOrdinal("Usu_Identificacion")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Camp_Id")))
                //    {
                //        item.IdCampaña = long.Parse(dr.GetValue(dr.GetOrdinal("Camp_Id")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Rank_PorcentajeCrecimiento")))
                //    {
                //        item.PorcentajeCrecimiento = decimal.Parse(dr.GetValue(dr.GetOrdinal("Rank_PorcentajeCrecimiento")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Salvavidas")))
                //    {
                //        item.Salvavidas = int.Parse(dr.GetValue(dr.GetOrdinal("Rank_Salvavidas")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Rank_ValorActual")))
                //    {
                //        item.ValorActual = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_ValorActual")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Meta")))
                //    {
                //        item.Meta = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_Meta")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Rank_PorcentajeActual")))
                //    {
                //        item.PorcentajeActual = decimal.Parse(dr.GetValue(dr.GetOrdinal("Rank_PorcentajeActual")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Rank_ValorAnterior")))
                //    {
                //        item.ValorAnterior = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_ValorAnterior")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Rank_Posicion")))
                //    {
                //        item.Posicion = long.Parse(dr.GetValue(dr.GetOrdinal("Rank_Posicion")).ToString());
                //    }
                //    if (!dr.IsDBNull(dr.GetOrdinal("Rank_AproboCampana")))
                //    {
                //        item.AproboCampana = dr.GetString(dr.GetOrdinal("Rank_AproboCampana"));
                //    }

                //    list.Add(item);
                //}

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

            return dt;
        }

        public void InsertarRanking(long rank_valorAnterior, long rank_valorActual, string usu_identificacion, string conexion)
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
                cmd.CommandText = Parametros.fi_SPI_INSERTAR_RANKING;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_identificacion";
                param.Value = usu_identificacion;
                cmd.Parameters.Add(param);
                
                param = cmd.CreateParameter();
                param.ParameterName = "@rank_valorAnterior";
                param.Value = rank_valorAnterior;
                cmd.Parameters.Add(param);
                
                param = cmd.CreateParameter();
                param.ParameterName = "@rank_valorActual";
                param.Value = rank_valorActual;
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
    }
}
