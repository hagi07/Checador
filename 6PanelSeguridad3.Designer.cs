namespace Checador
{
    partial class PanelSeguridad3
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
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonAvisos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(105, 28);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(100, 28);
            this.buttonCrear.TabIndex = 0;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(105, 63);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 28);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(105, 135);
            this.buttonReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(100, 28);
            this.buttonReportes.TabIndex = 2;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonAvisos
            // 
            this.buttonAvisos.Location = new System.Drawing.Point(105, 171);
            this.buttonAvisos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAvisos.Name = "buttonAvisos";
            this.buttonAvisos.Size = new System.Drawing.Size(100, 28);
            this.buttonAvisos.TabIndex = 3;
            this.buttonAvisos.Text = "Avisos";
            this.buttonAvisos.UseVisualStyleBackColor = true;
            this.buttonAvisos.Click += new System.EventHandler(this.buttonAvisos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Perfil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelSeguridad3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAvisos);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCrear);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelSeguridad3";
            this.Text = "Administración";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonAvisos;
        private System.Windows.Forms.Button button1;

    }
}