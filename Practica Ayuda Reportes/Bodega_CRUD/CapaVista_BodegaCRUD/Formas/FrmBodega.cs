using System;
using System.IO;
using System.Windows.Forms;
using CapaControlador_BodegaCRUD;
using CapaVista_BodegaCRUD.Ayudas;

namespace CapaVista_BodegaCRUD.Formas
{
    public partial class FrmBodega : Form
    {
        private readonly ModeloBodega bodega = new ModeloBodega();

        // Unica instancia del formulario de reporte (evita abrir varias ventanas).
        private FrmReporteBodegas frmReporte;

        public FrmBodega()
        {
            InitializeComponent();
            panIngresoDatos.Enabled = false;
        }

        private void FrmBodega_Load(object sender, EventArgs e)
        {
            comboBodega1.SeleccionCambiada += ComboBodega1_SeleccionCambiada;
            ListarBodegas();
        }

        private void ComboBodega1_SeleccionCambiada(object sender, EventArgs e)
        {
            if (comboBodega1.ValorSeleccionado == null) return;

            int idBodega = Convert.ToInt32(comboBodega1.ValorSeleccionado);
            foreach (DataGridViewRow fila in dgvBodega.Rows)
            {
                if (Convert.ToInt32(fila.Cells["IdBodega"].Value) == idBodega)
                {
                    dgvBodega.ClearSelection();
                    fila.Selected = true;
                    dgvBodega.CurrentCell = fila.Cells[0];
                    CargarEnPanel(fila);
                    break;
                }
            }
        }

        private void ListarBodegas()
        {
            try
            {
                dgvBodega.DataSource = bodega.ObtenerTodos();

                // Combo inteligente: se llena con id_bodega (valor) y nombre_bodega (texto);
                // se refresca cada vez que la lista cambia para no quedar desactualizado.
                comboBodega1.LlenarCombo("bodega", "id_bodega", "nombre_bodega");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvBodega.DataSource = bodega.BuscarPorFiltro(Buscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Reinicio();
            panIngresoDatos.Enabled = true;
            bodega.Estado = EstadoEntidad.Agregado;
            txtIdSucursal.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBodega.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila del listado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarEnPanel(dgvBodega.CurrentRow);
        }

        // Comun para btnEditar y para cuando se elige una bodega desde el combo inteligente.
        private void CargarEnPanel(DataGridViewRow fila)
        {
            panIngresoDatos.Enabled = true;
            bodega.Estado = EstadoEntidad.Modificado;

            bodega.IdBodega = Convert.ToInt32(fila.Cells["IdBodega"].Value);
            txtIdSucursal.Text = fila.Cells["IdSucursal"].Value.ToString();
            txtNombreBodega.Text = fila.Cells["NombreBodega"].Value.ToString();
            txtIdDireccion.Text = fila.Cells["IdDireccion"].Value.ToString();
            txtCapacidadBodega.Text = fila.Cells["CapacidadBodega"].Value.ToString();
            txtTelefonoBodega.Text = fila.Cells["TelefonoBodega"].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvBodega.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila del listado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea realmente borrar este registro?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            bodega.Estado = EstadoEntidad.Borrado;
            bodega.IdBodega = Convert.ToInt32(dgvBodega.CurrentRow.Cells["IdBodega"].Value);

            string resultado = bodega.GrabarCambios();
            MessageBox.Show(resultado);
            ListarBodegas();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int idSucursal;
            int idDireccion;
            int capacidad;

            int.TryParse(txtIdSucursal.Text, out idSucursal);
            int.TryParse(txtIdDireccion.Text, out idDireccion);
            int.TryParse(txtCapacidadBodega.Text, out capacidad);

            bodega.IdSucursal = idSucursal;
            bodega.NombreBodega = txtNombreBodega.Text;
            bodega.IdDireccion = idDireccion;
            bodega.CapacidadBodega = capacidad;
            bodega.TelefonoBodega = txtTelefonoBodega.Text;

            bool valido = new Ayudas.ValidacionDatos(bodega).Validar();
            if (!valido) return;

            string resultado = bodega.GrabarCambios();
            MessageBox.Show(resultado);
            ListarBodegas();
            Reinicio();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (frmReporte == null || frmReporte.IsDisposed)
            {
                frmReporte = new FrmReporteBodegas();
                frmReporte.Show();
            }
            else
            {
                // Ya esta abierto: se actualizan los datos y se trae al frente.
                frmReporte.CargarReporte();
                if (frmReporte.WindowState == FormWindowState.Minimized)
                    frmReporte.WindowState = FormWindowState.Normal;
                frmReporte.Activate();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            if (!File.Exists(RutaAyuda.ArchivoChm))
            {
                MessageBox.Show("No se encontro el archivo de ayuda:\n" + RutaAyuda.ArchivoChm,
                    "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Help.ShowHelp(this, RutaAyuda.ArchivoChm, "bodegas.html");
        }

        private void Reinicio()
        {
            panIngresoDatos.Enabled = false;
            txtIdSucursal.Clear();
            txtNombreBodega.Clear();
            txtIdDireccion.Clear();
            txtCapacidadBodega.Clear();
            txtTelefonoBodega.Clear();
        }
    }
}
