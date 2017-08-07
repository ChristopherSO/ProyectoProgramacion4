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
		private List<ProductoCompra> listaCompras;

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
			listaCompras = formularioPadre.productosPorCompra;

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

		private void btnSolicitar_Click(object sender, EventArgs e)
		{
			if (listaCompras.Count() > 0)
			{
				frmSolicitudDeCompra modal = new frmSolicitudDeCompra(
					formularioPadre.usuarioLoggueado, 
					formularioPadre.compra,
					formularioPadre.productosPorCompra);
				modal.ShowDialog();
			}
			else
			{
				MessageBox.Show(
					"No se puede hacer una solicitud con una lista de compras vacía.",
					"Aviso",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}
	}
}
