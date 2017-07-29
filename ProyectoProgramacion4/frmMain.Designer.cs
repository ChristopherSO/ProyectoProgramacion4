namespace ProyectoProgramacion4
{
	partial class frmMain
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

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Proveedores");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Productos");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Servicios");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Presupuestos");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode(" Administración", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Productos");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Servicios");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Por proveedor");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode(" Compras", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode(" Contabilidad");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode(" Reportes");
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lblNombreUsuario = new System.Windows.Forms.Label();
			this.linkCerrarSesion = new System.Windows.Forms.LinkLabel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.treeView = new System.Windows.Forms.TreeView();
			this.pnlContenido = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1768, 1112);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkCyan;
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 3, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1762, 144);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 144);
			this.label1.TabIndex = 0;
			this.label1.Text = "";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(80, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(800, 144);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gestión de presupuestos";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.lblNombreUsuario, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.linkCerrarSesion, 0, 1);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(1165, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(594, 138);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// lblNombreUsuario
			// 
			this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNombreUsuario.AutoSize = true;
			this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
			this.lblNombreUsuario.Location = new System.Drawing.Point(3, 0);
			this.lblNombreUsuario.Name = "lblNombreUsuario";
			this.lblNombreUsuario.Size = new System.Drawing.Size(588, 82);
			this.lblNombreUsuario.TabIndex = 0;
			this.lblNombreUsuario.Text = "Peter Parker";
			this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// linkCerrarSesion
			// 
			this.linkCerrarSesion.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
			this.linkCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkCerrarSesion.AutoSize = true;
			this.linkCerrarSesion.LinkColor = System.Drawing.Color.PaleTurquoise;
			this.linkCerrarSesion.Location = new System.Drawing.Point(3, 82);
			this.linkCerrarSesion.Name = "linkCerrarSesion";
			this.linkCerrarSesion.Size = new System.Drawing.Size(588, 56);
			this.linkCerrarSesion.TabIndex = 1;
			this.linkCerrarSesion.TabStop = true;
			this.linkCerrarSesion.Text = "Cerrar sesión";
			this.linkCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.treeView, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.pnlContenido, 1, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 153);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1762, 956);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// treeView
			// 
			this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView.BackColor = System.Drawing.Color.DimGray;
			this.treeView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.treeView.Font = new System.Drawing.Font("Eras Demi ITC", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeView.ForeColor = System.Drawing.Color.White;
			this.treeView.Indent = 50;
			this.treeView.ItemHeight = 60;
			this.treeView.Location = new System.Drawing.Point(3, 3);
			this.treeView.Name = "treeView";
			treeNode1.Name = "NodoAdministracion1";
			treeNode1.Text = "Proveedores";
			treeNode2.Name = "NodoAdministracion2";
			treeNode2.Text = "Productos";
			treeNode3.Name = "NodoAdministracion3";
			treeNode3.Text = "Servicios";
			treeNode4.Name = "NodoAdministracion4";
			treeNode4.Text = "Presupuestos";
			treeNode5.Name = "NodoAdministracion";
			treeNode5.Text = " Administración";
			treeNode6.Name = "NodoCompras1";
			treeNode6.Text = "Productos";
			treeNode7.Name = "NodoCompras2";
			treeNode7.Text = "Servicios";
			treeNode8.Name = "NodoCompras3";
			treeNode8.Text = "Por proveedor";
			treeNode9.Name = "NodoCompras";
			treeNode9.Text = " Compras";
			treeNode10.Name = "NodoContabilidad";
			treeNode10.Text = " Contabilidad";
			treeNode11.Name = "NodoReportes";
			treeNode11.Text = " Reportes";
			this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode10,
            treeNode11});
			this.treeView.ShowPlusMinus = false;
			this.treeView.ShowRootLines = false;
			this.treeView.Size = new System.Drawing.Size(314, 950);
			this.treeView.TabIndex = 0;
			// 
			// pnlContenido
			// 
			this.pnlContenido.AutoSize = true;
			this.pnlContenido.BackColor = System.Drawing.SystemColors.Control;
			this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContenido.Location = new System.Drawing.Point(323, 3);
			this.pnlContenido.Name = "pnlContenido";
			this.pnlContenido.Padding = new System.Windows.Forms.Padding(50);
			this.pnlContenido.Size = new System.Drawing.Size(1436, 950);
			this.pnlContenido.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1768, 1112);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmMain";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label lblNombreUsuario;
		private System.Windows.Forms.LinkLabel linkCerrarSesion;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.Panel pnlContenido;
	}
}

