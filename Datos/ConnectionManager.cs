using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    public class ConnectionManager
    {
        internal SqlConnection _conexion;
        public ConnectionManager(string connectionString)
        {
            _conexion = new SqlConnection(connectionString);
        }
        public string versionServer()
        {
            return _conexion.ServerVersion;
        }
        public string EstadoConexion()
        {
            return _conexion.State.ToString();
        }
        public void Open()
        {
            _conexion.Open();
        }
        public void Close()
        {
            _conexion.Close();
        }
    }
}
