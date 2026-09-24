using System;
using System.Data.Odbc;

namespace CapaModelo_BodegaCRUD.Repositorios
{
    // Clase base: unicamente sabe abrir una conexion ODBC contra el DSN del taller.
    public abstract class Repositorio
    {
        public readonly string ConnectionString;

        public Repositorio()
        {
            ConnectionString = "Dsn=MVC";
        }

        protected OdbcConnection ObtenerConexion()
        {
            return new OdbcConnection(ConnectionString);
        }
    }
}
