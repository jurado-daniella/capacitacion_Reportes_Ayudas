using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaControlador_BodegaCRUD;
using CapaVista_BodegaCRUD.Ayudas;

namespace CapaVista_BodegaCRUD.Formas
{
    public partial class FrmReporteBodegas : Form
    {
        // Instancia privada del controlador: la Vista solo se comunica con la capa Controlador.
        private readonly ModeloBodega modeloBodega = new ModeloBodega();

        public FrmReporteBodegas()
        {
            InitializeComponent();
        }

        private void FrmReporteBodegas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        // Flujo de la capacitacion: data source desde el controlador, reporte embebido,
        // limpiar data sources, agregar el nuevo y refrescar.
        public void CargarReporte()
        {
            try
            {
                ReportDataSource origenDatos = new ReportDataSource("ReporteBodegas", modeloBodega.ObtenerTodos());
                reportViewerBodegas.LocalReport.ReportEmbeddedResource = "CapaVista_BodegaCRUD.Reportes.ReporteBodegas.rdlc";
                reportViewerBodegas.LocalReport.DataSources.Clear();
                reportViewerBodegas.LocalReport.DataSources.Add(origenDatos);
                reportViewerBodegas.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Help.ShowHelp(this, RutaAyuda.ArchivoChm, "reporte_bodegas.html");
        }
    }
}
