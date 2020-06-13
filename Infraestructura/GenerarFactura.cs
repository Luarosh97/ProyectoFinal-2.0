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
            document.Add(new Paragraph("VETERINARIA SOFT"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("Reporte De Factura Realizada"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"FACTURA N° : {factura.Codigo}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Fecha Remision : {factura.FechaFactura.Date}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Identificacion Cliente : {factura.Cliente.Identificacion}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Identificacion Empleado : {factura.Empleado.Identificacion}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Ganancia de los servicios : {factura.Ganancia}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Descuento : {factura.Descuento}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Total Iva : {factura.Iva}"));
           document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"SubTotal° : {factura.SubTotal}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Total° : {factura.Total}"));
            document.Add(new Paragraph("\n"));

            document.Close();
        }

       
    }
}
