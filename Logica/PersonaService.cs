using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class PersonaService
    {
        private readonly ConnectionManager connectionManager;
        private readonly PersonaRepository repositorio;
        public PersonaService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            repositorio = new PersonaRepository(connectionManager);
        }
        public RespuestaConexion probarConexion()
        {
            RespuestaConexion respuesta;
            string estadoAbierto="", estadoCerrado="",versionServer="";
            try
            {
                connectionManager.Open();
                estadoAbierto = connectionManager.EstadoConexion();
                versionServer = connectionManager.versionServer();
            }
            catch (Exception e)
            {
                respuesta= new RespuestaConexion("Error al abrir la conexion el error es: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
                estadoCerrado = connectionManager.EstadoConexion();
                respuesta = new RespuestaConexion(estadoAbierto,estadoCerrado,versionServer);
            }
            return respuesta;
        }
    }
    public class RespuestaConexion{
        public string conOpen { get; set; }
        public String conClose { get; set; }
        public string versionServer { get; set; }
        public string error { get; set; }
        public RespuestaConexion(string e)
        {
            this.conClose = "";
            this.conOpen = "";
            this.error = e;
        }
        public RespuestaConexion(string abierto,String cerrado,string versionServer)
        {
            this.conOpen = abierto;
            this.conClose = cerrado;
            this.versionServer = versionServer;
            this.error = "Sin errores";
        }

    }

}
