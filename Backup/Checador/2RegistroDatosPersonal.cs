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
    public partial class PanelDatosPersonal : Form
    {
        private string nombre;
        public PanelDatosPersonal(string nombre)
        {
            InitializeComponent();
            textBoxNombre.Text = nombre;
            nombre = this.nombre;
        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Title = "Abrir";
            ac.Filter = "Documento JPG|*.jpg";

            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBoxImagen.Image = Image.FromFile(ac.FileName);
            }
        }

        private void PanelDatosPersonal_Load(object sender, EventArgs e)
        {

        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || (radioButtonMasculino.Checked == false && radioFemenino.Checked == false))
                MessageBox.Show("Es necesario llenar los campos de Nombre y Sexo");

            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("BDP_ELYON.elyon", true);

                string sexo = "";
                if (radioButtonMasculino.Checked == true) sexo = "Masculino";
                if (radioFemenino.Checked == true) sexo = "Femenino";

                string text = textBoxNombre.Text + "|" + textBoxCURP.Text + "|" + textBoxRFC.Text + "|" + textBoxCelular.Text + "|" + textBoxTelefono.Text + "|" + textBoxDireccion.Text + "|" + sexo.ToString() + "|" + textBoxLugarDeNacimiento.Text + "|" + textBoxNacFecha1.Text + "|" + textBoxNacFecha2.Text + "|" + textBoxNacFecha3.Text + "|" + textBoxEdad.Text + "|" + textBoxEmailLaboral.Text + "|" + textBoxEmailPersonal.Text + "|" + textBoxTipoDeSangre.Text + "|" + textBoxNumeroDeEmergencia.Text + "|" + textBoxContactoDeEmergencia.Text + "|" + textBoxParentesco.Text + "|" + textBoxDireccionDelContacto.Text + "|" +textBoxOtrasOcupaciones.Text + "|" + textBoxOtrasOcupaciones.Text + "|" + textBoxEstadoCivil.Text + "|" + textBoxStatusFamiliar.Text + "|";
                file.WriteLine(text);
                file.Flush();
                file.Close();

                this.Close();
            }
            
     
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        } 


    }
}
