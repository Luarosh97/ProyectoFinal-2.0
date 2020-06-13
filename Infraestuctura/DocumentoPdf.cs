using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entity;
using System.IO;

namespace Infraestuctura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(Factura factura,string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter pw = PdfWriter.GetInstance(document, fs);

            document.AddCreator("Luis Rocha");

            document.Open();
            document.Add(new Paragraph($"VETERINARIA-SOFT"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"REPORTE DE FACTURA REALIZADA"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"FACTURA N° {factura.Codigo}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Cliente° {factura.Cliente.Nombre} CC: {factura.Cliente.Identificacion}"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(factura.Detalles));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Ganancia° {factura.Ganancia.ToString()}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Subtotal° {factura.SubTotal.ToString()}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Descuento° {factura.Descuento.ToString()}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"total a Pagar° {factura.Total.ToString()}"));
            document.Add(new Paragraph("\n"));
            document.Close();
        }
        private PdfPTable LlenarTabla(List<DetalleFactura> detalleFacturas)
        {
            PdfPTable tabla = new PdfPTable(4);
            tabla.AddCell(new Paragraph("Codigo"));
            tabla.AddCell(new Paragraph("Nombre Servicio"));
            tabla.AddCell(new Paragraph("Factura"));
            tabla.AddCell(new Paragraph("Nombre Mascota"));
   
            foreach (var item in detalleFacturas)
            {
                tabla.AddCell(item.Codigo.ToString());
                tabla.AddCell(item.Servicio.Nombre);
                tabla.AddCell(item.Factura.ToString());
                tabla.AddCell(item.Mascota.NombreMascota);
    }
           return tabla;
        }


    }
}
