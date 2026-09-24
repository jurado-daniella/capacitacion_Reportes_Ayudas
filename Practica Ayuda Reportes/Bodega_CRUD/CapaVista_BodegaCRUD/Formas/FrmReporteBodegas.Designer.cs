namespace CapaVista_BodegaCRUD.Formas
{
    partial class FrmReporteBodegas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.reportViewerBodegas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerBodegas
            // 
            this.reportViewerBodegas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerBodegas.Location = new System.Drawing.Point(0, 60);
            this.reportViewerBodegas.Name = "reportViewerBodegas";
            this.reportViewerBodegas.ServerReport.BearerToken = null;
            this.reportViewerBodegas.Size = new System.Drawing.Size(1000, 640);
            this.reportViewerBodegas.TabIndex = 1;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.MistyRose;
            this.panelOpciones.Controls.Add(this.btnAyuda);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1000, 60);
            this.panelOpciones.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(866, 7);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(120, 46);
            this.btnAyuda.TabIndex = 0;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // FrmReporteBodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.reportViewerBodegas);
            this.Controls.Add(this.panelOpciones);
            this.Name = "FrmReporteBodegas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteBodegas - Reporte de Bodegas";
            this.Load += new System.EventHandler(this.FrmReporteBodegas_Load);
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBodegas;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnAyuda;
    }
}
