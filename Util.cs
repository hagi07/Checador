using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.Windows.Forms;
using System.IO;

namespace Checador
{
    class Util
    {
        //*********************************************//
        //MÉTODOS PARA ESCRITURA Y LECTURA DE ARCHIVOS.//
        //*********************************************//


        // Accede a un archivo y regresa todo el texto en un String.
        public string textoDeArchivo(string archivo)
        {
            System.IO.StreamReader fileReader = new System.IO.StreamReader(archivo);
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();
            return espacios;
        }

        //Acceede a un archivo y retorna el texto pero separado por un caracter.
        public string[] textoDeArchivoConSplit(string archivo, char separador) 
        {
            System.IO.StreamReader fileReader = new System.IO.StreamReader(archivo);
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();
            string[] lineaseparada = espacios.Split(separador);
            return lineaseparada;
        }

        //Escribe una línea en el archivo indicado.
        public void escribirEnArchivo(string archivo, string texto) 
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
            file.WriteLine(texto);
            file.Flush();
            file.Close();
        }

        //********************************************//
        //MÉTODOS PARA CONTROL DE USUARIOS EN CHECADOR//
        //********************************************//

        //Valida la entrada de un usuario.
        public bool validiarEntrada(string[] lineas, string usuario)
        {
            for (int j = 0; j < lineas.Length; j++)
            {
                string[] linea = lineas[j].Split('|');
                if (linea.Length >= 3)
                    if (linea[0] == DateTime.Now.ToString("dd/MM/yyyy") && linea[1] == usuario && linea[3] == "E")
                        return true;   
            }
            return false;
        }

        //Valida la ida a comer de un usuario.
        public bool validiarIrAComer(string[] lineas, string usuario)
        {
            for (int j = 0; j < lineas.Length; j++)
            {
                string[] linea = lineas[j].Split('|');
                if (linea.Length >= 3)
                    if (linea[0] == DateTime.Now.ToString("dd/MM/yyyy") && linea[1] == usuario && linea[3] == "CS")
                        return true;
            }  
            return false;
        }

        //Valida la regreso de comer de un usuario.
        public bool validiarRegresoComer(string[] lineas, string usuario)
        {
            for (int j = 0; j < lineas.Length; j++)
            {
                string[] linea = lineas[j].Split('|');
                if (linea.Length >= 3)
                    if (linea[0] == DateTime.Now.ToString("dd/MM/yyyy") && linea[1] == usuario && linea[3] == "CE")
                        return true;
            }
            return false;
        }

        //Valida la salida de un usuario.
        public bool validiarSalida(string[] lineas, string usuario)
        {
            for (int j = 0; j < lineas.Length; j++)
            {
                string[] linea = lineas[j].Split('|');
                if (linea.Length >= 3)
                    if (linea[0] == DateTime.Now.ToString("dd/MM/yyyy") && linea[1] == usuario && linea[3] == "S")
                        return true;
            }
            return false;
        }


        //*****//
        //EMAIL//
        //*****//
        public void SMTPMail(string pDestino, string pAsunto, string pCuerpo)
        {
            // Crear el Mail
            using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
            {
                mail.To.Add(new System.Net.Mail.MailAddress(pDestino));
                mail.From = new System.Net.Mail.MailAddress("checadorbugabuga@gmail.com");
                mail.Subject = pAsunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = pCuerpo;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = false;

                // Agregar el Adjunto si deseamos hacerlo
                //mail.Attachments.Add(new Attachment(archivo));

                // Configuración SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);

                // Crear Credencial de Autenticacion
                smtp.Credentials = new System.Net.NetworkCredential("checadorbugabuga@gmail.com", "ReNb3270");
                smtp.EnableSsl = true;

                try
                { smtp.Send(mail); }
                catch (Exception ex)
                { throw ex; }
            } // end using mail
        }
 
        //***//
        //PDF//
        //***//

        public void FillForm()
        {
            string pdfTemplate = "Reporte.pdf";
            string newFile = "NewReporte.pdf";

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(
                        newFile, FileMode.Create));

            AcroFields pdfFormFields = pdfStamper.AcroFields;

            // Asigna los campos

            pdfFormFields.SetField("CodigoDeBarras", "dato 1");

            string sTmp = "Datos asignados";
            MessageBox.Show(sTmp, "Terminado");

            // Cambia la propiedad para que no se pueda editar el PDF
            pdfStamper.FormFlattening = false;

            // Cierra el PDF
            pdfStamper.Close();
        }
    }
}
