using ProyectoProgramacion4.Proveedores;
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
        public Usuario usuarioLoggueado;
        public Compra compra;
        public List<ProductoCompra> productosPorCompra;
        public int cantArticulos = 0;

		public frmMain(Usuario usuario)
		{
			InitializeComponent();
            usuarioLoggueado = usuario;
            
            lblNombreUsuario.Text = "Bienvenido " + usuarioLoggueado.Nombre;
            lblDepartamento.Text = "Departamento de " + usuarioLoggueado.Departamento.Nom_Departamento;            
        }

        public void AutenticarUsuario()
        {
            frmMain FormularioPadre = (frmMain)this.FindForm();
            TableLayoutPanel tlpMenu = (TableLayoutPanel)FormularioPadre.Controls.Find("tlpMenu", true)[0];
      
            if(usuarioLoggueado.Departamento.Nom_Departamento == "Credito")
            {
                tlpMenu.RowStyles[4].Height = 0;
                tlpMenu.RowStyles[5].Height = 0;
                tlpMenu.RowStyles[6].Height = 0;
                tlpMenu.RowStyles[7].Height = 0;
                tlpMenu.RowStyles[8].Height = 0;
                tlpMenu.RowStyles[9].Height = 0;
                tlpMenu.RowStyles[10].Height = 0;
            }
            else
            {
                if(usuarioLoggueado.Departamento.Nom_Departamento == "Cobros")
                {
                    tlpMenu.RowStyles[4].Height = 0;
                    tlpMenu.RowStyles[5].Height = 0;
                    tlpMenu.RowStyles[6].Height = 0;
                    tlpMenu.RowStyles[7].Height = 0;
                    tlpMenu.RowStyles[8].Height = 0;
                    tlpMenu.RowStyles[9].Height = 0;
                    tlpMenu.RowStyles[10].Height = 0;

                }
                else
                {
                    if(usuarioLoggueado.Departamento.Nom_Departamento == "Tesorería")
                    {
                        tlpMenu.RowStyles[0].Height = 0;
                        tlpMenu.RowStyles[1].Height = 0;
                        tlpMenu.RowStyles[2].Height = 0;
                        tlpMenu.RowStyles[3].Height = 0;
                        tlpMenu.RowStyles[9].Height = 0;
                        tlpMenu.RowStyles[10].Height = 0;
                        tlpMenu.RowStyles[11].Height = 0;

                    }
                    else
                    {
                        if(usuarioLoggueado.Departamento.Nom_Departamento == "Contabilidad")
                        {
                            tlpMenu.RowStyles[0].Height = 0;
                            tlpMenu.RowStyles[1].Height = 0;
                            tlpMenu.RowStyles[2].Height = 0;
                            tlpMenu.RowStyles[3].Height = 0;

                            tlpMenu.RowStyles[11].Height = 0;
                        }
                        else
                        {
                            if(usuarioLoggueado.Departamento.Nom_Departamento == "Tecnología")
                            {
                                tlpMenu.RowStyles[0].Height = 0;
                                tlpMenu.RowStyles[1].Height = 0;
                                tlpMenu.RowStyles[2].Height = 0;
                                tlpMenu.RowStyles[3].Height = 0;
                                tlpMenu.RowStyles[8].Height = 0;
                                tlpMenu.RowStyles[9].Height = 0;
                                tlpMenu.RowStyles[11].Height = 0;



                            }
                            else
                            {
                                if(usuarioLoggueado.Departamento.Nom_Departamento == "Captación")
                                {
                                    tlpMenu.RowStyles[4].Height = 0;
                                    tlpMenu.RowStyles[5].Height = 0;
                                    tlpMenu.RowStyles[6].Height = 0;
                                    tlpMenu.RowStyles[7].Height = 0;
                                    tlpMenu.RowStyles[8].Height = 0;
                                    tlpMenu.RowStyles[9].Height = 0;
                                    tlpMenu.RowStyles[10].Height = 0;

                                }
                                else
                                {
                                    if(usuarioLoggueado.Departamento.Nom_Departamento == "Gerencia")
                                    {
                                        tlpMenu.RowStyles[0].Height = 0;
                                        tlpMenu.RowStyles[1].Height = 0;
                                        tlpMenu.RowStyles[2].Height = 0;
                                        tlpMenu.RowStyles[3].Height = 0;
                                        tlpMenu.RowStyles[9].Height = 0;
                                        tlpMenu.RowStyles[10].Height = 0;
                                        tlpMenu.RowStyles[11].Height = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

		private void frmMain_Load(object sender, EventArgs e)
		{
			// Crear por defecto una compra y una lista donde se pueden agregar productos y servicios
			compra = new Compra { Titulo = "Compra" };
			productosPorCompra = new List<ProductoCompra>();

			// Cargar pantalla inicial
			cambiarPantalla(new ucSolicitudes());
			frmMain FormularioPadre = (frmMain)this.FindForm();
            TableLayoutPanel tlpMenu = (TableLayoutPanel)FormularioPadre.Controls.Find("tlpMenu", true)[0];
            AutenticarUsuario();
        }

		private void crearCompra()
		{
			//TODO: **** mover esto cuando se crea la solicitud ****
			//try
			//{
			//	using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
			//	{
			//		contexto.Compra.Add(compra);
			//		contexto.SaveChanges();
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.ToString());
			//}
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
			Application.Exit();
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			volverALogin();
		}
	}
}
