using ModeloBD;
using ProyectoProgramacion4.Productos;
using ProyectoProgramacion4.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoProgramacion4.Proveedores
{
	public partial class ucProveedores : UserControl
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
			var filaSeleccionada = dgvProveedores.SelectedRows[0];

			ucProductos pantalla = new ucProductos();
			pantalla.proveedor = new Proveedor
			{
				Id_Proveedor = (int)filaSeleccionada.Cells["IdProveedor"].Value,
				Nom_Proveedor = (string)filaSeleccionada.Cells["Nombre"].Value,
				Descripcion = (string)filaSeleccionada.Cells["Descripcion"].Value,
			};

			frmMain FormularioPadre = (frmMain)this.FindForm();
			FormularioPadre.cambiarPantalla(pantalla);
		}

		private void btnVerServicios_Click(object sender, EventArgs e)
		{
			var filaSeleccionada = dgvProveedores.SelectedRows[0];

			ucServicios pantalla = new ucServicios();
			pantalla.proveedor = new Proveedor
			{
				Id_Proveedor = (int)filaSeleccionada.Cells["IdProveedor"].Value,
				Nom_Proveedor = (string)filaSeleccionada.Cells["Nombre"].Value,
				Descripcion = (string)filaSeleccionada.Cells["Descripcion"].Value,
			};

			frmMain FormularioPadre = (frmMain)this.FindForm();
			FormularioPadre.cambiarPantalla(pantalla);
		}
	}
}
