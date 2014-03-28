namespace Checador
{
    partial class PanelAvisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNuevoAviso = new System.Windows.Forms.Button();
            this.buttonEditarAviso = new System.Windows.Forms.Button();
            this.textBoxAviso = new System.Windows.Forms.TextBox();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.buttonEditarMensaje = new System.Windows.Forms.Button();
            this.buttonNuevoMensaje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNuevoAviso
            // 
            this.buttonNuevoAviso.Location = new System.Drawing.Point(30, 40);
            this.buttonNuevoAviso.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevoAviso.Name = "buttonNuevoAviso";
            this.buttonNuevoAviso.Size = new System.Drawing.Size(100, 28);
            this.buttonNuevoAviso.TabIndex = 1;
            this.buttonNuevoAviso.Text = "Nuevo";
            this.buttonNuevoAviso.UseVisualStyleBackColor = true;
            this.buttonNuevoAviso.Click += new System.EventHandler(this.buttonNuevoAviso_Click);
            // 
            // buttonEditarAviso
            // 
            this.buttonEditarAviso.Location = new System.Drawing.Point(30, 76);
            this.buttonEditarAviso.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarAviso.Name = "buttonEditarAviso";
            this.buttonEditarAviso.Size = new System.Drawing.Size(100, 28);
            this.buttonEditarAviso.TabIndex = 2;
            this.buttonEditarAviso.Text = "Editar";
            this.buttonEditarAviso.UseVisualStyleBackColor = true;
            this.buttonEditarAviso.Click += new System.EventHandler(this.buttonEditarAviso_Click);
            // 
            // textBoxAviso
            // 
            this.textBoxAviso.Enabled = false;
            this.textBoxAviso.Location = new System.Drawing.Point(165, 40);
            this.textBoxAviso.Multiline = true;
            this.textBoxAviso.Name = "textBoxAviso";
            this.textBoxAviso.Size = new System.Drawing.Size(295, 64);
            this.textBoxAviso.TabIndex = 3;
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Enabled = false;
            this.textBoxMensaje.Location = new System.Drawing.Point(165, 164);
            this.textBoxMensaje.Multiline = true;
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(248, 45);
            this.textBoxMensaje.TabIndex = 53;
            // 
            // buttonEditarMensaje
            // 
            this.buttonEditarMensaje.Location = new System.Drawing.Point(30, 197);
            this.buttonEditarMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarMensaje.Name = "buttonEditarMensaje";
            this.buttonEditarMensaje.Size = new System.Drawing.Size(100, 28);
            this.buttonEditarMensaje.TabIndex = 55;
            this.buttonEditarMensaje.Text = "Editar";
            this.buttonEditarMensaje.UseVisualStyleBackColor = true;
            this.buttonEditarMensaje.Click += new System.EventHandler(this.buttonEditarMensaje_Click);
            // 
            // buttonNuevoMensaje
            // 
            this.buttonNuevoMensaje.Location = new System.Drawing.Point(30, 161);
            this.buttonNuevoMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevoMensaje.Name = "buttonNuevoMensaje";
            this.buttonNuevoMensaje.Size = new System.Drawing.Size(100, 28);
            this.buttonNuevoMensaje.TabIndex = 54;
            this.buttonNuevoMensaje.Text = "Nuevo";
            this.buttonNuevoMensaje.UseVisualStyleBackColor = true;
            this.buttonNuevoMensaje.Click += new System.EventHandler(this.buttonNuevoMensaje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Avisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mensaje";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(165, 240);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 28);
            this.buttonAceptar.TabIndex = 58;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(273, 240);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 59;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // PanelAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 302);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditarMensaje);
            this.Controls.Add(this.buttonNuevoMensaje);
            this.Controls.Add(this.textBoxMensaje);
            this.Controls.Add(this.textBoxAviso);
            this.Controls.Add(this.buttonEditarAviso);
            this.Controls.Add(this.buttonNuevoAviso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelAvisos";
            this.Text = "Avisos y Mensajes";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevoAviso;
        private System.Windows.Forms.Button buttonEditarAviso;
        private System.Windows.Forms.TextBox textBoxAviso;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.Button buttonEditarMensaje;
        private System.Windows.Forms.Button buttonNuevoMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}