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
using Entity;
using BLL;

namespace VeterinariaGUI
{
    public partial class FacturacionsFrm : Form
    {
        private ClienteService ClienteService;
        private ServiciosService Servicios;
        private FacturaService FacturaService;
        private Empleado Empleado;
        private Cliente Cliente;
        private ResponseFacturaBusqueda respuest;



        private Factura Factura;
        private DetalleFactura Detalle;
        private List<DetalleFactura> Detalles;
        private List<Servicio> servicios;
        private List<Servicio> seleccion;
        private MascotaService mascotas;

        public FacturacionsFrm(
            ClienteService _Clientes, 
            ServiciosService _Servicios, 
            FacturaService _facturaService, 
            Empleado _Empleado
            )             
        {
            seleccion = new List<Servicio>();
            Detalles = new List<DetalleFactura>();
       
            ClienteService = _Clientes;
            Servicios = _Servicios;
            Empleado = _Empleado;
            FacturaService = _facturaService;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            FacturaService = _facturaService;
            InitializeComponent();
            this.PreCharge();
        }

     

        public FacturacionsFrm(FacturaService facturas)
        {
            FacturaService = facturas;
        }

        

        private void PreCharge()
        {  
            textBox2.Text = 19 + "";
            textBox3.Text = 30+"";
            textBox4.Text = 10 + "";
            label14.Text = this.Empleado.NombreCompleto();
           

            var respuesta = this.Servicios.Consultar();
            if (respuesta.Error)
                MessageBox.Show(respuesta.Mensaje);
            else
            {
                dataGridView1.DataSource = respuesta.servicios;
                this.servicios = (List<Servicio>)respuesta.servicios;
            }
   
            dataGridView2.DataSource = this.seleccion;
           
}

        private void PintarSeleccionados(List<Servicio> s)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (this.Factura.ConsultarDetalles().Count > 0)
            {
                var Fac = this.Factura;
                Fac.CalcularSubtotal();
                MessageBox.Show(Fac.ToString()); 
                MessageBox.Show(this.FacturaService.Guardar(Fac));
            }
            else
            {
                MessageBox.Show("Agrega algún servicio");
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Informe De facturas";
            saveFileDialog.InitialDirectory = @"c:/document";
            saveFileDialog.DefaultExt = "pdf";
            string filename = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                respuest = FacturaService.Buscar();
                filename = saveFileDialog.FileName;
                if (filename != "" && respuest.factura != null)
                {
                    string mensaje = FacturaService.GuardarPdf(respuest.factura, filename);

                    MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (Cliente == null)
            {
                MessageBox.Show("Seleccione primero el cliente");
                return;
            }

            try
            {
                Factura.PcjDescuento = Math.Abs(decimal.Parse(textBox4.Text));
                textBox4.Text = Factura.PcjDescuento + "";
            }
            catch (Exception)
            {
                Factura.PcjDescuento = 0;
                MessageBox.Show("Rectifique el descuento");
                return;
            }

            try
            {
                Factura.PcjIva = Math.Abs(decimal.Parse(textBox2.Text));
                textBox2.Text = Factura.PcjIva + "";
            }
            catch (Exception)
            {
                Factura.PcjIva = 0;
                MessageBox.Show("Rectifique el Iva");
                return;
            }

            try
            {
                Factura.PcjGanancia = Math.Abs(decimal.Parse(textBox3.Text));
                textBox3.Text = Factura.PcjGanancia + "";
            }
            catch (Exception)
            {
                Factura.PcjGanancia = 0;
                MessageBox.Show("Rectifique la ganancia");
                return;
            }

            var row = dataGridView1.CurrentRow;
           var servicio = servicios[row.Cells[0].RowIndex];

            this.seleccion.Add(servicio);
            this.PintarSeleccionados(this.seleccion);

            var Mascota = this.Cliente.mascotas[comboBox1.SelectedIndex];
            Factura.AgregarDetalles (servicio, Mascota);
            this.Factura.Cliente = Cliente;
            this.Factura.Empleado= Empleado;
            Factura.CalcularSubtotal();
            Factura.FechaFactura= DateFechaFactura.Value;
            label12.Text = Factura.SubTotal + "";
            label13.Text = Factura.Total + "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                var respuesta = this.ClienteService.Buscar(textBox1.Text.Trim());
                if (!respuesta.Error)
                {
                    Factura = new Factura(respuesta.cliente, Empleado);
                    this.ClienteCmabiado(respuesta.cliente);
                   
                }  

              
            }
        }

        private void ClienteCmabiado(Cliente c)
        {
            this.Cliente = c;

            label6.Text = c.NombreCompleto();
            var i = 0;
            comboBox1.Items.Clear();

            var range = new string[c.mascotas.Count];

            foreach (var item in c.mascotas)
            {
                range[i] = item.NombreMascota;
               
                i++;
            }
          
            this.comboBox1.Items.AddRange(range);

            if (comboBox1.Items.Count>0)
                comboBox1.SelectedIndex = 0;
           
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (textBox2.Text == null) textBox2.Text = "0";
                if (textBox2.Text.Trim().Length < 1) textBox2.Text = "0";
                try
                {
                    Factura.PcjIva = Math.Abs(decimal.Parse(textBox2.Text));
                    textBox2.Text = Factura.PcjIva + "";
                }
                catch (Exception)
                {
                    Factura.PcjIva = 0;
                    MessageBox.Show("Rectifique el descuento");
                }
              
                label12.Text = Factura.SubTotal + "";
                label13.Text = Factura.Total + "";

            }

        }

        private void textBox3_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (textBox3.Text == null) textBox3.Text = "0";
                if (textBox3.Text.Trim().Length < 1) textBox3.Text = "0";
                try
                {
                    Factura.PcjGanancia = Math.Abs(decimal.Parse(textBox3.Text));
                    textBox3.Text = Factura.PcjGanancia + "";
                }
                catch (Exception)
                {
                    Factura.PcjGanancia = 0;
                    MessageBox.Show("Rectifique el Iva");
                }
            
                label12.Text = Factura.SubTotal + "";
                label13.Text = Factura.Total + "";

            }
        }

        private void textBox4_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (textBox4.Text == null) textBox4.Text = "0";
                if (textBox4.Text.Trim().Length < 1) textBox4.Text = "0";
                try
                {
                    Factura.PcjDescuento = Math.Abs(decimal.Parse(textBox4.Text));
                    textBox4.Text = Factura.PcjDescuento + "";
                }
                catch (Exception)
                {
                    Factura.PcjDescuento = 0;
                    MessageBox.Show("Rectifique la ganancia");
                }
               
                label12.Text = Factura.SubTotal + "";
                label13.Text = Factura.Total + "";

            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuFacturasFrm menu = new MenuFacturasFrm();
            menu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
