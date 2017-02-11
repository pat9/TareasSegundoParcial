namespace SistemaVolado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Sistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Sistema
            // 
            this.btn_Sistema.Location = new System.Drawing.Point(37, 48);
            this.btn_Sistema.Name = "btn_Sistema";
            this.btn_Sistema.Size = new System.Drawing.Size(193, 147);
            this.btn_Sistema.TabIndex = 0;
            this.btn_Sistema.Text = "Abrir Sistema de volada";
            this.btn_Sistema.UseVisualStyleBackColor = true;
            this.btn_Sistema.Click += new System.EventHandler(this.btn_Sistema_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Sistema);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sistema;
    }
}

