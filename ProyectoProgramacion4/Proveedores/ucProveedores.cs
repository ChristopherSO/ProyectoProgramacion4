using ModeloBD;
using ProyectoProgramacion4.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoProgramacion4.Proveedores
{
	public partial class ucProveedores : BaseUserControl
	{

		public ucProveedores()
		{
			InitializeComponent();
			dgvProveedores.AutoGenerateColumns = false;
		}

		private void ucProveedores_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			cargarProveedores();
		}

		private void cargarProveedores()
		{
			try
			{
				using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
				{
					dgvProveedores.DataSource = contexto.Proveedor.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnVerProductos_Click(object sender, EventArgs e)
		{
			ucProductos pantalla = new ucProductos();

			//var Producto = (ModeloBD.Productos)dgvProveedores.SelectedRows.Cast<ModeloBD.Productos>().First();
			//var Producto = (ModeloBD.Productos)selectedRow.DataBoundItem;
			pantalla.NombreProveedor = dgvProveedores.SelectedRows[0].Cells["Nombre"].Value.ToString();
			FormularioPadre.cambiarPantalla(pantalla);
		}
	}
}
