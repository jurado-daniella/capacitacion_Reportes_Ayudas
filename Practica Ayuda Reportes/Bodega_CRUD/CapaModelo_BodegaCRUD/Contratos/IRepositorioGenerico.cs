using System.Collections.Generic;

namespace CapaModelo_BodegaCRUD.Contratos
{
    // Contrato generico: cualquier repositorio de cualquier entidad debe
    // poder Agregar, Editar, Eliminar y ObtenerTodos.
    public interface IRepositorioGenerico<Entidad> where Entidad : class
    {
        int Agregar(Entidad entidad);
        int Editar(Entidad entidad);
        int Eliminar(Entidad entidad);
        IEnumerable<Entidad> ObtenerTodos();
    }
}
