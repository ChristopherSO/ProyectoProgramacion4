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

namespace ProyectoProgramacion4.Servicios
{
	public partial class ucServicios : UserControl
	{
		private frmMain formularioPadre;
		public Proveedor proveedor;

		public ucServicios()
		{
			InitializeComponent();
			dgvServicios.AutoGenerateColumns = false;
		}

		private void ucServicios_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			formularioPadre = (frmMain)this.FindForm();

			cargarServicios();
			lblCantArticulos.Text = "" + formularioPadre.cantArticulos;

			if (proveedor == null)
			{
				// Ocultar la fila que muestar el Proveedor
				TableLayoutPanel tlpPrincipal = (TableLayoutPanel)Controls[0];
				tlpPrincipal.RowStyles[2].Height = 0;
			}
		}

		private void cargarServicios()
		{
			try
			{
				using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
				{
					if (proveedor == null)
					{
						dgvServicios.DataSource = contexto.Producto
						.Where(x => x.Tipo == "Servicio")
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
						dgvServicios.DataSource = contexto.Producto
						.Where(x => x.Tipo == "Servicio" && x.Id_Proveedor == proveedor.Id_Proveedor)
						.Select(x => new {
							x.Proveedor.Nom_Proveedor,
							x.Tipo,
							x.Nom_Producto,
							x.Precio,
							x.Id_Producto,
							x.Id_Proveedor
						}).ToList();

						dgvServicios.Columns[0].Visible = false;
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
			var filaSeleccionada = dgvServicios.SelectedRows[0];

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
