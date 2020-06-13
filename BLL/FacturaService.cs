using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Infraestructura;

namespace BLL
{
    public class FacturaService
    {
        private readonly ConnectionManager Conexion;
        private readonly FacturaRepository FacturaRepo;
        private readonly DetalleRepository DetalleRepo;
        private readonly ClienteRepository ClienteRepo;
        private readonly EmpleadoRepository EmpleadoRepo;
        private Response Response;



        public FacturaService(string _conection)
        {
            this.Conexion = new ConnectionManager(_conection);
            this.FacturaRepo = new FacturaRepository(this.Conexion);
            this.DetalleRepo = new DetalleRepository(this.Conexion);
            this.EmpleadoRepo = new EmpleadoRepository(this.Conexion);
            this.ClienteRepo = new ClienteRepository(this.Conexion);         
        }

        public string Guardar(Factura fact)
        {
     
            try
            {
                fact.AgregarIdFactura(Last()+1);
                Conexion.Open();
                
                FacturaRepo.Guardar(fact);
                foreach (var item in fact.ConsultarDetalles())
                {
                    DetalleRepo.Guardar(item);
                }
             

                Conexion.Close();
                return $"Se facturó";
            }
            catch (Exception e)
            {
                Conexion.Close();
                return $"Error de la Aplicacion: {e.Message}";
            }

        }


        public string GuardarPdf(Factura factura, string filename)
        {
            GenerarFactura GenerarPdf = new GenerarFactura();
            try
            {
                GenerarPdf.GuardarPdf(factura, filename);
                return "Se genró el Documento satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error al crear docuemnto" + e.Message;
            }
        }


        public int Last() {

           
            Conexion.Open();

            int LastService= FacturaRepo.Last();
            Conexion.Close();
            return LastService;
           
        }
        public Response Consultar()
        {
            Response = new Response();
            try
            {
                Conexion.Open();
                var facts = FacturaRepo.Consultar();
                for (int i = 0; i < facts.Count; i++)
                {
                    facts[i].AgregarDetalle((List<DetalleFactura>)DetalleRepo.BuscarFac(facts[i].Codigo));
                }
                Response.facturas = facts;
                Conexion.Close();

                if (Response.facturas.Count > 0)
                {
                    Response.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    Response.Mensaje = "No hay datos para consultar";
                }
                Response.Error = false;

                return Response;
            }
            catch (Exception e)
            {
                Response.Mensaje = $"Error de la Aplicacion: {e.Message}";
                Response.Error = true;

                Conexion.Close();
                return Response;
            }

        }

      



        public ResponseFacturaBusqueda Buscar()
        {
            ResponseFacturaBusqueda ResponseBusqueda = new ResponseFacturaBusqueda();

            try
            {
                Conexion.Open();
                var Fac = FacturaRepo.BuscarInvoice();

                Fac.AgregarDetalle((List<DetalleFactura>)DetalleRepo.BuscarFac(Fac.Codigo));
                Fac.Cliente = ClienteRepo.Buscar(Fac.Cliente.Identificacion);
                Fac.Empleado = EmpleadoRepo.Buscar(Fac.Empleado.Identificacion);

                ResponseBusqueda.factura = FacturaRepo.BuscarInvoice();

                Conexion.Close();
                ResponseBusqueda.Mensaje = (ResponseBusqueda.factura != null) ? "Se encontró la factura solicitada" : $"La factura {0} no existe";
                ResponseBusqueda.Error = false;
                return ResponseBusqueda;
            }
            catch (Exception e)
            {
                ResponseBusqueda.Mensaje = $"Error de la Aplicacion: {e.Message}";
                ResponseBusqueda.Error = true;
                Conexion.Close();
                return ResponseBusqueda;
            }
        }


    }

        }

 