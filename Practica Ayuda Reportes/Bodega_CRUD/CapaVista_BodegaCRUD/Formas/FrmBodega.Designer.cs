namespace CapaVista_BodegaCRUD.Formas
{
    partial class FrmBodega
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
            this.Titulo = new System.Windows.Forms.Label();
            this.panIngresoDatos = new System.Windows.Forms.Panel();
            this.txtTelefonoBodega = new System.Windows.Forms.TextBox();
            this.lblTelefonoBodega = new System.Windows.Forms.Label();
            this.txtCapacidadBodega = new System.Windows.Forms.TextBox();
            this.lblCapacidadBodega = new System.Windows.Forms.Label();
            this.txtIdDireccion = new System.Windows.Forms.TextBox();
            this.lblIdDireccion = new System.Windows.Forms.Label();
            this.txtNombreBodega = new System.Windows.Forms.TextBox();
            this.lblNombreBodega = new System.Windows.Forms.Label();
            this.txtIdSucursal = new System.Windows.Forms.TextBox();
            this.lblIdSucursal = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvBodega = new System.Windows.Forms.DataGridView();
            this.lblComboBodega = new System.Windows.Forms.Label();
            this.comboBodega1 = new Capa_Vista_ComboI.ComboI();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(30, 23);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(479, 40);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Mantenimiento de Bodegas";
            // 
            // panIngresoDatos
            // 
            this.panIngresoDatos.Controls.Add(this.txtTelefonoBodega);
            this.panIngresoDatos.Controls.Add(this.lblTelefonoBodega);
            this.panIngresoDatos.Controls.Add(this.txtCapacidadBodega);
            this.panIngresoDatos.Controls.Add(this.lblCapacidadBodega);
            this.panIngresoDatos.Controls.Add(this.txtIdDireccion);
            this.panIngresoDatos.Controls.Add(this.lblIdDireccion);
            this.panIngresoDatos.Controls.Add(this.txtNombreBodega);
            this.panIngresoDatos.Controls.Add(this.lblNombreBodega);
            this.panIngresoDatos.Controls.Add(this.txtIdSucursal);
            this.panIngresoDatos.Controls.Add(this.lblIdSucursal);
            this.panIngresoDatos.Controls.Add(this.btnGrabar);
            this.panIngresoDatos.Location = new System.Drawing.Point(30, 85);
            this.panIngresoDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panIngresoDatos.Name = "panIngresoDatos";
            this.panIngresoDatos.Size = new System.Drawing.Size(510, 400);
            this.panIngresoDatos.TabIndex = 1;
            // 
            // txtTelefonoBodega
            // 
            this.txtTelefonoBodega.Location = new System.Drawing.Point(210, 265);
            this.txtTelefonoBodega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefonoBodega.Name = "txtTelefonoBodega";
            this.txtTelefonoBodega.Size = new System.Drawing.Size(268, 26);
            this.txtTelefonoBodega.TabIndex = 9;
            // 
            // lblTelefonoBodega
            // 
            this.lblTelefonoBodega.AutoSize = true;
            this.lblTelefonoBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoBodega.Location = new System.Drawing.Point(15, 269);
            this.lblTelefonoBodega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoBodega.Name = "lblTelefonoBodega";
            this.lblTelefonoBodega.Size = new System.Drawing.Size(84, 20);
            this.lblTelefonoBodega.TabIndex = 8;
            this.lblTelefonoBodega.Text = "Telefono:";
            // 
            // txtCapacidadBodega
            // 
            this.txtCapacidadBodega.Location = new System.Drawing.Point(210, 203);
            this.txtCapacidadBodega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCapacidadBodega.Name = "txtCapacidadBodega";
            this.txtCapacidadBodega.Size = new System.Drawing.Size(268, 26);
            this.txtCapacidadBodega.TabIndex = 7;
            // 
            // lblCapacidadBodega
            // 
            this.lblCapacidadBodega.AutoSize = true;
            this.lblCapacidadBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadBodega.Location = new System.Drawing.Point(15, 208);
            this.lblCapacidadBodega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidadBodega.Name = "lblCapacidadBodega";
            this.lblCapacidadBodega.Size = new System.Drawing.Size(99, 20);
            this.lblCapacidadBodega.TabIndex = 6;
            this.lblCapacidadBodega.Text = "Capacidad:";
            // 
            // txtIdDireccion
            // 
            this.txtIdDireccion.Location = new System.Drawing.Point(210, 142);
            this.txtIdDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdDireccion.Name = "txtIdDireccion";
            this.txtIdDireccion.Size = new System.Drawing.Size(268, 26);
            this.txtIdDireccion.TabIndex = 5;
            // 
            // lblIdDireccion
            // 
            this.lblIdDireccion.AutoSize = true;
            this.lblIdDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDireccion.Location = new System.Drawing.Point(15, 146);
            this.lblIdDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDireccion.Name = "lblIdDireccion";
            this.lblIdDireccion.Size = new System.Drawing.Size(115, 20);
            this.lblIdDireccion.TabIndex = 4;
            this.lblIdDireccion.Text = "Id. Direccion:";
            // 
            // txtNombreBodega
            // 
            this.txtNombreBodega.Location = new System.Drawing.Point(210, 80);
            this.txtNombreBodega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreBodega.Name = "txtNombreBodega";
            this.txtNombreBodega.Size = new System.Drawing.Size(268, 26);
            this.txtNombreBodega.TabIndex = 3;
            // 
            // lblNombreBodega
            // 
            this.lblNombreBodega.AutoSize = true;
            this.lblNombreBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBodega.Location = new System.Drawing.Point(15, 85);
            this.lblNombreBodega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreBodega.Name = "lblNombreBodega";
            this.lblNombreBodega.Size = new System.Drawing.Size(166, 20);
            this.lblNombreBodega.TabIndex = 2;
            this.lblNombreBodega.Text = "Nombre de bodega:";
            // 
            // txtIdSucursal
            // 
            this.txtIdSucursal.Location = new System.Drawing.Point(210, 18);
            this.txtIdSucursal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdSucursal.Name = "txtIdSucursal";
            this.txtIdSucursal.Size = new System.Drawing.Size(268, 26);
            this.txtIdSucursal.TabIndex = 1;
            // 
            // lblIdSucursal
            // 
            this.lblIdSucursal.AutoSize = true;
            this.lblIdSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSucursal.Location = new System.Drawing.Point(15, 23);
            this.lblIdSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdSucursal.Name = "lblIdSucursal";
            this.lblIdSucursal.Size = new System.Drawing.Size(110, 20);
            this.lblIdSucursal.TabIndex = 0;
            this.lblIdSucursal.Text = "Id. Sucursal:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(210, 331);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(150, 46);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.RosyBrown;
            this.Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.Location = new System.Drawing.Point(30, 500);
            this.Nuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(120, 46);
            this.Nuevo.TabIndex = 2;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.RosyBrown;
            this.Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.Location = new System.Drawing.Point(165, 500);
            this.Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(120, 46);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.RosyBrown;
            this.Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Location = new System.Drawing.Point(300, 500);
            this.Borrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(120, 46);
            this.Borrar.TabIndex = 4;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(690, 88);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(298, 26);
            this.Buscar.TabIndex = 6;
            this.Buscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(600, 92);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(70, 20);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar:";
            // 
            // dgvBodega
            // 
            this.dgvBodega.AllowUserToAddRows = false;
            this.dgvBodega.AllowUserToDeleteRows = false;
            this.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodega.Location = new System.Drawing.Point(600, 138);
            this.dgvBodega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBodega.Name = "dgvBodega";
            this.dgvBodega.ReadOnly = true;
            this.dgvBodega.RowHeadersWidth = 30;
            this.dgvBodega.Size = new System.Drawing.Size(675, 462);
            this.dgvBodega.TabIndex = 7;
            // 
            // lblComboBodega
            // 
            this.lblComboBodega.AutoSize = true;
            this.lblComboBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboBodega.Location = new System.Drawing.Point(600, 23);
            this.lblComboBodega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComboBodega.Name = "lblComboBodega";
            this.lblComboBodega.Size = new System.Drawing.Size(106, 20);
            this.lblComboBodega.TabIndex = 8;
            this.lblComboBodega.Text = "Ir a bodega:";
            // 
            // comboBodega1
            // 
            this.comboBodega1.Location = new System.Drawing.Point(600, 51);
            this.comboBodega1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBodega1.Name = "comboBodega1";
            this.comboBodega1.Size = new System.Drawing.Size(450, 37);
            this.comboBodega1.TabIndex = 9;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(30, 560);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(120, 46);
            this.btnReportes.TabIndex = 20;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(165, 560);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(120, 46);
            this.btnAyuda.TabIndex = 21;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // FrmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1320, 646);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.comboBodega1);
            this.Controls.Add(this.lblComboBodega);
            this.Controls.Add(this.dgvBodega);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.panIngresoDatos);
            this.Controls.Add(this.Titulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBodega";
            this.Text = "FrmBodega - Mantenimiento de Bodegas";
            this.Load += new System.EventHandler(this.FrmBodega_Load);
            this.panIngresoDatos.ResumeLayout(false);
            this.panIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panIngresoDatos;
        private System.Windows.Forms.TextBox txtTelefonoBodega;
        private System.Windows.Forms.Label lblTelefonoBodega;
        private System.Windows.Forms.TextBox txtCapacidadBodega;
        private System.Windows.Forms.Label lblCapacidadBodega;
        private System.Windows.Forms.TextBox txtIdDireccion;
        private System.Windows.Forms.Label lblIdDireccion;
        private System.Windows.Forms.TextBox txtNombreBodega;
        private System.Windows.Forms.Label lblNombreBodega;
        private System.Windows.Forms.TextBox txtIdSucursal;
        private System.Windows.Forms.Label lblIdSucursal;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvBodega;
        private System.Windows.Forms.Label lblComboBodega;
        private Capa_Vista_ComboI.ComboI comboBodega1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAyuda;
    }
}
