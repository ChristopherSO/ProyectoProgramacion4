using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoProgramacion4.Proveedores;
using ProyectoProgramacion4.Productos;
using ProyectoProgramacion4.Servicios;
using ProyectoProgramacion4.Solicitudes;

namespace ProyectoProgramacion4
{
	public partial class ucMenuLateral : UserControl
	{
		private frmMain formularioPadre;

		public ucMenuLateral()
		{
			InitializeComponent();
		}

		private void CambiarPantalla(UserControl pantalla)
		{
			if (formularioPadre == null)
			{
				formularioPadre = (frmMain)this.FindForm();
			}
			formularioPadre.cambiarPantalla(pantalla);
		}

		private void lnkProveedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CambiarPantalla(new ucProveedores());
		}

		private void lnkAdmProductos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CambiarPantalla(new ucProductos());
		}

		private void lnkAdmServicios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CambiarPantalla(new ucServicios());
		}

		private void lnkProductos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CambiarPantalla(new ucProductos());
		}

		private void lnkServicios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CambiarPantalla(new ucServicios());
		}

		private void lnkPorProveedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CambiarPantalla(new ucProveedores());
		}

		private void lnkSolicitudes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CambiarPantalla(new ucSolicitudes());
		}
	}
}
