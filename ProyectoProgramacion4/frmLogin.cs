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

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R74K5D9H\SQLEXPRESS;Initial Catalog=ProyectoProgra4;Integrated Security=True");



        public void Logear(string usuario, string contrasena) {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select u.Nombre, d.Nom_Departamento from Usuario u join Departamento d on d.Id_Departamento = u.Id_Departamento where u.Nom_Login = @usuario AND u.Contraseña = @contrasena",con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count == 1) {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "frmMain")
                    {
                        new frmMain().Show();
                    }
                    else {
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
			this.Hide();
            new frmMain().Show();
            //Logear(this.txtusario.Text,this.txtcontra.Text);
        }
	}
}
