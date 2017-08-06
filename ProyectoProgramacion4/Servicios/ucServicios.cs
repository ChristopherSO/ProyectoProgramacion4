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
		public string NombreProveedor { get; set; }

		public ucServicios()
		{
			InitializeComponent();
			dgvServicios.AutoGenerateColumns = false;
		}

		private void ucServicios_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			lblNombreProveedor.Text = NombreProveedor;
			cargarServicios();

			if (NombreProveedor == null)
			{
				// Ocultar la fila que muestar el Proveedor
				TableLayoutPanel tlpPrincipal = (TableLayoutPanel)Controls[0];
				tlpPrincipal.RowStyles[1].Height = 0;
			}
		}

		private void cargarServicios()
		{
			try
			{
				using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
				{
					if (NombreProveedor == null)
					{
						dgvServicios.DataSource = contexto.Producto
						.Where(x => x.Tipo == "Servicio")
						.Select(x => new {
							x.Proveedor.Nom_Proveedor,
							x.Tipo,
							x.Nom_Producto,
							x.Precio
						}).ToList();
					} else
					{
						dgvServicios.DataSource = contexto.Producto
						.Where(x => x.Tipo == "Servicio" && x.Proveedor.Nom_Proveedor.Equals(NombreProveedor))
						.Select(x => new {
							x.Proveedor.Nom_Proveedor,
							x.Tipo,
							x.Nom_Producto,
							x.Precio
						}).ToList();

						dgvServicios.Columns[0].Visible = false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
