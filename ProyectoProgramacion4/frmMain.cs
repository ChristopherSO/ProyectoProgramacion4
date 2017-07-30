using ProyectoProgramacion4.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion4
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			treeView.ExpandAll();
			cambiarPantalla(new ucProveedores());
		}

		public void cambiarPantalla(UserControl pantalla)
		{
			pnlContenido.Controls.Clear();
			pnlContenido.Controls.Add(pantalla);
			pnlContenido.Refresh();
		}
	}
}
