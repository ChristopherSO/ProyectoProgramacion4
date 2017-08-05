using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacion4.Solicitudes
{
    public class SolicitudViewModel
    {
        public int IdSolicitud { get; set; }
        public string NombreDepartamento { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public decimal MontoCompra { get; set; }
        public string RequiereAprobacionJefe { get; set; }
        public string RequiereAprobacionGerencia { get; set; }
        public string Estado { get; set; }

    }
}
