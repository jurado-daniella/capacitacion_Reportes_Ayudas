using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BodegaCRUD.Repositorios
{
    // Clase abstracta reutilizable: cualquier repositorio de cualquier tabla
    // puede heredar de aqui para ejecutar Insert/Update/Delete o Select
    // sin tener que repetir el manejo de conexion ni de OdbcCommand.
    public abstract class RepositorioMaestro : Repositorio
    {
        // Usado para Insert, Update y Delete. Devuelve las filas afectadas.
        public int EjecucionNonQuery(string comandoTexto, List<OdbcParameter> parametros, CommandType comandoTipo)
        {
            using (OdbcConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (OdbcCommand ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = comandoTexto;
                    ocComando.CommandType = comandoTipo;
                    ocComando.Parameters.AddRange(parametros.ToArray());
                    return ocComando.ExecuteNonQuery();
                }
            }
        }

        // Usado unicamente para Select. Devuelve la tabla ya llena.
        public DataTable EjecucionConsulta(string comandoTexto, CommandType comandoTipo)
        {
            DataTable dtTablaDatos = new DataTable();
            using (OdbcConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (OdbcCommand ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = comandoTexto;
                    ocComando.CommandType = comandoTipo;
                    using (OdbcDataReader reader = ocComando.ExecuteReader())
                    {
                        dtTablaDatos.Load(reader);
                    }
                }
            }
            return dtTablaDatos;
        }
    }
}
