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
                bool existe;
                string depar = "";
                using (ProyectoProgra4Entities context = new ProyectoProgra4Entities())
                {
                    List<Usuario> usuarios = context.Usuario.ToList();
                    List<Departamento> Department = context.Departamento.ToList();
                    existe = usuarios.Any(u => u.Nom_Login == txtusario.Text && u.Contraseña == txtcontra.Text);
                    var join = from Usuario in usuarios
                               join Departamento in Department on
                               Usuario.Id_Departamento equals Departamento.Id_Departamento
                               select new { Departamento.Nom_Departamento };
                              

                    //existe = usuarios.Select(u => u.Id_Departamento));
                    //existe = Department.Select(d => d.Nom_Departamento).Where(d => d)
                    //existe = usuarios.Select(u=>u.Id_Departamento)

                }
                if (existe)
                {
                    this.Hide();
                    frmMain m = new frmMain(txtusario.Text,depar);
                    m.Show();

                }
                else {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
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
	}
}
