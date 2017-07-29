﻿using System;
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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void lblSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
			this.Hide();
			(new frmMain()).ShowDialog();
			this.Close();
		}
	}
}
