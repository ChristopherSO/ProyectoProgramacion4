using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion4
{
	public partial class BaseUserControl : UserControl
	{
		protected frmMain FormularioPadre;

		public BaseUserControl()
		{
			FormularioPadre = (frmMain)this.FindForm();
		}
	}
}
