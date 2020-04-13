using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Configuration;

namespace AccesoDatos
{
    public class UsuarioDatos
    {
        public bool Estado;


        public Usuario ConsultarLogin(string usu_identificacion, string usu_password, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;


            Usuario item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_LOGIN;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_identificacion";
                param.Value = usu_identificacion;
                cmd.Parameters.Add(param);


                param = cmd.CreateParameter();
                param.ParameterName = "@usu_password";
                param.Value = usu_password;
                cmd.Parameters.Add(param);


                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Usuario();

                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Usu_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Identificacion")))
                    {
                        item.Identificacion = dr.GetString(dr.GetOrdinal("Usu_Identificacion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Dispositivo")))
                    {
                        item.Dispositivo = dr.GetString(dr.GetOrdinal("Usu_Dispositivo"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Perfil")))
                    {
                        item.Perfil = dr.GetString(dr.GetOrdinal("Usu_Perfil"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Password")))
                    {
                        item.Password = dr.GetString(dr.GetOrdinal("Usu_Password"));
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

        public Usuario ConsultarUsuario(string usu_identificacion, string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;
            SqlParameter param;


            Usuario item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_USUARIO;
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
                    item = new Usuario();

                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Usu_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Identificacion")))
                    {
                        item.Identificacion = dr.GetString(dr.GetOrdinal("Usu_Identificacion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Nombre")))
                    {
                        item.NombreCompleto = dr.GetString(dr.GetOrdinal("Usu_Nombre"));
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

        public List<Usuario> ConsultarUsuariosEspeciale(string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;

            List<Usuario> list = new List<Usuario>();
            Usuario item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_USUARIOS_ESPECIALES;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;


                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Usuario();

                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Usu_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Identificacion")))
                    {
                        item.Identificacion = dr.GetString(dr.GetOrdinal("Usu_Identificacion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Dispositivo")))
                    {
                        item.Dispositivo = dr.GetString(dr.GetOrdinal("Usu_Dispositivo"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Perfil")))
                    {
                        item.Perfil = dr.GetString(dr.GetOrdinal("Usu_Perfil"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Password")))
                    {
                        item.Password = dr.GetString(dr.GetOrdinal("Usu_Password"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Nombre")))
                    {
                        item.NombreCompleto = dr.GetString(dr.GetOrdinal("Usu_Nombre"));
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
        public void ActualizarUsuario(Usuario usuario, string conexion)
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
                cmd.CommandText = Parametros.fu_SPU_ACTUALIZAR_USUARIO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                param = cmd.CreateParameter();
                param.ParameterName = "@usu_identificacion";
                param.Value = usuario.Identificacion;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_dispositivo";
                param.Value = usuario.Dispositivo;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_perfil";
                param.Value = usuario.Perfil;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_password";
                param.Value = usuario.Password;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_nombre";
                param.Value = usuario.NombreCompleto;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_fechacierre";
                param.Value = usuario.FechaCierre;
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

        public void RegistraDispositivo(string usu_identificacion, string dispositivo, string conexion)
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
                cmd.CommandText = Parametros.fu_SPU_REGISTRA_DISPOSITIVO;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                param = cmd.CreateParameter();
                param.ParameterName = "@usu_identificacion";
                param.Value = usu_identificacion;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@usu_dispositivo";
                param.Value = dispositivo;
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
        public List<Usuario> ConsultarUsuariosProcesar(string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;

            List<Usuario> list = new List<Usuario>();
            Usuario item = null;
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_USUARIOS_PROCESAR;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;


                cmd.ExecuteScalar();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new Usuario();

                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Id")))
                    {
                        item.Id = long.Parse(dr.GetValue(dr.GetOrdinal("Usu_Id")).ToString());
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Identificacion")))
                    {
                        item.Identificacion = dr.GetString(dr.GetOrdinal("Usu_Identificacion"));
                    }
                    if (!dr.IsDBNull(dr.GetOrdinal("Usu_Nombre")))
                    {
                        item.NombreCompleto = dr.GetString(dr.GetOrdinal("Usu_Nombre"));
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
        public void UsuariosProcesarCierre(string conexion)
        {

            SqlConnection Sqlcon = null;
            SqlCommand cmd = null;

            List<Usuario> list = new List<Usuario>();
            try
            {
                Parametros Parameter = new Parametros(); Sqlcon = new SqlConnection(conexion);
                Sqlcon.Open();
                cmd = Sqlcon.CreateCommand();
                cmd.CommandText = Parametros.fc_SPS_USUARIOS_CIERRE;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                cmd.ExecuteNonQuery();

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
        }
        public void UsuariosCierre()
        {
            try
            {
                AccesoDatos.UsuarioDatos UsuC = new AccesoDatos.UsuarioDatos();
                List<Entidades.Usuario> lista = UsuC.ConsultarUsuariosProcesar(ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                //eventLog1.WriteEntry("Se procesara " + lista.Count() + " Registros", EventLogEntryType.Information);
                foreach (var item in lista)
                {
                    ActualizaRanking(item.Identificacion);
                    //ServicioMercadeo.MercadeoClient CliM = new ServicioMercadeo.MercadeoClient();
                    //ServicioMercadeo.RealityCrucero ReaL = new ServicioMercadeo.RealityCrucero();
                    //ServicioMercadeo.RealityCruceroConsulta Realiti = new ServicioMercadeo.RealityCruceroConsulta();
                    ////ReaL.Request = new ServicioMercadeo.RealityCrucero1();
                    //string Ident = "00000000000" + item.Identificacion;
                    //string idenfificacionstring = item.Identificacion;
                    //Ident = Ident.Substring(Ident.Trim().Length - 11, Ident.Trim().Length - idenfificacionstring.Trim().Length); // "00000012345"; //"00003744866";
                    //Realiti.Cedula = Ident;
                    //Realiti.Campana = "201708";
                    //ReaL.Request = new AccesoDatos.ServicioMercadeo.RealityCruceroConsulta();
                    //ReaL.SesionId = Ident;
                    //ReaL.UsuarioApp = System.Configuration.ConfigurationManager.AppSettings["UsuarioSistema"];
                    //ReaL.PwdApp = System.Configuration.ConfigurationManager.AppSettings["PwdSistema"];
                    //ServicioMercadeo.RealityCrucero1 InformacionFacturacion = new ServicioMercadeo.RealityCrucero1();
                    //ReaL.Request = Realiti;
                    //InformacionFacturacion = CliM.ConsultarRealityCrucero(ReaL);

                    //AccesoDatos.RankingDatos R = new RankingDatos();
                    //R.InsertarRanking(long.Parse((InformacionFacturacion.Response.First().ValorPedidoCampana9 - InformacionFacturacion.Response.First().ValorDevolucionCampana9).ToString()), long.Parse((InformacionFacturacion.Response.First().ValorPedidoCampana10 - InformacionFacturacion.Response.First().ValorDevolucionCampana10).ToString()), item.Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                    //// cargar variables de session
                }
                UsuC.UsuariosProcesarCierre(ConfigurationManager.ConnectionStrings["Concurso"].ToString());
            }
            catch (SqlException ex)
            {
                string name = ex.Message;
                throw ex;
            }
            catch (Exception ex)
            {
                string name = ex.Message;
                throw ex;
            }
          
        }
        public bool ActualizaRanking(string Identificacion)
        {
            try
            {
                bool Retorno = true;
                Identificacion = (int.Parse(Identificacion)).ToString();
                AccesoDatos.CampañaDatos camp = new CampañaDatos();
                Entidades.Campana C = camp.ConsultarCampañaAbierta(System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                ServicioMercadeo.MercadeoClient CliM = new ServicioMercadeo.MercadeoClient();
                ServicioMercadeo.RealityCrucero ReaL = new ServicioMercadeo.RealityCrucero();
                ServicioMercadeo.RealityCruceroConsulta Realiti = new ServicioMercadeo.RealityCruceroConsulta();
                //ReaL.Request = new ServicioMercadeo.RealityCrucero1();
                string Ident = "00000000000" + Identificacion;
                string idenfificacionstring = Identificacion;
                Ident = Ident.Substring(Ident.Trim().Length - 11, Ident.Trim().Length - idenfificacionstring.Trim().Length); // "00000012345"; //"00003744866";
                Realiti.Cedula = Ident;
                Realiti.Campana = C.Descripcion; // "201708";
                ReaL.Request = new AccesoDatos.ServicioMercadeo.RealityCruceroConsulta();
                ReaL.SesionId = Ident;
                ReaL.UsuarioApp = System.Configuration.ConfigurationManager.AppSettings["UsuarioSistema"];
                ReaL.PwdApp = System.Configuration.ConfigurationManager.AppSettings["PwdSistema"];
                ServicioMercadeo.RealityCrucero1 InformacionFacturacion = new ServicioMercadeo.RealityCrucero1();
                ReaL.Request = Realiti;
                InformacionFacturacion = CliM.ConsultarRealityCrucero(ReaL);
                ServicioMercadeo.RealityCrucero1 InformacionFacturacionAnt = new ServicioMercadeo.RealityCrucero1();
                Realiti.Campana = campanaAnterior(C.Descripcion);
                ReaL.Request = Realiti;
                InformacionFacturacionAnt = CliM.ConsultarRealityCrucero(ReaL);
                AccesoDatos.RankingDatos R = new RankingDatos();

                List<Entidades.Campana> ListCamp = camp.ConsultarCampañasConcurso(C.IdConcurso, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());

                if (InformacionFacturacion.Response != null && InformacionFacturacionAnt.Response != null)
                {
                    AccesoDatos.RankingDatos Rank = new RankingDatos();
                    List<Ranking> ListRan = Rank.CrecimientoIndividualCampaña(Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                    if (C.Id == ListCamp.First().Id)
                    {
                        if ((InformacionFacturacionAnt.Response.First().ValorPedidoCampana8 - InformacionFacturacionAnt.Response.First().ValorDevolucionCampana8) < long.Parse(System.Configuration.ConfigurationManager.AppSettings["ValorMinimoConcurso"]))
                        {
                            Retorno = false;
                        }
                        else
                        {
                            R.InsertarRanking(long.Parse((InformacionFacturacionAnt.Response.First().ValorPedidoCampana8 - InformacionFacturacionAnt.Response.First().ValorDevolucionCampana8).ToString()), long.Parse((InformacionFacturacion.Response.First().ValorPedidoCampana8 - InformacionFacturacion.Response.First().ValorDevolucionCampana8).ToString()), Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                        }
                    }                   
                    else
                    {
                        R.InsertarRanking(long.Parse((InformacionFacturacionAnt.Response.First().ValorPedidoCampana8 - InformacionFacturacionAnt.Response.First().ValorDevolucionCampana8).ToString()), long.Parse((InformacionFacturacion.Response.First().ValorPedidoCampana8 - InformacionFacturacion.Response.First().ValorDevolucionCampana8).ToString()), Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                    }
                }
                else if (InformacionFacturacion.Response != null)
                {
                    R.InsertarRanking(0, long.Parse((InformacionFacturacion.Response.First().ValorPedidoCampana8 - InformacionFacturacion.Response.First().ValorDevolucionCampana8).ToString()), Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                }
                else if (InformacionFacturacionAnt.Response != null)
                {
                    if ((InformacionFacturacionAnt.Response.First().ValorPedidoCampana8 - InformacionFacturacionAnt.Response.First().ValorDevolucionCampana8) < long.Parse(System.Configuration.ConfigurationManager.AppSettings["ValorMinimoConcurso"]))
                    {
                        Retorno = false;
                    }
                    else
                    {
                        R.InsertarRanking(long.Parse((InformacionFacturacionAnt.Response.First().ValorPedidoCampana8 - InformacionFacturacionAnt.Response.First().ValorDevolucionCampana8).ToString()), 0, Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                    }
                }
                else
                {
                    Retorno = false;
                    //R.InsertarRanking(0, 0, Identificacion, System.Configuration.ConfigurationManager.ConnectionStrings["Concurso"].ToString());
                }
                return Retorno;
            }
            catch (SqlException ex)
            {
                string name = ex.Message;
                throw ex;
            }
            catch (Exception ex)
            {
                string name = ex.Message;
                throw ex;
            }

        }
        private string campanaAnterior(string campanaActual)
        {
            if (int.Parse(campanaActual.Substring(4,2)) > 1)
            {
                return (int.Parse(campanaActual) - 1).ToString();
            }
            else
            {
                return (int.Parse(campanaActual.Substring(0,4)) - 1).ToString() + "12";
            }
            
            //return (int.Parse(campanaActual) - 1).ToString();
        }
    }
}
