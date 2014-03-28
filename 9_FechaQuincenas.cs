using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace Checador
{
    public partial class PanelFechaQuincenas : Form
    {
        public PanelFechaQuincenas()
        {
            InitializeComponent();
            textBoxFechaInicioMes.Text = DateTime.Now.Date.ToString("MM");
            textBoxFechaFinMes.Text = DateTime.Now.Date.ToString("MM");
            textBoxFechaInicioAño.Text = DateTime.Now.Date.ToString("yyyy");
            textBoxFechaFinAño.Text = DateTime.Now.Date.ToString("yyyy");
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBoxFechaInicioDia.Text) && !string.IsNullOrWhiteSpace(textBoxFechaInicioMes.Text) && !string.IsNullOrWhiteSpace(textBoxFechaInicioAño.Text) && !string.IsNullOrWhiteSpace(textBoxFechaFinDia.Text) && !string.IsNullOrWhiteSpace(textBoxFechaFinMes.Text) && !string.IsNullOrWhiteSpace(textBoxFechaFinAño.Text))
            {
                string[] personal = Personal();

                for (int i = 0; i < personal.Length; i++)
                {
                    int horaEntrada = 0;
                    int horaidaComer = 0;
                    int horaregresoComer = 0;
                    int horaSalida = 0;
                    int minutosEntrada = 0;
                    int minutosIdaComer = 0;
                    int minutosRegresoComer = 0;
                    int minutosSalida = 0;
                    int totalhoras = 0;
                    int totalminutos = 0;

                    using (StreamReader sr = new StreamReader("ASIS_ELYON.elyon"))
                    {
                        string linea;
                        string fechaInicio = textBoxFechaInicioDia.Text + "/" + textBoxFechaInicioMes.Text + "/" + textBoxFechaInicioAño.Text;
                        string fechaFin = textBoxFechaFinDia.Text + "/" + textBoxFechaFinMes.Text + "/" + textBoxFechaFinAño.Text;
                        bool okInicio = false;
                        bool okEncontreFin = false;
                        bool okSeAcaboFin = false;
                        bool okComi = false;

                        while ((linea = sr.ReadLine()) != null)
                        {
                            string[] lineaSeparada = linea.Split('|');

                            if (lineaSeparada[0] == fechaInicio)
                                okInicio = true;

                            if (lineaSeparada[0] == fechaFin)
                                okEncontreFin = true;

                            if (okInicio && okEncontreFin && lineaSeparada[0] != fechaFin)
                                okSeAcaboFin = true;

                            if (okInicio && !okSeAcaboFin)
                            {
                                if (personal[i] == lineaSeparada[1])
                                {
                                    string[] horaCompleta = lineaSeparada[2].Split(':');
                                    if (lineaSeparada[3] == "E")
                                    {
                                        horaEntrada = Convert.ToInt32(horaCompleta[0]);
                                        minutosEntrada = Convert.ToInt32(horaCompleta[1]);
                                    }
                                    else if (lineaSeparada[3] == "S")
                                    {
                                        horaSalida = Convert.ToInt32(horaCompleta[0]);
                                        minutosSalida = Convert.ToInt32(horaCompleta[1]);
                                    }
                                    else if (lineaSeparada[3] == "CS")
                                    {
                                        horaidaComer = Convert.ToInt32(horaCompleta[0]);
                                        minutosIdaComer = Convert.ToInt32(horaCompleta[1]);
                                        okComi = true;
                                    }
                                    else if (lineaSeparada[3] == "CE")
                                    {
                                        horaregresoComer = Convert.ToInt32(horaCompleta[0]);
                                        minutosRegresoComer = Convert.ToInt32(horaCompleta[1]);
                                    }
                                }

                            }
                        }
                        if(okComi)
                        {
                            totalhoras = (horaidaComer - horaEntrada) + (horaSalida - horaregresoComer);
                            totalminutos = (60 - minutosEntrada) + minutosIdaComer + (60 - minutosRegresoComer) + minutosSalida;
                            totalhoras = totalhoras - 2;
                            okComi = false;
                            
                        }
                        else
                        {
                            totalhoras = horaSalida - horaEntrada;
                            totalminutos = minutosSalida + minutosEntrada;
                        }
                        if (totalminutos > 60)
                        {
                            totalhoras = totalhoras + (totalminutos / 60);
                            totalminutos = totalminutos % 60;
                        }

                        horaregresoComer = 0;
                        horaidaComer = 0;
                        horaEntrada = 0;
                        horaSalida = 0;
                        minutosEntrada = 0;
                        minutosSalida = 0;
                        minutosIdaComer = 0;
                        minutosRegresoComer = 0;

                    } //FIN USING

                    System.IO.StreamWriter file = new System.IO.StreamWriter("Concentrado.csv", true);
                    string text = personal[i] + "," + totalhoras + ":" + totalminutos;
                    file.WriteLine(text);
                    file.Flush();
                    file.Close();
                }//FIN FOR

                //SMTPMail("renehagi@gmail.com", "Concentrado", "", "renehagi@gmail.com", "ReNb3270", "Concentrado.elyon");
                //File.Delete("Concentrado.elyon");
                MessageBox.Show("Reporte mandado correctamente a correo.");
                this.Close();
            }
            else MessageBox.Show("Llene todos los campos.");
        }


        private string[] Personal() {
            
            int tam = 0;
            using (StreamReader sr = new StreamReader("USU_ELYON.elyon"))    //CALCULA EL TAMAÑO DE LINEAS DEL ARCHIVO.
                while (sr.ReadLine() != null)
                    tam++;

            string[] personal = new string[tam];

            using (StreamReader sr = new StreamReader("USU_ELYON.elyon"))
            { 
                string linea;
                for(int i = 0; (linea = sr.ReadLine()) != null; i++)
                { 
                    string[] lineaSeparada = linea.Split('|');
                    personal[i] =lineaSeparada[0];
                }
            }

            return personal;
        }


       /* public void SMTPMail(string pDestino, string pAsunto, string pCuerpo, string pUsuario, string pPassword, string archivo)
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
        */
    }
}




/*
 
 
 
 
 
 
 
 
 
 
             /** OBTENER CONCENTRADO DEL RANGO DE FECHAS DESDE ARCHIVO
            string fechaInicio = textBoxFechaInicioDia.Text + "/" + textBoxFechaInicioMes.Text + "/" +textBoxFechaInicioAño.Text;
            string fechaFin = textBoxFechaFinDia.Text + "/" + textBoxFechaFinMes.Text + "/" + textBoxFechaFinAño.Text;
            bool okInicio = false;
            bool okEncontreFin = false;
            bool okSeAcaboFin = false; 


            System.IO.StreamReader fileReader = new System.IO.StreamReader("ASIS_ELYON.elyon");
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();
            
            string[] x = espacios.Split('\n');
            string[] concentrado = new string[x.Length]; 
          
            for (int i = 0, j = 0; i < x.Length; i++)
            {
                
                string[] y = x[i].Split('|');

                if (y[0] == fechaInicio)
                    okInicio = true;

                if (y[0] == fechaFin)
                    okEncontreFin = true;

                if(okInicio && okEncontreFin && y[0] != fechaFin)
                    okSeAcaboFin = true;

                if (okInicio && !okSeAcaboFin) {
                    concentrado[j] = y[1] + "|" + y[2] + "|" + y[3];
                    j++;
                }
            }

/// DEBUG
/// 
                
            
            /* DETERMINAR PEROSNAL ACTIVO 

            System.IO.StreamReader fileReader2 = new System.IO.StreamReader("USU_ELYON.elyon");
            string espacios2 = fileReader2.ReadToEnd();
            fileReader2.Close();

            string[] x2 = espacios2.Split('\n');
            string[] personal = new string[x2.Length];

            for (int i = 0; i < x2.Length; i++) { 
                string[] y = x2[i].Split('|');
                personal[i] = y[0];
            }

            /*ANALASIS DE HORAS POR PERSONA


            int contadorAux = 0;

            for (int i = 0; i < personal.Length; i++)           //CLASIFICAR EN EL ARREGLO DE PERSONAL ACTIVO. 
            { 
                string[] auxDePersonal = new string[5];         //DECLARA EL TEXTO PARA ALMACENAR HORAS POR PARTES.
                for (int j = 0; j < concentrado.Length; j++)    //BUSCAR EN TODO EL CONCENTRADOD DE HORAS PREDEFINIDAS EL NOMBRE DEL PERSONAL ACTUAL. 
                {
                    //MessageBox.Show( concentrado[j]);
                    string[] lineaDeConcentrado = null;
                    if (!string.IsNullOrWhiteSpace(concentrado[j]))
                        lineaDeConcentrado = concentrado[j].Split('|');       //SEPARA EL CONCENTRADO POR PARTES.
                    

                    if (personal[i] == lineaDeConcentrado[0])              //SI CORRESPONDEN LOS USUARIOS.
                    {
                        MessageBox.Show(personal[i]);        
                    }
                    
                }
                MessageBox.Show("Todo en Orden");
 
 
 
 
 
 
 
 
 
 
 
 
 */
