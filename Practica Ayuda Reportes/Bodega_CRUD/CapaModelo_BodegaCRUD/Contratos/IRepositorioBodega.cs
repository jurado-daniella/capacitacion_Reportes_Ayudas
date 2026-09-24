using CapaModelo_BodegaCRUD.Entidades;

namespace CapaModelo_BodegaCRUD.Contratos
{
    // Contrato especifico de Bodega: solo hereda del generico indicando la entidad.
    public interface IRepositorioBodega : IRepositorioGenerico<Bodega>
    {
    }
}
