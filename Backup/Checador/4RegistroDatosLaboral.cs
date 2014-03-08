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
    public partial class PanelRegistroDatosLaboral : Form
    {
        public PanelRegistroDatosLaboral()
        {
            InitializeComponent();
            
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "" || (radioButtonSeguridadAlto.Checked == false && radioButtonSeguridadMedio.Checked == false && radioButtonSeguridadBajo.Checked == false))
                MessageBox.Show("Es necesario llenar los campos de Nombre, Usuario, Contraseña y Nivel de Seguridad.");
            
            else
            {
                string seguridad = "";
                string empresa = "";
                string regimen = "";
                string turno = "";
                string actas = "";
                string avisos = "";
                string status = "";

                if (radioButtonSeguridadAlto.Checked == true) seguridad = "Alto";
                if (radioButtonSeguridadMedio.Checked == true) seguridad = "Medio";
                if (radioButtonSeguridadBajo.Checked == true) seguridad = "Bajo";
                if (radioButtonElyon.Checked == true) empresa = "Elyon Games";
                if (radioButtonIndex.Checked == true) empresa = "Index Code";
                if (radioButtonGeek.Checked == true) empresa = "Geek Office";
                if (radioButtonProto.Checked == true) empresa = "Protoware";
                if (radioButtonAsalareado.Checked == true) regimen = "Asalariado";
                if (radioButtonAsimilado.Checked == true) regimen = "Asimilado";
                if (radioButtonHonorarios.Checked == true) regimen = "Honorarios";
                if (radioButtonTurno24.Checked == true) turno = "24";
                if (radioButtonTurno48.Checked == true) turno = "48";
                if (radioButtonActa1.Checked == true) actas = "1";
                if (radioButtonActa2.Checked == true) actas = "2";
                if (radioButtonActaPlan.Checked == true) actas = "Plan";
                if (radioButtonAvisos1.Checked == true) avisos = "1";
                if (radioButtonAvisos2.Checked == true) avisos = "2";
                if (radioButtonAvisos3.Checked == true) avisos = "3";
                if (radioButtonActivo.Checked == true) status = "Activo";
                if (radioButtonDespedido.Checked == true) status = "Despedido";
                if (radioButtonRecontratable.Checked == true) status = "Recontratable";

                System.IO.StreamWriter file = new System.IO.StreamWriter("BDL_ELYON.elyon", true);

                

                string text = textBoxUsuario.Text + "|" + textBoxNombre.Text + "|" + textBoxContraseña.Text + "|" + seguridad.ToString() + "|" + textBoxBanco.Text + "|" + textBoxClabe.Text + "|" + textBoxCuenta.Text + "|" + empresa.ToString() + "|" + regimen.ToString() + "|" + textBoxContratacion1.Text + "|" + textBoxContratacion2.Text + "|" + textBoxContratacion3.Text + "|" + textBoxEmailLaboral.Text + "|" + textBoxEmailPersonal.Text + "|" + textBoxPuesto.Text + "|" + textBoxSueldo.Text +"|"+turno.ToString()+"|" + textBoxJefe.Text + "|" + textBoxSubordinados.Text + "|" + textBoxBonificaciones.Text + "|" + status.ToString() + "|" + textBoxIMSS.Text +"|"+actas.ToString() +"|"+ avisos.ToString()+"|";
                file.WriteLine(text);
                file.Flush();
                file.Close();


                System.IO.StreamWriter file2 = new System.IO.StreamWriter("USU_ELYON.elyon", true);
                

                string text2 = textBoxUsuario.Text + "|" + textBoxContraseña.Text + "|" + textBoxNombre.Text + "|" + seguridad.ToString() + "|";
                file2.WriteLine(text2);
                file2.Flush();
                file2.Close();

                PanelDatosPersonal panel = new PanelDatosPersonal(textBoxNombre.Text);
                panel.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
