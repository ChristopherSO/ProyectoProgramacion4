namespace ProyectoProgramacion4.PantallaInicial
{
    partial class ucPantallaInicia
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMoneda = new System.Windows.Forms.DataGridView();
            this.clFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMoneda
            // 
            this.dgvMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFecha,
            this.clCompra,
            this.clVenta});
            this.dgvMoneda.Location = new System.Drawing.Point(158, 36);
            this.dgvMoneda.Name = "dgvMoneda";
            this.dgvMoneda.Size = new System.Drawing.Size(344, 296);
            this.dgvMoneda.TabIndex = 0;
            // 
            // clFecha
            // 
            this.clFecha.HeaderText = "Fecha";
            this.clFecha.Name = "clFecha";
            this.clFecha.ReadOnly = true;
            // 
            // clCompra
            // 
            this.clCompra.HeaderText = "Tipo Cambio Compra";
            this.clCompra.Name = "clCompra";
            this.clCompra.ReadOnly = true;
            // 
            // clVenta
            // 
            this.clVenta.HeaderText = "Tipo Cambio Venta";
            this.clVenta.Name = "clVenta";
            this.clVenta.ReadOnly = true;
            // 
            // ucPantallaInicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMoneda);
            this.Name = "ucPantallaInicia";
            this.Size = new System.Drawing.Size(694, 376);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVenta;
    }
}
