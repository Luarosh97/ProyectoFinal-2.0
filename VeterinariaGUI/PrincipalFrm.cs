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
    public partial class from : Form
    {
        private ClienteService Clientes;
        private ServiciosService Servicios;
        private Empleado Empleado;
        private FacturaService Facturas;
        private MascotaService Mascotas;
        private Timer ti;
       private string connectionString;


        public from()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            
            this.Servicios = new ServiciosService(this.connectionString);
            this.Facturas = new FacturaService(this.connectionString);
            this.Mascotas = new MascotaService(this.connectionString);
            this.Clientes = new ClienteService(this.connectionString);
             this.Empleado = new Empleado();
            ////
            Empleado.Identificacion = "12892";
            Empleado.Cargo = "Peluquero";
            Empleado.Nombre = "Angel";
            Empleado.Apellido = "Casadiego";
            Empleado.Correo = "algo@algo.com";
            Empleado.Direccion = "Por ahí";
            Empleado.FechaIngreso = new DateTime().Date;
            Empleado.Telefono = "#";
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
           InitializeComponent();
            ti.Enabled = true;

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuVeterinarioFrm menuVeterinarioFrm = new MenuVeterinarioFrm();
            menuVeterinarioFrm.Show();
        }

       

        private void CitasBtn_Click(object sender, EventArgs e)
        {
          
         
        }
        

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            MenuClientesFrm menuClientesFrm = new MenuClientesFrm();
            menuClientesFrm.Show();
 }

        private void PasientesBtn_Click(object sender, EventArgs e)

        {
            MenuMascotasFrm menuMascotasFrm = new MenuMascotasFrm();
            menuMascotasFrm.Show();

        }

        private void ServiciosBtn_Click(object sender, EventArgs e)
        {
            MenuServiciosFrm ServicioFrm = new MenuServiciosFrm();
            ServicioFrm.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {  
            FacturacionsFrm FacturarServicioFrm = new FacturacionsFrm(this.Clientes, this.Servicios,this.Facturas, this.Empleado);
            FacturarServicioFrm.Show();
            

        }

        private void eventoTimer(Object sender, EventArgs e)
        {
            DateTime Hoy = DateTime.Now;
            LblHora.Text = Hoy.ToString("hh:mm:ss tt");
            LblFecha.Text= DateTime.Now.ToLongDateString();

        }

        }

        }

