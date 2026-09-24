using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CapaModelo_BodegaCRUD.Contratos;
using CapaModelo_BodegaCRUD.Entidades;
using CapaModelo_BodegaCRUD.Repositorios;

namespace CapaControlador_BodegaCRUD
{
    // Intermediario entre la Vista y el Modelo: valida la informacion antes
    // de mandarla a grabar y traduce la lista de la BD a lo que pide el DataGridView.
    public class ModeloBodega
    {
        private int _idBodega;
        private int _idSucursal;
        private string _nombreBodega;
        private int _idDireccion;
        private int _capacidadBodega;
        private string _telefonoBodega;

        private readonly IRepositorioBodega repositorioBodega;
        private List<ModeloBodega> listaBodegas;

        public EstadoEntidad Estado { private get; set; }

        public int IdBodega { get => _idBodega; set => _idBodega = value; }

        [Required(ErrorMessage = "El campo Sucursal es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El id de sucursal debe ser un numero valido")]
        public int IdSucursal { get => _idSucursal; set => _idSucursal = value; }

        [Required(ErrorMessage = "El campo Nombre de bodega es requerido")]
        [RegularExpression("^[a-zA-Zá-úÁ-Ú ]+$", ErrorMessage = "El nombre de bodega debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        public string NombreBodega { get => _nombreBodega; set => _nombreBodega = value; }

        [Required(ErrorMessage = "El campo Direccion es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El id de direccion debe ser un numero valido")]
        public int IdDireccion { get => _idDireccion; set => _idDireccion = value; }

        [Required(ErrorMessage = "El campo Capacidad es requerido")]
        [Range(1, 1000000, ErrorMessage = "La capacidad debe ser un numero entre 1 y 1,000,000")]
        public int CapacidadBodega { get => _capacidadBodega; set => _capacidadBodega = value; }

        [Required(ErrorMessage = "El campo Telefono es requerido")]
        [RegularExpression(@"^[0-9]{4}-[0-9]{4}$", ErrorMessage = "El telefono debe tener el formato 5555-1234")]
        public string TelefonoBodega { get => _telefonoBodega; set => _telefonoBodega = value; }

        public ModeloBodega()
        {
            repositorioBodega = new RepositorioBodega();
        }

        public string GrabarCambios()
        {
            string mensaje;
            try
            {
                Bodega modeloDatosBodega = new Bodega();
                modeloDatosBodega.IdBodega = _idBodega;
                modeloDatosBodega.IdSucursal = _idSucursal;
                modeloDatosBodega.NombreBodega = _nombreBodega;
                modeloDatosBodega.IdDireccion = _idDireccion;
                modeloDatosBodega.CapacidadBodega = _capacidadBodega;
                modeloDatosBodega.TelefonoBodega = _telefonoBodega;

                switch (Estado)
                {
                    case EstadoEntidad.Agregado:
                        repositorioBodega.Agregar(modeloDatosBodega);
                        mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modificado:
                        repositorioBodega.Editar(modeloDatosBodega);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Borrado:
                        repositorioBodega.Eliminar(modeloDatosBodega);
                        mensaje = "Eliminacion exitosa";
                        break;
                    default:
                        mensaje = "No se definio ninguna accion";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }

        public List<ModeloBodega> ObtenerTodos()
        {
            IEnumerable<Bodega> datosBodega = repositorioBodega.ObtenerTodos();
            listaBodegas = new List<ModeloBodega>();
            foreach (Bodega item in datosBodega)
            {
                listaBodegas.Add(new ModeloBodega
                {
                    _idBodega = item.IdBodega,
                    _idSucursal = item.IdSucursal,
                    _nombreBodega = item.NombreBodega,
                    _idDireccion = item.IdDireccion,
                    _capacidadBodega = item.CapacidadBodega,
                    _telefonoBodega = item.TelefonoBodega
                });
            }
            return listaBodegas;
        }

        public IEnumerable<ModeloBodega> BuscarPorFiltro(string filtro)
        {
            if (listaBodegas == null) return new List<ModeloBodega>();
            if (string.IsNullOrEmpty(filtro)) return listaBodegas;

            return listaBodegas.FindAll(b =>
                b._idBodega.ToString().Contains(filtro) ||
                (b._nombreBodega != null && b._nombreBodega.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0));
        }
    }
}
