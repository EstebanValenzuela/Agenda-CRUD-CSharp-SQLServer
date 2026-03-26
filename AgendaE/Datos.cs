using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaE
{
    internal class Datos
    {
        private string CadenaConexion =
            "Data Source=localhost;Initial Catalog=Agenda;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(CadenaConexion);

            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }
    }
}
