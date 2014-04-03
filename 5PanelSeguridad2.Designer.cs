namespace Checador
{
    partial class PanelSeguridad2
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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAvisos
            // 
            this.buttonAvisos.Location = new System.Drawing.Point(75, 114);
            this.buttonAvisos.Name = "buttonAvisos";
            this.buttonAvisos.Size = new System.Drawing.Size(75, 23);
            this.buttonAvisos.TabIndex = 6;
            this.buttonAvisos.Text = "Avisos";
            this.buttonAvisos.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(75, 85);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(75, 56);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 4;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // PanelSeguridad2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 210);
            this.Controls.Add(this.buttonAvisos);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCrear);
            this.Name = "PanelSeguridad2";
            this.Text = "Administración";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAvisos;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonCrear;

    }
}