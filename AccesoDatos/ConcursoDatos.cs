using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace AccesoDatos
{
    public class ConcursoDatos
    {
        public bool Estado;

        public void ActualizarConcurso(Concurso concurso, string conexion)
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

                tran= Sqlcon.BeginTransaction();

                cmd = Sqlcon.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = Parametros.fu_SPU_ACTUALIZAR_CONCURSO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = concurso.Id;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_titulo";
                param.Value = concurso.Titulo;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_numeroCampanas";
                param.Value = concurso.NumeroCampañas;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_descripcionPremio";
                param.Value = concurso.DescripcionPremio;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_estado";
                param.Value = concurso.Estado;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_telefono";
                param.Value = concurso.Telefono;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_mail";
                param.Value = concurso.Mail;
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

        public List<Concurso> ConsultarTodosConcursos(string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;


            List<Concurso> list = new List<Concurso>();
            Concurso item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CONCURSO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Concurso();

                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Titulo")))
                    {
                        item.Titulo = dr.GetString(dr.GetOrdinal("Conc_Titulo"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_NumeroCampanas")))
                    {
                        item.NumeroCampañas = int.Parse(dr.GetValue(dr.GetOrdinal("Conc_NumeroCampanas")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_DescripcionPremio")))
                    {
                        item.DescripcionPremio = dr.GetString(dr.GetOrdinal("Conc_DescripcionPremio"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Estado")))
                    {
                        item.Estado = dr.GetString(dr.GetOrdinal("Conc_Estado"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Telefono")))
                    {
                        item.Telefono = dr.GetString(dr.GetOrdinal("Conc_Telefono"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Mail")))
                    {
                        item.Mail = dr.GetString(dr.GetOrdinal("Conc_Mail"));
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

        public List<Concurso> ConsultarConcurso( string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            

            List < Concurso > list = new List<Concurso>();
            Concurso item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CONCURSO_INICIADO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Concurso();

                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Titulo")))
                    {
                        item.Titulo = dr.GetString(dr.GetOrdinal("Conc_Titulo"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_NumeroCampanas")))
                    {
                        item.NumeroCampañas = int.Parse(dr.GetValue(dr.GetOrdinal("Conc_NumeroCampanas")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_DescripcionPremio")))
                    {
                        item.DescripcionPremio = dr.GetString(dr.GetOrdinal("Conc_DescripcionPremio"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Estado")))
                    {
                        item.Estado = dr.GetString(dr.GetOrdinal("Conc_Estado"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Telefono")))
                    {
                        item.Telefono = dr.GetString(dr.GetOrdinal("Conc_Telefono"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Mail")))
                    {
                        item.Mail = dr.GetString(dr.GetOrdinal("Conc_Mail"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_ImageWeb")))
                    {
                        item.ImageWeb = (byte[])dr["Conc_ImageWeb"];
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_ImageMovil")))
                    {
                        item.ImageMovil = (byte[])dr["Conc_ImageMovil"];
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_ImageAvatar")))
                    {
                        item.ImageAvatar = (byte[])dr["Conc_ImageAvatar"];
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_ImageAplicacion")))
                    {
                        item.ImageAplicacion = (byte[])dr["Conc_ImageAplicacion"];
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

        public Concurso ConsultarConcursoIniciado( string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            
 
            Concurso item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CONCURSO_INICIADO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

            
                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Concurso();

                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Titulo")))
                    {
                        item.Titulo = dr.GetString(dr.GetOrdinal("Conc_Titulo"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_NumeroCampanas")))
                    {
                        item.NumeroCampañas = int.Parse(dr.GetValue(dr.GetOrdinal("Conc_NumeroCampanas")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_DescripcionPremio")))
                    {
                        item.DescripcionPremio = dr.GetString(dr.GetOrdinal("Conc_DescripcionPremio"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Estado")))
                    {
                        item.Estado = dr.GetString(dr.GetOrdinal("Conc_Estado"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Telefono")))
                    {
                        item.Telefono = dr.GetString(dr.GetOrdinal("Conc_Telefono"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Mail")))
                    {
                        item.Mail = dr.GetString(dr.GetOrdinal("Conc_Mail"));
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

        public Concurso ConsultarConcursoEspecifico(long idConcusro,string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;


            Concurso item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_CONCURSO_ESPECIFICO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = idConcusro;
                cmd.Parameters.Add(param);

                

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Concurso();

                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Titulo")))
                    {
                        item.Titulo = dr.GetString(dr.GetOrdinal("Conc_Titulo"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_NumeroCampanas")))
                    {
                        item.NumeroCampañas = int.Parse(dr.GetValue(dr.GetOrdinal("Conc_NumeroCampanas")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_DescripcionPremio")))
                    {
                        item.DescripcionPremio = dr.GetString(dr.GetOrdinal("Conc_DescripcionPremio"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Estado")))
                    {
                        item.Estado = dr.GetString(dr.GetOrdinal("Conc_Estado"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Telefono")))
                    {
                        item.Telefono = dr.GetString(dr.GetOrdinal("Conc_Telefono"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Mail")))
                    {
                        item.Mail = dr.GetString(dr.GetOrdinal("Conc_Mail"));
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


        public void ActualizarImagenWeb(long conc_id,byte[] conc_imageWeb, string conexion)
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
                cmd.CommandText = Parametros.fu_SPU_ACTUALIZAR_IMAGEN_WEB;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_imageWeb";
                param.Value = conc_imageWeb;
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
        public Concurso ConsultarImageWeb(long conc_id, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;


            Concurso item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_IMAGEN_WEB;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Concurso();

                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_ImageWeb")))
                    {
                        item.ImageWeb = (byte[])dr["Conc_ImageWeb"];
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

        public void ActualizarImagenMovil(long conc_id, byte[] conc_imageMovil, string conexion)
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
                cmd.CommandText = Parametros.fu_SPU_ACTUALIZAR_IMAGEN_MOVIL;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_imageMovil";
                param.Value = conc_imageMovil;
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
        public Concurso ConsultarImageMovil(long conc_id, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;


            Concurso item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_IMAGEN_MOVIL;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Concurso();

                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_ImageMovil")))
                    {
                        item.ImageMovil = (byte[])dr["Conc_ImageMovil"];
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



        public void ActualizarImagenAvatar(long conc_id, byte[] conc_imageAvatar, string conexion)
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
                cmd.CommandText = Parametros.fu_SPU_ACTUALIZAR_IMAGEN_AVATAR;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_imageAvatar";
                param.Value = conc_imageAvatar;
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
        public Concurso ConsultarImageAvatar(long conc_id, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;


            Concurso item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_IMAGEN_AVATAR;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Concurso();

                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_ImageAvatar")))
                    {
                        item.ImageAvatar = (byte[])dr["Conc_ImageAvatar"];
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



        public void ActualizarImagenAplicacion(long conc_id, byte[] conc_imageAplicacion, string conexion)
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
                cmd.CommandText = Parametros.fu_SPU_ACTUALIZAR_IMAGEN_APLICACION;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_imageAplicacion";
                param.Value = conc_imageAplicacion;
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
        public Concurso ConsultarImageAplicacion(long conc_id, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;


            Concurso item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_IMAGEN_APLICACION;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@conc_id";
                param.Value = conc_id;
                cmd.Parameters.Add(param);

                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Concurso();

                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Conc_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Conc_ImageAplicacion")))
                    {
                        item.ImageAplicacion = (byte[])dr["Conc_ImageAplicacion"];
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
