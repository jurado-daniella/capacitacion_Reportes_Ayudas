using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_ComboI.Repositorios
{
    // Igual que el original: genérico para CUALQUIER tabla y 2 columnas.
    // Se le agregó un filtro WHERE opcional porque, a diferencia de la
    // tabla de empleados del ejemplo, "bodega" no tiene columna "estado".
    public class RepositorioComboI : Repositorio
    {
        public DataTable ObtenerDatos(string _tabla, string _campo1, string _campo2, string _filtro = null)
        {
            string sql = "SELECT " + _campo1 + ", " + _campo2 + " FROM " + _tabla;
            if (!string.IsNullOrEmpty(_filtro))
            {
                sql += " WHERE " + _filtro;
            }
            sql += ";";

            OdbcCommand command = new OdbcCommand(sql, ObtenerConexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dtDatos = new DataTable();
            adaptador.Fill(dtDatos);
            return dtDatos;
        }
    }
}
