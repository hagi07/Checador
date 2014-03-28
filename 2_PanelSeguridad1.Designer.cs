namespace Checador
{
    partial class PanelSeguridad1
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
            this.buttonAvisos = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAvisos
            // 
            this.buttonAvisos.Location = new System.Drawing.Point(72, 127);
            this.buttonAvisos.Name = "buttonAvisos";
            this.buttonAvisos.Size = new System.Drawing.Size(75, 23);
            this.buttonAvisos.TabIndex = 7;
            this.buttonAvisos.Text = "Avisos";
            this.buttonAvisos.UseVisualStyleBackColor = true;
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(72, 82);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(75, 23);
            this.buttonReportes.TabIndex = 6;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(72, 36);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // PanelSeguridad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 196);
            this.Controls.Add(this.buttonAvisos);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonEditar);
            this.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.Name = "PanelSeguridad1";
            this.Text = "Usuario";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAvisos;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonEditar;
    }
}