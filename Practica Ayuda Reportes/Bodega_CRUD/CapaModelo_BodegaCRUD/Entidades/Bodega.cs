namespace CapaModelo_BodegaCRUD.Entidades
{
    // POCO: representa una fila exacta de la tabla "bodega" de taller_mvc.
    public class Bodega
    {
        public int IdBodega { get; set; }
        public int IdSucursal { get; set; }
        public string NombreBodega { get; set; }
        public int IdDireccion { get; set; }
        public int CapacidadBodega { get; set; }
        public string TelefonoBodega { get; set; }
    }
}
