using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_ComboI;

namespace Capa_Vista_ComboI
{
    public partial class ComboI : UserControl
    {
        private readonly ModeloComboI controlador = new ModeloComboI();

        // Se dispara cuando el usuario elige un elemento del combo, para que
        // el formulario anfitrion reaccione (ej. cargar esa bodega en pantalla).
        public event EventHandler SeleccionCambiada;

        public ComboI()
        {
            InitializeComponent();
            cboBusqueda.SelectionChangeCommitted += (s, e) => SeleccionCambiada?.Invoke(this, EventArgs.Empty);
        }

        // Expone el valor (campo1) del elemento elegido, para que el formulario
        // que lo use pueda leerlo (ej. el id de bodega seleccionado).
        public object ValorSeleccionado => cboBusqueda.SelectedValue;

        public void LlenarCombo(string _tabla, string _campo1, string _campo2, string _filtro = null)
        {
            DataTable dtTabla = controlador.EnviarDatos(_tabla, _campo1, _campo2, _filtro);

            cboBusqueda.DataSource = dtTabla;
            cboBusqueda.ValueMember = _campo1;
            cboBusqueda.DisplayMember = _campo2;

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dtTabla.Rows)
            {
                coleccion.Add(Convert.ToString(row[_campo1]) + " - " + Convert.ToString(row[_campo2]));
                coleccion.Add(Convert.ToString(row[_campo2]) + " - " + Convert.ToString(row[_campo1]));
            }
            cboBusqueda.AutoCompleteCustomSource = coleccion;
            cboBusqueda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
