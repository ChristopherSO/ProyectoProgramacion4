using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion4.PantallaInicial
{
    public partial class ucPantallaInicia : UserControl
    {
        public ucPantallaInicia()
        {
            InitializeComponent();
            cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos cliente =  new cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos();
            List<string> Moneda = new List<string>();
            DataSet DolarCompra = cliente.ObtenerIndicadoresEconomicos("317","01/01/2017","01/01/2018","Sergio Morales","N");
            DataSet DolarVenta = cliente.ObtenerIndicadoresEconomicos("318", "01/01/2017", "01/01/2018", "Sergio Morales", "N");
            Moneda.Add(DolarCompra.Tables[0].Rows[0].ItemArray[1].ToString());
            Moneda.Add(DolarCompra.Tables[0].Rows[0].ItemArray[2].ToString());
            Moneda.Add(DolarVenta.Tables[0].Rows[0].ItemArray[2].ToString());
            if (DolarCompra.Tables[0].Rows[0].ItemArray[1].ToString() != "01/01/2018")
            {
                foreach (var item in Moneda)
                {
                    dgvMoneda.Rows.Add(item);
                }
            }
                
            
            //dgvMoneda.DataSource = (DolarVenta);
            //dgvMoneda.Rows.Add(DolarCompra);
            //dgvMoneda.Rows.Add(DolarVenta);
        }
    }
}
