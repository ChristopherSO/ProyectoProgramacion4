using ModeloBD;
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
			try
			{
				using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
				{
					dgvProveedores.DataSource = contexto.Proveedores.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnVerProductos_Click(object sender, EventArgs e)
		{
			frmMain FormularioPadre = (frmMain)this.FindForm();
			FormularioPadre.cambiarPantalla(new ucProductos());
		}
	}
}
