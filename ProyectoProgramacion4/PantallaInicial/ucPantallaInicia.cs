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
            cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos cliente = new cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos();
            List<string> Moneda = new List<string>();
            DataSet DolarCompra = cliente.ObtenerIndicadoresEconomicos("317", "01/07/2017", "07/08/2017", "Sergio Morales", "N");
            DataSet DolarVenta = cliente.ObtenerIndicadoresEconomicos("318", "01/07/2017", "07/08/2017", "Sergio Morales", "N");


                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[0].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[0].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[0].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[1].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[1].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[1].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[2].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[2].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[2].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[3].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[3].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[3].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[4].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[4].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[4].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[5].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[5].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[5].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[6].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[6].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[6].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[7].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[7].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[7].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[8].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[8].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[8].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[9].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[9].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[9].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[10].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[10].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[10].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[11].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[11].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[11].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[12].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[12].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[12].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[13].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[13].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[13].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[14].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[14].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[14].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[15].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[15].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[15].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[16].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[16].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[16].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[17].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[17].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[17].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[18].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[18].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[18].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[19].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[19].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[19].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[20].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[20].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[20].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[21].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[21].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[21].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[22].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[22].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[22].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[23].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[23].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[23].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[24].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[24].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[24].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[25].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[25].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[25].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[26].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[26].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[26].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[27].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[27].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[27].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[28].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[28].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[28].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[29].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[29].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[29].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[30].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[30].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[30].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[31].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[31].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[31].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[32].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[32].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[32].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[33].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[33].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[33].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[34].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[34].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[34].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[35].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[35].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[35].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[36].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[36].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[36].ItemArray[2].ToString());
                dgvMoneda.Rows.Add(DolarCompra.Tables[0].Rows[37].ItemArray[1].ToString(), DolarCompra.Tables[0].Rows[37].ItemArray[2].ToString(), DolarVenta.Tables[0].Rows[37].ItemArray[2].ToString());

        }
    }
}
