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

namespace ProyectoProgramacion4.ListaDeCompras
{
	public partial class ucListaDeCompras : UserControl
	{
		private frmMain formularioPadre;

		public ucListaDeCompras()
		{
			InitializeComponent();
			dgvCompras.AutoGenerateColumns = false;
		}

		private void ListaDeCompras_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			formularioPadre = (frmMain)this.FindForm();

			cargarListaCompras();
		}

		private void cargarListaCompras()
		{
			var listaCompras = formularioPadre.productosPorCompra;

			dgvCompras.DataSource = listaCompras.Select(x => new {
				x.Producto.Proveedor.Nom_Proveedor,
				x.Producto.Tipo,
				x.Producto.Nom_Producto,
				x.Producto.Precio,
				x.Producto.Id_Producto,
				x.Producto.Id_Proveedor
			}).ToList();

			lblTotal.Text = "" + listaCompras.Sum(x => x.Producto.Precio);
		}
	}
}
