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
    public partial class PanelFechaQuincenas : Form
    {
        private int opcion = 0;
        public PanelFechaQuincenas()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            /** OBTENER CONCENTRADO DEL RANGO DE FECHAS DESDE ARCHIVO*/
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
                
            
            /* DETERMINAR PEROSNAL ACTIVO */

            System.IO.StreamReader fileReader2 = new System.IO.StreamReader("USU_ELYON.elyon");
            string espacios2 = fileReader2.ReadToEnd();
            fileReader2.Close();

            string[] x2 = espacios2.Split('\n');
            string[] personal = new string[x2.Length];

            for (int i = 0; i < x2.Length; i++) { 
                string[] y = x2[i].Split('|');
                personal[i] = y[0];
            }

            /*ANALASIS DE HORAS POR PERSONA*/


            int contadorAux = 0;

            for (int i = 0; i < personal.Length; i++)           //CLASIFICAR EN EL ARREGLO DE PERSONAL ACTIVO. 
            { 
                string[] auxDePersonal = new string[5];         //DECLARA EL TEXTO PARA ALMACENAR HORAS POR PARTES.
                for (int j = 0; j < concentrado.Length; j++)    //BUSCAR EN TODO EL CONCENTRADOD DE HORAS PREDEFINIDAS EL NOMBRE DEL PERSONAL ACTUAL. 
                {
                    //MessageBox.Show( concentrado[j]);
                    string[] lineaDeConcentrado = null;
                    if (!string.IsNullOrWhiteSpace(concentrado[j]))
                    {
                        lineaDeConcentrado = concentrado[j].Split('|');       //SEPARA EL CONCENTRADO POR PARTES.
                        
                    }

                    /*if (personal[i] == lineaDeConcentrado[0])              //SI CORRESPONDEN LOS USUARIOS.
                    {
                        MessageBox.Show(lineaDeConcentrado[0]);        
                    }*/
                    
                }
                MessageBox.Show("Todo en Orden");
             /*/****************************************/
            }
        }
    }
}
