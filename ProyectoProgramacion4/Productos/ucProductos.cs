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
		private frmMain formularioPadre;
		public Proveedor proveedor;

		public ucProductos()
		{
			InitializeComponent();
			dgvProductos.AutoGenerateColumns = false;
		}

		private void ucProductos_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			formularioPadre = (frmMain)this.FindForm();

			cargarProductos();
			lblCantArticulos.Text = "" + formularioPadre.cantArticulos;

			if (proveedor == null)
			{
				// Ocultar la fila que muestar el Proveedor
				TableLayoutPanel tlpPrincipal = (TableLayoutPanel)Controls[0];
				tlpPrincipal.RowStyles[2].Height = 0;
			}
		}

		private void cargarProductos()
		{
			try
			{
				using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
				{
					if (proveedor == null)
					{
						dgvProductos.DataSource = contexto.Producto
						.Where(x => x.Tipo == "Producto")
						.Select(x => new {
							x.Proveedor.Nom_Proveedor,
							x.Tipo,
							x.Nom_Producto,
							x.Precio,
							x.Id_Producto,
							x.Id_Proveedor
						}).ToList();
					}
					else
					{
						dgvProductos.DataSource = contexto.Producto
						.Where(x => x.Tipo == "Producto" && x.Id_Proveedor == proveedor.Id_Proveedor)
						.Select(x => new {
							x.Proveedor.Nom_Proveedor,
							x.Tipo,
							x.Nom_Producto,
							x.Precio,
							x.Id_Producto,
							x.Id_Proveedor
						}).ToList();

						dgvProductos.Columns[0].Visible = false;
						lblNombreProveedor.Text = proveedor.Nom_Proveedor;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			var filaSeleccionada = dgvProductos.SelectedRows[0];

			Producto producto = new Producto
			{
				Proveedor = proveedor,
				Tipo = (string)filaSeleccionada.Cells[1].Value,
				Nom_Producto = (string)filaSeleccionada.Cells[2].Value,
				Precio = (decimal)filaSeleccionada.Cells[3].Value,
				Id_Producto = (int)filaSeleccionada.Cells[4].Value,
				Id_Proveedor = (int)filaSeleccionada.Cells[5].Value
			};

			ProductoCompra productoCompra = new ProductoCompra
			{
				Id_Producto = producto.Id_Producto,
				Id_Compra = formularioPadre.compra.Id_Compra,
				Producto = producto,
				Compra = formularioPadre.compra
			};

			formularioPadre.productosPorCompra.Add(productoCompra);
			formularioPadre.cantArticulos++;
			lblCantArticulos.Text = "" + formularioPadre.cantArticulos;

			MessageBox.Show("Se agregó el servicio " + producto.Nom_Producto + " a la lista de compras.");

		}
	}
}
