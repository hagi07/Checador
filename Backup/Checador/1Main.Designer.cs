namespace Checador
{
    partial class Checador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checador));
            this.Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.Dia_Fecha = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.radioButtonEntrada = new System.Windows.Forms.RadioButton();
            this.radioButtonSalida = new System.Windows.Forms.RadioButton();
            this.radioButtonComidaSalida = new System.Windows.Forms.RadioButton();
            this.radioButtonComidaEntrada = new System.Windows.Forms.RadioButton();
            this.labelAvisosLabel = new System.Windows.Forms.Label();
            this.labelAvisoTexto = new System.Windows.Forms.Label();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.radioButtonInformacion = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Hora
            // 
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(204, 0);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(95, 27);
            this.Hora.TabIndex = 0;
            this.Hora.Text = "01:00:00";
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(93, 112);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '•';
            this.textBoxContraseña.Size = new System.Drawing.Size(157, 20);
            this.textBoxContraseña.TabIndex = 14;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(93, 82);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(157, 20);
            this.textBoxUsuario.TabIndex = 11;
            // 
            // Dia_Fecha
            // 
            this.Dia_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia_Fecha.Location = new System.Drawing.Point(10, 0);
            this.Dia_Fecha.Name = "Dia_Fecha";
            this.Dia_Fecha.Size = new System.Drawing.Size(90, 28);
            this.Dia_Fecha.TabIndex = 15;
            this.Dia_Fecha.Text = "12/12/12";
            this.Dia_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(14, 152);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 17;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // radioButtonEntrada
            // 
            this.radioButtonEntrada.AutoSize = true;
            this.radioButtonEntrada.Location = new System.Drawing.Point(111, 158);
            this.radioButtonEntrada.Name = "radioButtonEntrada";
            this.radioButtonEntrada.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEntrada.TabIndex = 18;
            this.radioButtonEntrada.TabStop = true;
            this.radioButtonEntrada.Text = "Entrada";
            this.radioButtonEntrada.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalida
            // 
            this.radioButtonSalida.AutoSize = true;
            this.radioButtonSalida.Location = new System.Drawing.Point(111, 181);
            this.radioButtonSalida.Name = "radioButtonSalida";
            this.radioButtonSalida.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSalida.TabIndex = 19;
            this.radioButtonSalida.TabStop = true;
            this.radioButtonSalida.Text = "Salida";
            this.radioButtonSalida.UseVisualStyleBackColor = true;
            // 
            // radioButtonComidaSalida
            // 
            this.radioButtonComidaSalida.AutoSize = true;
            this.radioButtonComidaSalida.Location = new System.Drawing.Point(170, 181);
            this.radioButtonComidaSalida.Name = "radioButtonComidaSalida";
            this.radioButtonComidaSalida.Size = new System.Drawing.Size(92, 17);
            this.radioButtonComidaSalida.TabIndex = 21;
            this.radioButtonComidaSalida.TabStop = true;
            this.radioButtonComidaSalida.Text = "Comida Salida";
            this.radioButtonComidaSalida.UseVisualStyleBackColor = true;
            // 
            // radioButtonComidaEntrada
            // 
            this.radioButtonComidaEntrada.AutoSize = true;
            this.radioButtonComidaEntrada.Location = new System.Drawing.Point(170, 158);
            this.radioButtonComidaEntrada.Name = "radioButtonComidaEntrada";
            this.radioButtonComidaEntrada.Size = new System.Drawing.Size(100, 17);
            this.radioButtonComidaEntrada.TabIndex = 20;
            this.radioButtonComidaEntrada.TabStop = true;
            this.radioButtonComidaEntrada.Text = "Comida Entrada";
            this.radioButtonComidaEntrada.UseVisualStyleBackColor = true;
            // 
            // labelAvisosLabel
            // 
            this.labelAvisosLabel.AutoSize = true;
            this.labelAvisosLabel.Location = new System.Drawing.Point(20, 235);
            this.labelAvisosLabel.Name = "labelAvisosLabel";
            this.labelAvisosLabel.Size = new System.Drawing.Size(41, 13);
            this.labelAvisosLabel.TabIndex = 24;
            this.labelAvisosLabel.Text = "Avisos:";
            // 
            // labelAvisoTexto
            // 
            this.labelAvisoTexto.AutoSize = true;
            this.labelAvisoTexto.Location = new System.Drawing.Point(78, 235);
            this.labelAvisoTexto.Name = "labelAvisoTexto";
            this.labelAvisoTexto.Size = new System.Drawing.Size(0, 13);
            this.labelAvisoTexto.TabIndex = 26;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Location = new System.Drawing.Point(90, 135);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(73, 13);
            this.labelAdvertencia.TabIndex = 28;
            this.labelAdvertencia.Text = "Ingrese Datos";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(26, 89);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 29;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(26, 119);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 30;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(130, 48);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(47, 13);
            this.labelMensaje.TabIndex = 31;
            this.labelMensaje.Text = "Mensaje";
            // 
            // buttonSalida
            // 
            this.buttonSalida.Location = new System.Drawing.Point(14, 181);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(75, 23);
            this.buttonSalida.TabIndex = 32;
            this.buttonSalida.Text = "Salida";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // radioButtonInformacion
            // 
            this.radioButtonInformacion.AutoSize = true;
            this.radioButtonInformacion.Location = new System.Drawing.Point(142, 204);
            this.radioButtonInformacion.Name = "radioButtonInformacion";
            this.radioButtonInformacion.Size = new System.Drawing.Size(80, 17);
            this.radioButtonInformacion.TabIndex = 33;
            this.radioButtonInformacion.TabStop = true;
            this.radioButtonInformacion.Text = "Información";
            this.radioButtonInformacion.UseVisualStyleBackColor = true;
            // 
            // Checador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(316, 304);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonInformacion);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelAdvertencia);
            this.Controls.Add(this.labelAvisoTexto);
            this.Controls.Add(this.labelAvisosLabel);
            this.Controls.Add(this.radioButtonComidaSalida);
            this.Controls.Add(this.radioButtonComidaEntrada);
            this.Controls.Add(this.radioButtonSalida);
            this.Controls.Add(this.radioButtonEntrada);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.Dia_Fecha);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.Hora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Checador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Checador";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Checador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label Dia_Fecha;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.RadioButton radioButtonEntrada;
        private System.Windows.Forms.RadioButton radioButtonSalida;
        private System.Windows.Forms.RadioButton radioButtonComidaSalida;
        private System.Windows.Forms.RadioButton radioButtonComidaEntrada;
        private System.Windows.Forms.Label labelAvisosLabel;
        private System.Windows.Forms.Label labelAvisoTexto;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Button buttonSalida;
        private System.Windows.Forms.RadioButton radioButtonInformacion;

    }
}

