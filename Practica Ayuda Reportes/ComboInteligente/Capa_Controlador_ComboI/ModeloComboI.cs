using System.Data;
using Capa_Modelo_ComboI.Repositorios;

namespace Capa_Controlador_ComboI
{
    public class ModeloComboI
    {
        private readonly RepositorioComboI repositorio = new RepositorioComboI();

        public DataTable EnviarDatos(string _tabla, string _campo1, string _campo2, string _filtro = null)
        {
            return repositorio.ObtenerDatos(_tabla, _campo1, _campo2, _filtro);
        }
    }
}
