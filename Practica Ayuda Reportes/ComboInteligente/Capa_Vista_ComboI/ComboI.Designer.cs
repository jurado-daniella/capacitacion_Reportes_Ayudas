namespace Capa_Vista_ComboI
{
    partial class ComboI
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

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            //
            // cboBusqueda
            //
            this.cboBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(0, 0);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(300, 24);
            this.cboBusqueda.TabIndex = 0;
            //
            // ComboI
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboBusqueda);
            this.Name = "ComboI";
            this.Size = new System.Drawing.Size(300, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBusqueda;
    }
}
