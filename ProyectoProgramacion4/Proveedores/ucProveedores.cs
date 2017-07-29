using ProyectoProgramacion4.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoProgramacion4.Proveedores
{
	public partial class ucProveedores : UserControl
	{
		List<string> listaProveedores;

		public ucProveedores()
		{
			InitializeComponent();
		}

		private void ucProveedores_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			cargarProveedores();
		}

		private void cargarProveedores()
		{
			listaProveedores = new List<string>
			{
				"Proveedor 1",
				"Proveedor 2",
				"Proveedor 3",
				"Proveedor 4",
				"Proveedor 5"
			};
			dgvProveedores.DataSource = listaProveedores.Select(x => new { Nombre = x }).ToList(); ;
		}

		private void btnVerProductos_Click(object sender, EventArgs e)
		{
			frmMain FormularioPadre = (frmMain)this.FindForm();
			FormularioPadre.cambiarPantalla(new ucProductos());
		}
	}
}
