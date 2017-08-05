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
		}

		private void cargarProductos()
		{
			try
			{
				using (ModeloBD. ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
				{
					contexto.Configuration.LazyLoadingEnabled = false;
					dgvProductos.DataSource = contexto.Producto.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
