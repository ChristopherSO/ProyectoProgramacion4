using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloBD;

namespace ProyectoProgramacion4.Solicitudes
{
    public partial class ucSolicitudes : UserControl
	{
        public ucSolicitudes()
        {
            InitializeComponent();
        }

        private void ucSolicitudes_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LlenarTabla();
        }

        private void LlenarTabla()
        {
            try
            {
                using (ProyectoProgra4Entities contexto = new ProyectoProgra4Entities())
                {
					BindingSource bindingSource = new BindingSource();
					bindingSource.DataSource = contexto.Solicitud.Select(x => new SolicitudViewModel
					{
						IdSolicitud = x.Id_Solicitud,
						NombreDepartamento = x.Usuario.Departamento.Nom_Departamento,
						FechaSolicitud = x.Fecha_Solicitud,
						MontoCompra = (decimal)x.Compra.Valor,
						RequiereAprobacionJefe = (x.Compra.Valor > 1000000) ? "No" : "Sí",
						RequiereAprobacionGerencia = (x.Compra.Valor >= 5000000) ? "No" : "Sí",
						Estado = x.Estado
					}).ToList();
					dgvSolicitudes.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
