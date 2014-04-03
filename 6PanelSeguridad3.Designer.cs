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
            this.SuspendLayout();
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(79, 50);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 0;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(79, 79);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(79, 108);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(75, 23);
            this.buttonReportes.TabIndex = 2;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonAvisos
            // 
            this.buttonAvisos.Location = new System.Drawing.Point(79, 137);
            this.buttonAvisos.Name = "buttonAvisos";
            this.buttonAvisos.Size = new System.Drawing.Size(75, 23);
            this.buttonAvisos.TabIndex = 3;
            this.buttonAvisos.Text = "Avisos";
            this.buttonAvisos.UseVisualStyleBackColor = true;
            this.buttonAvisos.Click += new System.EventHandler(this.buttonAvisos_Click);
            // 
            // PanelSeguridad3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 210);
            this.Controls.Add(this.buttonAvisos);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCrear);
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

    }
}