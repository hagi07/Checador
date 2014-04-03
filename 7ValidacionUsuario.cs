using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Checador
{
    public partial class PanelValidacionUsuario : Form
    {
        private string opcion;
        private string usuario;
        private string nivel;
        public PanelValidacionUsuario(string opcion, string usuario,string nivel)
        {
            InitializeComponent();
            this.opcion = opcion;
            this.usuario = usuario;
            this.nivel = nivel;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

                System.IO.StreamReader fileReader = new System.IO.StreamReader("USU_ELYON.elyon");
                string espacios = fileReader.ReadToEnd();
                fileReader.Close();

                string[] x = espacios.Split('\n');
                bool ok = false;

                for (int i = 0; i < x.Length; i++)
                {
                    string[] y = x[i].Split('|');
                    if (y[0] == textBoxUsuario.Text)
                    {
                        ok = true;
                    }
                }
                if (ok == true && opcion == "Nuevo")
                {
                    PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral("Nuevo", textBoxUsuario.Text, nivel);
                    panel.Show();
                    this.Close();
                }

                if (ok == true && opcion == "Editar")
                {
                    MessageBox.Show("Aquí se mandaría el correo con la informacion del usuario seleccionado.");
                    //CORREO!!!!
                }
                if (ok == false) MessageBox.Show("Usuario No Encontrado.");
            

        }

        private void PanelValidacionUsuario_Load(object sender, EventArgs e)
        {

        }




        public void SMTPMail(string pDestino, string pAsunto, string pCuerpo, string pUsuario, string pPassword, string archivo)
        {
            // Crear el Mail
            using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
            {
                mail.To.Add(new System.Net.Mail.MailAddress(pDestino));
                mail.From = new System.Net.Mail.MailAddress(pUsuario);
                mail.Subject = pAsunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = pCuerpo;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = false;

                // Agregar el Adjunto si deseamos hacerlo
                mail.Attachments.Add(new Attachment(archivo));

                // Configuración SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);

                // Crear Credencial de Autenticacion
                smtp.Credentials = new System.Net.NetworkCredential(pUsuario, pPassword);
                smtp.EnableSsl = true;

                try
                { smtp.Send(mail); }
                catch (Exception ex)
                { throw ex; }
            } // end using mail
        } // end SMTPMail
        

    }
}
