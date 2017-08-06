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

namespace ProyectoProgramacion4
{
	public partial class ucMenuLateral : UserControl
	{
		public ucMenuLateral()
		{
			InitializeComponent();
		}

		private void lnkProveedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmMain FormularioPadre = (frmMain)this.FindForm();
			FormularioPadre.cambiarPantalla(new ucProveedores());
		}

		private void lnkAdmProductos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmMain FormularioPadre = (frmMain)this.FindForm();
			FormularioPadre.cambiarPantalla(new ucProductos());
		}

		private void lnkAdmServicios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmMain FormularioPadre = (frmMain)this.FindForm();
			FormularioPadre.cambiarPantalla(new ucServicios());
		}
	}
}
