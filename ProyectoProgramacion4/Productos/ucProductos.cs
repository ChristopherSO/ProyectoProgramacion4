using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloBD;

namespace ProyectoProgramacion4.Productos
{
	public partial class ucProductos : UserControl
	{
		public string NombreProveedor { get; set; }

		public ucProductos()
		{
			InitializeComponent();
			dgvProductos.AutoGenerateColumns = false;
		}

		private void ucProductos_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			lblNombreProveedor.Text = NombreProveedor;
			cargarProductos();

			if (NombreProveedor == null)
			{
				// Ocultar la fila que muestar el Proveedor
				TableLayoutPanel tlpPrincipal = (TableLayoutPanel)Controls[0];
				tlpPrincipal.RowStyles[1].Height = 0;
			}
		}

		private void cargarProductos()
		{
			try
			{
				using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
				{
					if (NombreProveedor == null)
					{
						dgvProductos.DataSource = contexto.Producto
						.Where(x => x.Tipo == "Producto")
						.Select(x => new {
							x.Proveedor.Nom_Proveedor,
							x.Tipo,
							x.Nom_Producto,
							x.Precio
						}).ToList();
					}
					else
					{
						dgvProductos.DataSource = contexto.Producto
						.Where(x => x.Tipo == "Producto" && x.Proveedor.Nom_Proveedor.Equals(NombreProveedor))
						.Select(x => new {
							x.Proveedor.Nom_Proveedor,
							x.Tipo,
							x.Nom_Producto,
							x.Precio
						}).ToList();

						dgvProductos.Columns[0].Visible = false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
    }
}
