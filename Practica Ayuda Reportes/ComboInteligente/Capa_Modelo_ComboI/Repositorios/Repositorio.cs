using System.Data.Odbc;

namespace Capa_Modelo_ComboI.Repositorios
{
    public abstract class Repositorio
    {
        public readonly string connectionString;

        public Repositorio()
        {
            // Mismo DSN que el resto del taller (taller_mvc via ODBC).
            connectionString = "Dsn=MVC";
        }

        protected OdbcConnection ObtenerConexion()
        {
            return new OdbcConnection(connectionString);
        }
    }
}
