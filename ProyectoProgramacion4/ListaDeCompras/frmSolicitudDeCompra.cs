using ModeloBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion4.ListaDeCompras
{
	public partial class frmSolicitudDeCompra : Form
	{
		Usuario usuarioLoggueado;
		Compra compra;
		List<ProductoCompra> listaCompras;

		public frmSolicitudDeCompra(Usuario usuarioLoggueado, Compra compra, List<ProductoCompra> productosPorCompra)
		{
			InitializeComponent();
			this.usuarioLoggueado = usuarioLoggueado;
			this.compra = compra;
			this.listaCompras = productosPorCompra;
		}

		private void btnSolicitar_Click(object sender, EventArgs e)
		{
			compra.Titulo = (tbTitulo.Text == "") ? "Compra sin título" : tbTitulo.Text;
			compra.Descripcion = tbDescripcion.Text;

			Solicitud solicitud = new Solicitud
			{
				Id_Usuario = usuarioLoggueado.Id_Usuario,
				Id_Compra =  compra.Id_Compra,
				Fecha_Solicitud = new DateTime(),
				Estado = "Solicitada",
				Usuario = usuarioLoggueado,
				Compra = compra
			};

			try
			{
				using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
				{
					contexto.Compra.Add(compra);
					contexto.ProductoCompra.Concat(listaCompras);
					contexto.Solicitud.Add(solicitud);
					contexto.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
