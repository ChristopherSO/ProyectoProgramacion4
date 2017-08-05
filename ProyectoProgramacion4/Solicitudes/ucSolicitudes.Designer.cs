namespace ProyectoProgramacion4.Solicitudes
{
    partial class ucSolicitudes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
			this.btnVerEnDetalle = new System.Windows.Forms.Button();
			this.Id_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nom_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MontoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequiereAprobacionJefe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequiereAprobacionGerencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dgvSolicitudes, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnVerEnDetalle, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1440, 954);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkCyan;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1440, 91);
			this.label2.TabIndex = 2;
			this.label2.Text = "Solicitudes de compras";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvSolicitudes
			// 
			this.dgvSolicitudes.AllowUserToAddRows = false;
			this.dgvSolicitudes.AllowUserToDeleteRows = false;
			this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSolicitudes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Solicitud,
            this.Nom_Departamento,
            this.Fecha_Solicitud,
            this.MontoCompra,
            this.RequiereAprobacionJefe,
            this.RequiereAprobacionGerencia,
            this.Estado});
			this.dgvSolicitudes.Location = new System.Drawing.Point(3, 93);
			this.dgvSolicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 31);
			this.dgvSolicitudes.MultiSelect = false;
			this.dgvSolicitudes.Name = "dgvSolicitudes";
			this.dgvSolicitudes.ReadOnly = true;
			this.dgvSolicitudes.RowTemplate.Height = 40;
			this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSolicitudes.Size = new System.Drawing.Size(1434, 757);
			this.dgvSolicitudes.TabIndex = 3;
			// 
			// btnVerEnDetalle
			// 
			this.btnVerEnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVerEnDetalle.BackColor = System.Drawing.Color.DarkCyan;
			this.btnVerEnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerEnDetalle.ForeColor = System.Drawing.Color.White;
			this.btnVerEnDetalle.Location = new System.Drawing.Point(1186, 883);
			this.btnVerEnDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVerEnDetalle.Name = "btnVerEnDetalle";
			this.btnVerEnDetalle.Size = new System.Drawing.Size(251, 69);
			this.btnVerEnDetalle.TabIndex = 4;
			this.btnVerEnDetalle.Text = "Ver en detalle";
			this.btnVerEnDetalle.UseVisualStyleBackColor = false;
			// 
			// Id_Solicitud
			// 
			this.Id_Solicitud.DataPropertyName = "IdSolicitud";
			this.Id_Solicitud.HeaderText = "Id solicitud";
			this.Id_Solicitud.Name = "Id_Solicitud";
			this.Id_Solicitud.ReadOnly = true;
			this.Id_Solicitud.Visible = false;
			// 
			// Nom_Departamento
			// 
			this.Nom_Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nom_Departamento.DataPropertyName = "NombreDepartamento";
			this.Nom_Departamento.HeaderText = "Departamento que solicita";
			this.Nom_Departamento.Name = "Nom_Departamento";
			this.Nom_Departamento.ReadOnly = true;
			// 
			// Fecha_Solicitud
			// 
			this.Fecha_Solicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Fecha_Solicitud.DataPropertyName = "FechaSolicitud";
			this.Fecha_Solicitud.HeaderText = "Fecha solicitud";
			this.Fecha_Solicitud.Name = "Fecha_Solicitud";
			this.Fecha_Solicitud.ReadOnly = true;
			// 
			// MontoCompra
			// 
			this.MontoCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MontoCompra.DataPropertyName = "MontoCompra";
			this.MontoCompra.HeaderText = "Monto compra";
			this.MontoCompra.Name = "MontoCompra";
			this.MontoCompra.ReadOnly = true;
			// 
			// RequiereAprobacionJefe
			// 
			this.RequiereAprobacionJefe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.RequiereAprobacionJefe.DataPropertyName = "RequiereAprobacionJefe";
			this.RequiereAprobacionJefe.HeaderText = "Requiere aprobación de jefe?";
			this.RequiereAprobacionJefe.Name = "RequiereAprobacionJefe";
			this.RequiereAprobacionJefe.ReadOnly = true;
			// 
			// RequiereAprobacionGerencia
			// 
			this.RequiereAprobacionGerencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.RequiereAprobacionGerencia.DataPropertyName = "RequiereAprobacionGerencia";
			this.RequiereAprobacionGerencia.HeaderText = "Requiere aprobación de gerencia?";
			this.RequiereAprobacionGerencia.Name = "RequiereAprobacionGerencia";
			this.RequiereAprobacionGerencia.ReadOnly = true;
			// 
			// Estado
			// 
			this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Estado.DataPropertyName = "Estado";
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			// 
			// ucSolicitudes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "ucSolicitudes";
			this.Size = new System.Drawing.Size(1440, 954);
			this.Load += new System.EventHandler(this.ucSolicitudes_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Button btnVerEnDetalle;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Solicitud;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Departamento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Solicitud;
		private System.Windows.Forms.DataGridViewTextBoxColumn MontoCompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn RequiereAprobacionJefe;
		private System.Windows.Forms.DataGridViewTextBoxColumn RequiereAprobacionGerencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
	}
}
