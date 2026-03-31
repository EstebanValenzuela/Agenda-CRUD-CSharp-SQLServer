using System;
using System.Data;
using System.Data.SqlClient;

namespace AgendaE
{
    internal class CapaDAO
    {
        Datos conexion = new Datos();

        public void InsertarContacto(string nombre, string apellido, DateTime fechaNacimiento,
            string direccion, string genero, string estadoCivil,
            string movil, string telefono, string correo)
        {
            using (SqlConnection con = conexion.GetConnection())
            {
                if (con == null)
                    return;

                /*string query = @"INSERT INTO Contactos
                (Nombre, Apellido, FechaNacimiento, Direccion, Genero, EstadoCivil, Movil, Telefono, CorreoElectronico)
                VALUES
                (@Nombre, @Apellido, @FechaNacimiento, @Direccion, @Genero, @EstadoCivil, @Movil, @Telefono, @Correo)";

                SqlCommand cmd = new SqlCommand(query, con);*/

                SqlCommand cmd = new SqlCommand("SP_InsertarContacto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Genero", genero);
                cmd.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
                cmd.Parameters.AddWithValue("@Movil", movil);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo", correo);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarContactos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = conexion.GetConnection())
            {
                if (con == null)
                    return tabla;

                /*string query = "SELECT * FROM Contactos";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(tabla);*/

                SqlDataAdapter da = new SqlDataAdapter("SP_ListaContactos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(tabla);
            }

            return tabla;
        }

        public void EliminarContacto(int id)
        {
            using (SqlConnection con = conexion.GetConnection())
            {
                if (con == null)
                    return;

               /* string query = "DELETE FROM Contactos WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();*/
               SqlCommand cmd = new SqlCommand("SP_EliminarContacto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();


            }
        }

        public DataTable BuscarContacto(string nombre)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = conexion.GetConnection())
            {
                if (con == null)
                    return tabla;

                /*string query = "SELECT * FROM Contactos WHERE Nombre LIKE @Nombre";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);*/

                SqlCommand cmd = new SqlCommand("sp_BuscarContacto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        public void ModificarContacto(int id, string nombre, string apellido, DateTime fechaNacimiento,
            string direccion, string genero, string estadoCivil,
            string movil, string telefono, string correo)
        {
            using (SqlConnection con = conexion.GetConnection())
            {
                if (con == null)
                    return;

                SqlCommand cmd = new SqlCommand("SP_ModificarContacto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                /*string query = @"UPDATE Contactos SET
                                Nombre=@Nombre,
                                Apellido=@Apellido,
                                FechaNacimiento=@FechaNacimiento,
                                Direccion=@Direccion,
                                Genero=@Genero,
                                EstadoCivil=@EstadoCivil,
                                Movil=@Movil,
                                Telefono=@Telefono,
                                CorreoElectronico=@Correo
                                WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);*/

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Genero", genero);
                cmd.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
                cmd.Parameters.AddWithValue("@Movil", movil);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo", correo);

                cmd.ExecuteNonQuery();
            }
        }

        public string ValidarUsuario(string usuario, string clave)
        {
            using (SqlConnection con = conexion.GetConnection())
            {
                if (con == null)
                    return "Error";

                // Buscar usuario
                string query = "SELECT Clave FROM Usuarios WHERE Usuario=@Usuario";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                object result = cmd.ExecuteScalar();

                if (result == null)
                    return "UsuarioNoExiste";

                string claveBD = result.ToString();

                if (claveBD != clave)
                    return "ClaveIncorrecta";

                return "OK";
            }
        }
    }
}