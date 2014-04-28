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

            System.IO.StreamReader fileReader = new System.IO.StreamReader("USU_ELYON.elyon");
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();

            string[] x = espacios.Split('\n');

            for (int i = 0; i < x.Length; i++)
            {
                string[] y = x[i].Split('|');
                listBox1.Items.Add(y[0]);
            }


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
                if (y[0] == listBox1.SelectedItem.ToString())
                {
                    ok = true;
                }
            }

            if (ok)
            {
                if (opcion == "Nuevo")
                {
                    PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral("Nuevo", listBox1.SelectedItem.ToString(), nivel);
                    panel.Show();
                    this.Close();
                }

                if (opcion == "Editar")
                {
                    if (nivel == "Alto")
                    {
                        PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral("Editar", usuario, "Alto");
                        panel.Show();
                    }
                    if (nivel == "Medio")
                    {
                        MessageBox.Show(listBox1.SelectedItem.ToString());
                        PanelDatosPersonal panel = new PanelDatosPersonal("Editar", "Medio", usuario, listBox1.SelectedItem.ToString());
                        panel.Show();
                    }
                }
                /*if (opcion == "Informacion")
                {

                }*/
            }
            if (!ok) MessageBox.Show("Usuario No Encontrado.");


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
