namespace ProyectoProgramacion4.ListaDeCompras
{
	partial class ucListaDeCompras
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvCompras = new System.Windows.Forms.DataGridView();
			this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnSolicitar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btnSolicitar, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dgvCompras, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1436, 950);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkCyan;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(403, 90);
			this.label2.TabIndex = 3;
			this.label2.Text = "Lista de compras";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvCompras
			// 
			this.dgvCompras.AllowUserToAddRows = false;
			this.dgvCompras.AllowUserToDeleteRows = false;
			this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProveedor,
            this.Tipo,
            this.Nombre,
            this.Precio,
            this.IdProducto,
            this.IdProveedor});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCompras.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvCompras.Location = new System.Drawing.Point(3, 93);
			this.dgvCompras.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.dgvCompras.MultiSelect = false;
			this.dgvCompras.Name = "dgvCompras";
			this.dgvCompras.ReadOnly = true;
			this.dgvCompras.RowTemplate.Height = 40;
			this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCompras.Size = new System.Drawing.Size(1430, 671);
			this.dgvCompras.TabIndex = 4;
			// 
			// NombreProveedor
			// 
			this.NombreProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.NombreProveedor.DataPropertyName = "Nom_Proveedor";
			this.NombreProveedor.HeaderText = "Proveedor";
			this.NombreProveedor.Name = "NombreProveedor";
			this.NombreProveedor.ReadOnly = true;
			this.NombreProveedor.Width = 207;
			// 
			// Tipo
			// 
			this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Tipo.DataPropertyName = "Tipo";
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Visible = false;
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.DataPropertyName = "Nom_Producto";
			this.Nombre.HeaderText = "Nombre producto";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Precio
			// 
			this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Precio.DataPropertyName = "Precio";
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			this.Precio.Width = 154;
			// 
			// IdProducto
			// 
			this.IdProducto.DataPropertyName = "Id_Producto";
			this.IdProducto.HeaderText = "IdProducto";
			this.IdProducto.Name = "IdProducto";
			this.IdProducto.ReadOnly = true;
			this.IdProducto.Visible = false;
			// 
			// IdProveedor
			// 
			this.IdProveedor.DataPropertyName = "Id_Proveedor";
			this.IdProveedor.HeaderText = "IdProveedor";
			this.IdProveedor.Name = "IdProveedor";
			this.IdProveedor.ReadOnly = true;
			this.IdProveedor.Visible = false;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.lblTotal);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 794);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1436, 80);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1270, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 36);
			this.label3.TabIndex = 7;
			this.label3.Text = "TOTAL:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(1401, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(32, 36);
			this.lblTotal.TabIndex = 8;
			this.lblTotal.Text = "0";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSolicitar
			// 
			this.btnSolicitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSolicitar.BackColor = System.Drawing.Color.DarkCyan;
			this.btnSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSolicitar.ForeColor = System.Drawing.Color.White;
			this.btnSolicitar.Location = new System.Drawing.Point(1183, 877);
			this.btnSolicitar.Name = "btnSolicitar";
			this.btnSolicitar.Size = new System.Drawing.Size(250, 70);
			this.btnSolicitar.TabIndex = 7;
			this.btnSolicitar.Text = "Solicitar";
			this.btnSolicitar.UseVisualStyleBackColor = false;
			// 
			// ListaDeCompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ListaDeCompras";
			this.Size = new System.Drawing.Size(1436, 950);
			this.Load += new System.EventHandler(this.ListaDeCompras_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvCompras;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnSolicitar;
	}
}
