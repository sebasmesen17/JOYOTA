using DataEntity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace DataPresentation
{
    public class email
    {
        public void Send(Factura factura, String fecha, string nombre, Vehiculo vehiculo, string destinatario)
        {
            var document = new Document();

            MemoryStream memoryStream = new MemoryStream();

            PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);

            document.Open();

            document.Add(new Paragraph("               JOYOTA"));
            document.Add(new Paragraph("_________________________________________"));
            document.Add(new Paragraph("   "));

            document.Add(new Paragraph("Fecha de factura: " + fecha));
            document.Add(new Paragraph("Número de factura: " + factura.IDFactura.ToString()));
            document.Add(new Paragraph("  "));
            document.Add(new Paragraph("Nombre comprador: " + nombre));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph("    Modelo: " + vehiculo.modelo));
            document.Add(new Paragraph("    Marca: " + vehiculo.marca));
            document.Add(new Paragraph("    Año: " + vehiculo.año));
            document.Add(new Paragraph("    Descripción: " + vehiculo.categoria));
            document.Add(new Paragraph("    Estado: " + vehiculo.estado));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph("Tipo de pago: " + factura.tipoPago));
            document.Add(new Paragraph("Monto total: " + factura.monto.ToString()));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph("Muchas gracias por contar por nuestros servicios."));

            writer.CloseStream = false;

            document.Close();

            memoryStream.Position = 0;

            MailMessage email = new MailMessage();

            email.To.Add(new MailAddress(destinatario));

            email.From = new MailAddress("lenguajesaplicacionescomercial@gmail.com");

            email.Subject = "Factura de compra JOYOTA";

            email.Body = "Compra de Automovil "+vehiculo.marca+" "+vehiculo.modelo;

            email.Attachments.Add(new Attachment(memoryStream, "Joyota.pdf"));

            email.IsBodyHtml = true;

            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "smtp.gmail.com";

            smtp.Port = 587;

            smtp.EnableSsl = true;

            smtp.UseDefaultCredentials = false;



            smtp.Credentials = new NetworkCredential("lenguajesaplicacionescomercial@gmail.com", "IF-4101ucr@");

            smtp.Send(email);

            email.Dispose();

            smtp.Dispose();

            memoryStream.Close();
        }
    }
}