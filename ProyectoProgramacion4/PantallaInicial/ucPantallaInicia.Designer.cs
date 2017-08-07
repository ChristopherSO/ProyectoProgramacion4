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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMoneda
            // 
            this.dgvMoneda.AllowUserToAddRows = false;
            this.dgvMoneda.AllowUserToDeleteRows = false;
            this.dgvMoneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMoneda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvMoneda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFecha,
            this.clCompra,
            this.clVenta});
            this.dgvMoneda.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvMoneda.Location = new System.Drawing.Point(182, 132);
            this.dgvMoneda.Name = "dgvMoneda";
            this.dgvMoneda.RowHeadersVisible = false;
            this.dgvMoneda.Size = new System.Drawing.Size(502, 442);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de cambio de compra y de venta del dólar";
            // 
            // ucPantallaInicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMoneda);
            this.Name = "ucPantallaInicia";
            this.Size = new System.Drawing.Size(852, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVenta;
        private System.Windows.Forms.Label label1;
    }
}
