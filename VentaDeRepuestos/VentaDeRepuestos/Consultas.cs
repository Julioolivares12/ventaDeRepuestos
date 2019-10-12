using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeRepuestos.Helpers;
using VentaDeRepuestos.Modelos;

namespace VentaDeRepuestos
{
    class Consultas
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection">objeto de la clase SqlConnection que devuelve la conexion con la bd</param>
        /// <param name="commandText"></param>
        /// <param name="commandType">hay tres tipos de comando StoreProcedure,Text,TableDirect tableDirect es solo para OLE DB </param>
        /// <param name="parameters">parametros de sql</param>
        /// <returns>retorna la cantidad de filas afectadas</returns>
        public static async Task<Int32> ExecuteNonQuery(SqlConnection connection, string commandText
            , CommandType commandType, params SqlParameter[] parameters)
        {
            using (connection)
            {
                using (SqlCommand sqlCommand = new SqlCommand(commandText, connection))
                {
                    sqlCommand.CommandType = commandType;
                    sqlCommand.Parameters.AddRange(parameters);
                    connection.Open();

                    return await sqlCommand.ExecuteNonQueryAsync();
                }
            }
        }

        /// <summary>
        /// metodo para hacer login
        /// </summary>
        /// <param name="email">email del usuario</param>
        /// <param name="password">password del usuario</param>
        /// <returns></returns>
        public static async Task<SqlDataReader> loginAsync(string email, string password)
        {
            var con = await Conexion.conectarAsync();

            using (SqlCommand cmd = new SqlCommand(null, con))
            {
                cmd.CommandText = $"Select u.EMAIL ,u.PASS , p.NOMBRE from USUARIOS as u inner join PERFIL as p on u.ID_PERFIL=p.ID_PERFIL where u.EMAIL='{email}' and u.PASS='{password}' ";

                return await cmd.ExecuteReaderAsync();
            }
        }

        /// <summary>
        /// ejecuta un excalar para devolver un solo objeto
        /// </summary>
        /// <param name="comandText"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns>Objet</returns>
        public static async Task<Object> executeScalar(string comandText, CommandType commandType, params SqlParameter[] parameters)
        {

            using (var con = await Conexion.conectarAsync())
            {
                using (var comando = new SqlCommand(comandText, con))
                {
                    comando.CommandType = commandType;
                    comando.Parameters.AddRange(parameters);
                    con.Open();
                    return await comando.ExecuteScalarAsync();
                }
            }
        }

        /// <summary>
        /// ejecuta el comando con query y retorna un reader
        /// </summary>
        /// <param name="commandText">query</param>
        /// <param name="commandType">tipo de comando</param>
        /// <param name="parameters">parametros de la consulta</param>
        /// <returns></returns>
        public static async Task<SqlDataReader> ExecuteReaderAsync(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var con = await Conexion.conectarAsync())
            {
                using (var cmd = new SqlCommand(commandText, con))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    await con.OpenAsync();

                    return await cmd.ExecuteReaderAsync();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var con  = Conexion.conectar())
            {
                using (var cmd = new SqlCommand(commandText, con))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    con.Open();
                    return cmd.ExecuteReader();
                }
            }
        }
        /// <summary>
        /// metodo para insertar empleados en la bd
        /// </summary>
        /// <param name="idPerfil"></param>
        /// <param name="idCargo"></param>
        /// <param name="primerNombre"></param>
        /// <param name="segundoNombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNac"></param>
        /// <param name="sexo"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        /// <returns>retorna la cantidad de filas afectadas</returns>
        public static async Task<Int32> crearEpleadoAsync(Usuario usuario)
        {
            var query = "insert into USUARIOS (ID_CARGO,ID_PERFIL,PRIMERNOMBRE," +
                "SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,DIRECCION,TELEFONO,FECHANAC,SEXO,ESTADO_CIVIL,EMAIL,PASS)" +
                " VALUES (@ID_CARGO,@ID_PERFIL,@PRIMERNOMBRE,@SEGUNDONOMBRE,@PRIMERAPELLIDO,@SEGUNDOAPELLIDO,@DIRECCION,@TELEFONO,CONVERT(DATETIME,@FECHANAC),@SEXO,@ESTADO_CIVIL,@EMAIL,@PASS)";

            //parametros para la insercion de datos
            //se hacen las letras en minusculas
            var pass = usuario.PrimerNombre.ToLower() + usuario.PrimerApellido.ToLower() + "123";
            var passE = Encriptar.encriptarPassword(pass);
            var parameteridCargo = new SqlParameter("@ID_CARGO",usuario.ID_CARGO);
            var parameteridPerfil = new SqlParameter("@ID_PERFIL", usuario.ID_PERFIL);
            var parameterPrimerNombre = new SqlParameter("@PRIMERNOMBRE",usuario.PrimerNombre);
            var parameterSegundoNombre = new SqlParameter("@SEGUNDONOMBRE",usuario.SegundoNombre);
            var parameterPrimerApellido = new SqlParameter("@PRIMERAPELLIDO",usuario.PrimerApellido);
            var parameterSegundoApellido = new SqlParameter("@SEGUNDOAPELLIDO",usuario.SegundoApellido);
            var parameterDireccion = new SqlParameter("@DIRECCION",usuario.Direccion);
            var parameterTelefono = new SqlParameter("@TELEFONO",usuario.Telefono);
            var parameterFechaNac = new SqlParameter("@FECHANAC",usuario.FechaNac);
            var parameterSexo = new SqlParameter("@SEXO",usuario.Sexo);
            var parameterEstado = new SqlParameter("@ESTADO_CIVIL",usuario.EstadoCivil);
            var parameterEmail = new SqlParameter("@EMAIL",usuario.Email);
            var parameterPass = new SqlParameter("@PASS",passE);

            
            var con = await Conexion.conectarAsync();
            var rows = await ExecuteNonQuery(con,query,CommandType.Text,parameteridCargo
                ,parameteridPerfil,parameterPrimerNombre,parameterSegundoNombre,parameterPrimerApellido
                ,parameterSegundoApellido,parameterDireccion,parameterTelefono,parameterFechaNac,parameterSexo,parameterEstado,parameterEmail,parameterPass);

                return rows;
        }

        public static async Task<SqlDataReader> getPerfilesAsync()
        {
            using (var con = await Conexion.conectarAsync())
            {
                var s = "select ID_PERFIL,NOMBRE from PERFIL";
                using (var cmd = new SqlCommand(s,con))
                {
                    await con.OpenAsync();
                    return await cmd.ExecuteReaderAsync();
                }
            }
        }


        public static DataTable getCargos()
        {
            using (var con = Conexion.conectar())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_CARGO,NOMBRE FROM CARGOS", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable getPerfiles()
        {
            using (var con = Conexion.conectar())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_PERFIL,NOMBRE FROM PERFIL", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable getEmpleados()
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM USUARIOS", con))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }
    }
}
