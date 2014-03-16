using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador
{
    public partial class Main : Form
    {
    
        public Main()
        {
            InitializeComponent();
            reloj.Start();
        }

        private void Fondo_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBoxContraseña.Text) && !string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                string usuarioNum = textBoxUsuario.Text.ToString();
                string contraseñaNum = textBoxContraseña.Text.ToString();

                string espacios = textoDeArchivo("USU_ELYON.elyon");

                string[] x = espacios.Split('\n');
                bool ok = false;

                if (radioButtonComidaEntrada.Checked == false && radioButtonComidaSalida.Checked == false && radioButtonEntrada.Checked == false && radioButtonSalida.Checked == false && radioButtonInformacion.Checked == false)
                    MessageBox.Show("Seleccione una opción");


                for (int i = 0; i < x.Length; i++)
                {
                    string[] y = x[i].Split('|');
                    if (usuarioNum == y[0])
                    {
                        if (contraseñaNum == y[1])
                        {
                            ok = true;

                            if (radioButtonEntrada.Checked == true)
                            {
                                string textoCompleto = textoDeArchivo("ASIS_ELYON.elyon");
                                string[] lineas = textoCompleto.Split('\n');
                                bool okEntrada = false;

                                for (int j = 0; j < lineas.Length; j++)
                                {
                                    string[] linea = lineas[j].Split('|');
                                    if (linea.Length >= 3)
                                        if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "E")
                                        {
                                            MessageBox.Show("Ya estás registrado de entrada.");
                                            okEntrada = true;
                                        }
                                }

                                if (okEntrada == false)
                                {
                                    MessageBox.Show("Bienvenido " + y[2] + ".");
                                    System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                    string text = DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "E" + "|";
                                    file.WriteLine(text);
                                    file.Flush();
                                    file.Close();
                                }
                            }

                            if (radioButtonComidaSalida.Checked == true)
                            {
                                string textoCompleto = textoDeArchivo("ASIS_ELYON.elyon");

                                string[] lineas = textoCompleto.Split('\n');
                                bool okEntrada = false;
                                bool okSalidaComer = false;
                                bool okSalida = false;

                                okEntrada = validiarEntrada(lineas);
                                okSalidaComer = validiarIrAComer(lineas);
                                okSalida = validiarSalida(lineas);
                                
                                if (okEntrada == true && okSalidaComer == false && !okSalida)
                                {
                                    MessageBox.Show("Provecho " + y[2] + ".");
                                    System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                    string text = DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "CS" + "|";
                                    file.WriteLine(text);
                                    file.Flush();
                                    file.Close();
                                }

                                if (okSalidaComer) MessageBox.Show("Ya saliste a comer.");
                                if (!okEntrada) MessageBox.Show("No has entrado aun.");
                                if (okSalida && okEntrada) MessageBox.Show("Ya saliste hoy.");

                            }

                            if (radioButtonComidaEntrada.Checked == true)
                            {
                                System.IO.StreamReader validationText = new System.IO.StreamReader("ASIS_ELYON.elyon");
                                string textoCompleto = validationText.ReadToEnd();
                                validationText.Close();

                                string[] lineas = textoCompleto.Split('\n');
                                bool okSalidaComer = false;
                                bool okEntradaComer = false;
                                bool okEntrada = false;
                                bool okSalida = false;


                                okEntrada = validiarEntrada(lineas);
                                okSalidaComer = validiarIrAComer(lineas);
                                okEntradaComer = validiarRegresoComer(lineas);
                                okSalida = validiarSalida(lineas);



                                if (okSalidaComer && !okEntradaComer)
                                {
                                    MessageBox.Show("Bienvenido " + y[2] + ".");
                                    System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                    string text = DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "CE" + "|";
                                    file.WriteLine(text);
                                    file.Flush();
                                    file.Close();
                                }

                                if (okEntradaComer) MessageBox.Show("Ya regresaste de comer.");
                                if (!okSalidaComer && !okSalida) MessageBox.Show("No has ido a comer aun.");
                                if (okSalida && okEntrada) MessageBox.Show("Ya saliste hoy.");
                            }




                            if (radioButtonSalida.Checked == true)
                            {
                                System.IO.StreamReader validationText = new System.IO.StreamReader("ASIS_ELYON.elyon");
                                string textoCompleto = validationText.ReadToEnd();
                                validationText.Close();

                                string[] lineas = textoCompleto.Split('\n');
                                bool okEntrada = false;
                                bool okSalidaComer = false;
                                bool okEntradaComer = false;
                                bool okSalida = false;


                                for (int j = 0; j < lineas.Length; j++)
                                {
                                    string[] linea = lineas[j].Split('|');
                                    if (linea.Length >= 3)
                                        if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "E")
                                        {
                                            okEntrada = true;
                                        }
                                }


                                for (int j = 0; j < lineas.Length; j++)
                                {
                                    string[] linea = lineas[j].Split('|');
                                    if (linea.Length >= 3)
                                        if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "CS")
                                        {
                                            okSalidaComer = true;
                                        }
                                }

                                for (int j = 0; j < lineas.Length; j++)
                                {
                                    string[] linea = lineas[j].Split('|');
                                    if (linea.Length >= 3)
                                        if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "CE")
                                        {
                                            okEntradaComer = true;
                                        }
                                }

                                for (int j = 0; j < lineas.Length; j++)
                                {
                                    string[] linea = lineas[j].Split('|');
                                    if (linea.Length >= 3)
                                        if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "S")
                                        {
                                            okSalida = true;
                                        }
                                }


                                if (okEntrada)
                                {
                                    if (okSalidaComer)
                                    {
                                        if (!okEntradaComer) MessageBox.Show("No has regresado de comer.");
                                        if (okEntradaComer && !okSalida)
                                        {
                                            MessageBox.Show("Adios " + y[2] + ".");
                                            System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                            string text = DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "S" + "|";
                                            file.WriteLine(text);
                                            file.Flush();
                                            file.Close();
                                        }
                                    }
                                    else if (!okSalida)
                                    {
                                        MessageBox.Show("Adios " + y[2] + ".");
                                        System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                        string text = DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "S" + "|";
                                        file.WriteLine(text);
                                        file.Flush();
                                        file.Close();
                                    }
                                }
                                if (!okEntrada) MessageBox.Show("No has entrado aun.");


                            }

                            if (radioButtonInformacion.Checked == true)
                            {
                                if (y[3] == "Bajo")
                                {
                                    PanelSeguridad1 panel = new PanelSeguridad1();
                                    panel.Show();
                                }

                                if (y[3] == "Medio")
                                {
                                    PanelSeguridad2 panel = new PanelSeguridad2();
                                    panel.Show();
                                }

                                if (y[3] == "Alto")
                                {

                                    PanelSeguridad3 panel = new PanelSeguridad3();
                                    panel.Show();
                                }
                            }
                        }
                    }
                }
                if (ok == false) MessageBox.Show("Usuario o Contraseña Incorrecta");
                textBoxContraseña.Text = "";
                textBoxUsuario.Text = "";
            }
            else MessageBox.Show("Ingrese Datos Completos");
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            this.Close();
            Fondo.ActiveForm.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer.Text = DateTime.Now.ToLongTimeString();
            Hora.Text = DateTime.Now.ToLongTimeString();
            Dia_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private string textoDeArchivo(string archivo) {
            System.IO.StreamReader fileReader = new System.IO.StreamReader(archivo);
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();
            return espacios;
        }

        private bool validiarEntrada(string[] lineas) 
        {
            for (int j = 0; j < lineas.Length; j++)
            {
                string[] linea = lineas[j].Split('|');
                if (linea.Length >= 3)
                    if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "E")
                    {
                        return true;
                    }
            }
            return false;
        }
    
        private bool validiarIrAComer(string[] lineas)
        {
            for (int j = 0; j < lineas.Length; j++)
            {
                string[] linea = lineas[j].Split('|');
                if (linea.Length >= 3)
                    if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "CS")
                    {
                        return true;
                    }
            }
            return false;
        }


        private bool validiarSalida(string[] lineas) 
        {
            for (int j = 0; j < lineas.Length; j++)
            {
                string[] linea = lineas[j].Split('|');
                if (linea.Length >= 3)
                    if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "S")
                    {
                        return true;
                    }
            }
            return false;
        }

        private bool validiarRegresoComer(string[] lineas) 
        {
            for (int j = 0; j < lineas.Length; j++)
            {
                string[] linea = lineas[j].Split('|');
                if (linea.Length >= 3)
                    if (linea[0] == textBoxUsuario.Text && linea[1] == DateTime.Now.ToString("dd/MM/yyyy") && linea[3] == "CE")
                    {
                        return true;
                    }
            }
            return false;
        }

    }




    



}
