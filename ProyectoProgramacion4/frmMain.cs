﻿using ProyectoProgramacion4.Proveedores;
using ProyectoProgramacion4.Solicitudes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloBD;


namespace ProyectoProgramacion4
{
	public partial class frmMain : Form
	{
		public frmMain(string nombre, string departamento)
		{
			InitializeComponent();
            using (ProyectoProgra4Entities context = new ProyectoProgra4Entities()) {
                lblNombreUsuario.Text = "Bienvenido " + nombre;
                lblDepartamento.Text = "Departamento de " + departamento;
            }
        }

		private void frmMain_Load(object sender, EventArgs e)
		{
			treeView.ExpandAll();
            //treeView.Nodes.Remove(treeView.Nodes["NodoAdministracion"].Nodes["NodoAdministracion1"]);
            
			//cambiarPantalla(new ucProveedores());
            cambiarPantalla(new ucSolicitudes());
        }

		public void cambiarPantalla(UserControl pantalla)
		{
			pnlContenido.Controls.Clear();
			pnlContenido.Controls.Add(pantalla);
			pnlContenido.Refresh();
		}

		private void volverALogin()
		{
			this.Hide();
			frmLogin l = new frmLogin();
			l.Show();
		}
		
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
			volverALogin();
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			volverALogin();
		}
    }
}
