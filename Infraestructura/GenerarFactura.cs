using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;

namespace Infraestructura
{
    public class GenerarFactura
    {
        public void GuardarPdf(Factura factura, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion Veterinaria");
            document.Open();
           
            Paragraph parrafo = (new Paragraph("VETERINARIA SOFT"));
            parrafo.Alignment = Element.ALIGN_CENTER;
            document.Add(parrafo);
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph(" REPORTE DE FACTURA REALIZADA"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"FACTURA N° : {factura.Codigo}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"FECHA REMISION : {factura.FechaFactura.Date}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"CC CIENTE : {factura.Cliente.Identificacion}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"CC EMPLEADO: {factura.Empleado.Identificacion}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"DESCUENTO : {factura.Descuento}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"IVA TOTAL : {factura.Iva}"));
            document.Add(new Paragraph("\n"));
            Paragraph parrafo2 = (new Paragraph($"SUBTOTAL° : {factura.SubTotal}"));
            parrafo2.Alignment = Element.ALIGN_RIGHT;
            document.Add(parrafo2);
            document.Add(new Paragraph("\n"));
            Paragraph parrafo1 = (new Paragraph($"TOTAL° : {factura.Total}"));
            parrafo1.Alignment = Element.ALIGN_RIGHT;
            document.Add(parrafo1);
            document.Add(new Paragraph("\n"));

            document.Close();
        }

       
    }
}
