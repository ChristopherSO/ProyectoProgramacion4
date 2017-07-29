using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion4.Productos
{
	public partial class ucProductos : UserControl
	{
		List<string> listaProductos;

		public ucProductos()
		{
			InitializeComponent();
		}

		private void ucProductos_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			cargarProductos();
		}

		private void cargarProductos()
		{
			listaProductos = new List<string>
			{
				"Producto 1",
				"Producto 2",
				"Producto 3",
				"Producto 4",
				"Producto 5"
			};
			dgvProductos.DataSource = listaProductos.Select(x => new { Nombre = x }).ToList(); ;
		}
	}
}
