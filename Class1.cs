using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;

namespace Checador
{
    class UtilUMG
    {
        //Obtiene el texto de un archivo.
        /// <param name="archivo">Used to indicate status.</param>
        /// <summary>
        /// The GetGenericValue method.
        /// </summary>
        public string textoDeArchivo(string archivo)
        {
            System.IO.StreamReader fileReader = new System.IO.StreamReader(archivo); //Abre el archivo y extrae la informacion en un string.
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();
            return espacios;
        }

        //Obtiene El texto completo y lo separa dependiendo de un caracter.
        public string[] textoDeArchivoConSplit(string archivo, char separacion)
        {
            //Obtiene el texto completo del archivo.
            System.IO.StreamReader fileReader = new System.IO.StreamReader(archivo);
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();

            //Separa el texto dependiendo del caracter.
            string[] separado = espacios.Split(separacion);
            return separado;
        }

        //Obtiene la última línea del archivo.
        public string ultimaLinea(string archivo, char separacionDeLinea)
        {
            string texto = "";
            string textoCompleto = "";
            using (StreamReader sr = new StreamReader(archivo))    //Obtiene el texto completo del archivo.
                textoCompleto = sr.ReadToEnd();

            string[] textoLineas = textoCompleto.Split('\n');       //Separa el texto por lineas.
            for (int i = 0; i < textoLineas.Length; i++)
            {
                string[] textoSeparado = textoLineas[i].Split(separacionDeLinea);      //Separa la línea por el dato defínido.
                if (!string.IsNullOrWhiteSpace(textoSeparado[0])) texto = textoSeparado[0];     //Obtiene la última línea.
            }
            return texto;
        }

        //Envía un correo con archivos adjuntos.
        public void enviarCorreo(string pDestino, string pAsunto, string pCuerpo, string pUsuario, string pPassword, string archivo)
        {
            // Crear el Mail.
            using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
            {
                //Establece los valores básicos del correo.
                mail.To.Add(new System.Net.Mail.MailAddress(pDestino));
                mail.From = new System.Net.Mail.MailAddress(pUsuario);
                mail.Subject = pAsunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = pCuerpo;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = false;

                // Agregar el Adjunto si deseamos hacerlo.
                mail.Attachments.Add(new Attachment(archivo));

                // Configuración SMTP.
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);

                // Crear Credencial de Autenticacion.
                smtp.Credentials = new System.Net.NetworkCredential(pUsuario, pPassword);
                smtp.EnableSsl = true;

                try
                { smtp.Send(mail); }
                catch (Exception ex)
                { throw ex; }
            } // end using mail.
        } // end SMTPMail.

        //Permite cargar en un PDF información en los formularios preestablecidos.
        public void llenarFormulario(string archivoOrigen, string archivoFinal, string dato)
        {
            //Establece el archivo de entrada y de salida.
            string pdfTemplate = archivoOrigen;
            string newFile = archivoFinal;

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.OpenOrCreate));

            AcroFields pdfFormFields = pdfStamper.AcroFields;

            // Asigna los campos
            pdfFormFields.SetField("Colono", dato);

            //Muestra mensaje.
            //MessageBox.Show(sTmp, "Terminado");

            // Cambia la propiedad para que no se pueda editar el PDF
            pdfStamper.FormFlattening = true;
            pdfStamper.FreeTextFlattening = true;
            pdfStamper.Writer.CloseStream = true;
            pdfStamper.Close();

            // Cierra el PDF
            pdfStamper.Close();
            pdfReader.Close();
        }

    }
}
