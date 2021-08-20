using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class ServicioUsuarios
    {

        public SqlConnection connection;

        public ServicioUsuarios(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        #region Metodos_CRUD
        public bool Agregar(Usuarios item)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Usuarios(Nombre, Apellido, Correo, Nombre_Usuarios, Contraseña, TipoUsuario) values(@nombre, @apellido, @correo, @nombre_usuario, @contraseña, @tipousuario)", connection);

            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", item.Apellido);
            sqlCommand.Parameters.AddWithValue("@correo", item.Correo);
            sqlCommand.Parameters.AddWithValue("@nombre_usuario", item.Nombre_Usuario);
            sqlCommand.Parameters.AddWithValue("@contraseña", item.Contraseña);
            sqlCommand.Parameters.AddWithValue("@tipousuario", item.TipoUsuario);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Editar(Usuarios item)
        {
            SqlCommand sqlCommand = new SqlCommand("update Usuarios set Nombre = @nombre, Apellido = @apellido, Correo = @correo, Nombre_Usuario = @nombre_usuario, Contraseña = @contraseña, TipoUsuario = @tipousuario where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", item.Id);
            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", item.Apellido);
            sqlCommand.Parameters.AddWithValue("@correo", item.Correo);
            sqlCommand.Parameters.AddWithValue("@nombre_usuario", item.Nombre_Usuario);
            sqlCommand.Parameters.AddWithValue("@contraseña", item.Contraseña);
            sqlCommand.Parameters.AddWithValue("@tipousuario", item.TipoUsuario);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Eliminar(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Usuarios where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(sqlCommand);
        }

        public Usuarios EnlistarUno(int id)
        {
            Usuarios usuarios = new Usuarios();

            SqlCommand sqlCommand = new SqlCommand("select * from Usuarios where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    usuarios.Id = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    usuarios.Nombre = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    usuarios.Apellido = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                    usuarios.Correo = dataReader.IsDBNull(3) ? "NULL" : dataReader.GetString(3);
                    usuarios.Nombre_Usuario = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    usuarios.Contraseña = dataReader.IsDBNull(5) ? "NULL" : dataReader.GetString(5);
                    usuarios.TipoUsuario = dataReader.IsDBNull(6) ? "NULL" : dataReader.GetString(6);
                }

                dataReader.Close();
                dataReader.Dispose();

                connection.Close();

                return usuarios;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable EnlistarTodo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Doctores", connection);
            return ObtenerDatos(sqlDataAdapter);
        }

        public bool UserExists(string nombreUsuario)
        {
            try
            {
                bool Exists = true;

                connection.Open();
                SqlCommand command = new SqlCommand("select Nombre_Usuario from Usuarios where Nombre_Usuario = @nombreUsuario", connection);

                command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Exists = reader.IsDBNull(0) ? false : true;
                }

                reader.Close();
                reader.Dispose();

                connection.Close();

                return Exists;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region Ejecutores_SQL
        private DataTable ObtenerDatos(SqlDataAdapter dataAdapter)
        {
            try
            {
                DataTable data = new DataTable();

                connection.Open();
                dataAdapter.Fill(data);
                connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private bool EjecutarConsulta(SqlCommand command)
        {
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion
    }
}
