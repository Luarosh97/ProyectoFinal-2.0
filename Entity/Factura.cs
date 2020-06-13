using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura

    {
        public Factura()
        {

        }

        public Factura(Cliente cliente, Empleado empleado) {
            Cliente = cliente;
            Empleado = empleado;
            Detalles = new List<DetalleFactura>();
            PcjDescuento = 10;
            PcjGanancia = 30;
            PcjIva = 19;

        }
     

        public int Codigo { get; set; } 
        public DateTime FechaFactura { get; set; }

        public Cliente Cliente { get; set; }

        public Empleado Empleado { get; set; }

       public List<DetalleFactura> Detalles { get; set; }

        public void AgregarIdFactura(int codigo) {
            Codigo = codigo;
            foreach (var detalle in Detalles)
            {
                detalle.Factura = codigo;
            }
        }

        public void AgregarDetalle(List <DetalleFactura> detalles) {
            Detalles = detalles;
        }

     

        public void AgregarDetalles(Servicio servicio,Mascota mascota) {
            DetalleFactura detalles = new DetalleFactura(servicio,mascota);
            Detalles.Add(detalles);

        }
        public List<DetalleFactura> ConsultarDetalles() {
            return Detalles;
        }

        public decimal PcjIva { get; set; }

        public decimal Iva
        {
            get
            {
                return this.SubTotal * this.PcjIva / 100;
            }
           
        }

        public decimal SubTotal { get; set; }

        public decimal PcjGanancia { get; set; } 

        public decimal Ganancia
        {   get
            {
                return  this.SubTotal * this.PcjGanancia / 100;
            }
          
        } 

        public decimal PcjDescuento { get; set; }

        public decimal Descuento { get{ return this.SubTotal * this.PcjDescuento / 100; } }

        public int NServicios { get { return this.Detalles.Count; } }

        public decimal Total { get { return  this.SubTotal + this.Iva + this.Ganancia - this.Descuento; } }

        public override string ToString()
        {
            return $"Cliente: {Cliente.NombreCompleto()}\nEmpleado: {Empleado.NombreCompleto()}\nServicios: {NServicios}\nSubTotal: {SubTotal}\nTotal: {Total}\nDescuento: {Descuento}\nGanancia: {Ganancia}\n";
        }
        public void CalcularSubtotal()
        {
            SubTotal = Detalles.Sum(x => x.Servicio.Base);
        }
    }
}


   
