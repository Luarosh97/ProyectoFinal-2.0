using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using Entity;

namespace VeterinariaGUI
{
    public partial class MenuFacturasFrm : Form
    {
        FacturaService facturaservice;
        Response respuesta = new Response();
        public MenuFacturasFrm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
           facturaservice = new FacturaService(connectionString);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            respuesta = facturaservice.Consultar();
            dataGridView1.Rows.Clear();

            consultar();
        }

        private void consultar()
        {
           
            LlenarDataGridView(respuesta.facturas);
        }

        public void LlenarDataGridView(IList<Factura> facturas)
        {
            foreach (var item in facturas)
            {
                dataGridView1.Rows.Add(item.Codigo,item.Cliente.Identificacion, item.Empleado.Identificacion, item.PcjIva,item.Iva,item.PcjDescuento,item.Descuento, item.PcjGanancia, item.Ganancia, item.NServicios,item.SubTotal,item.Total,item.FechaFactura);
            }

        }
    }
}
