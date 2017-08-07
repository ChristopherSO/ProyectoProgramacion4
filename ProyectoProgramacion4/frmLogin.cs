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
using System.Data.SqlClient;

namespace ProyectoProgramacion4
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();

        }

        public void Login()
        {
            try
            {
                Usuario usuario;

                using (ProyectoProgra4Entities context = new ProyectoProgra4Entities())
                {
                    List<Usuario> usuarios = context.Usuario.ToList();

                    usuario = usuarios.Where(u => u.Nom_Login == txtusario.Text && u.Contraseña == txtcontra.Text).FirstOrDefault();

                    if (usuario != null)
                    {
                        MessageBox.Show("Inicio de sesión correcto");
                        this.Hide();
                        frmMain m = new frmMain(usuario);
                        m.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta");
                    }


                }    
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

		private void lblSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
            Login();
		}

		private void txtcontra_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Login();
			}
		}

		private void txtusario_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Login();
			}
		}
    }
}
