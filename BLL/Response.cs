using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class Response
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList <Factura> facturas{ get; set; }
      
    }

    public class ResponseFacturaBusqueda
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }

        public Factura factura { get; set; }
    }


}
