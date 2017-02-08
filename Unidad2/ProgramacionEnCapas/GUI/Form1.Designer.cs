namespace ProgramacionEnCapas
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
            this.lbl_Valor1 = new System.Windows.Forms.Label();
            this.lbl_Valor2 = new System.Windows.Forms.Label();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.cmb_Opcion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Valor1
            // 
            this.lbl_Valor1.AutoSize = true;
            this.lbl_Valor1.Location = new System.Drawing.Point(29, 20);
            this.lbl_Valor1.Name = "lbl_Valor1";
            this.lbl_Valor1.Size = new System.Drawing.Size(43, 13);
            this.lbl_Valor1.TabIndex = 0;
            this.lbl_Valor1.Text = "Valor 1:";
            // 
            // lbl_Valor2
            // 
            this.lbl_Valor2.AutoSize = true;
            this.lbl_Valor2.Location = new System.Drawing.Point(29, 58);
            this.lbl_Valor2.Name = "lbl_Valor2";
            this.lbl_Valor2.Size = new System.Drawing.Size(43, 13);
            this.lbl_Valor2.TabIndex = 1;
            this.lbl_Valor2.Text = "Valor 2:";
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Location = new System.Drawing.Point(90, 20);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(101, 20);
            this.txt_Valor1.TabIndex = 2;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Location = new System.Drawing.Point(90, 55);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(101, 20);
            this.txt_Valor2.TabIndex = 3;
            // 
            // cmb_Opcion
            // 
            this.cmb_Opcion.FormattingEnabled = true;
            this.cmb_Opcion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion"});
            this.cmb_Opcion.Location = new System.Drawing.Point(90, 102);
            this.cmb_Opcion.Name = "cmb_Opcion";
            this.cmb_Opcion.Size = new System.Drawing.Size(101, 21);
            this.cmb_Opcion.TabIndex = 4;
            this.cmb_Opcion.Text = "Seleccione...";
            this.cmb_Opcion.SelectedIndexChanged += new System.EventHandler(this.cmb_Opcion_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 144);
            this.Controls.Add(this.cmb_Opcion);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.lbl_Valor2);
            this.Controls.Add(this.lbl_Valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Valor1;
        private System.Windows.Forms.Label lbl_Valor2;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.ComboBox cmb_Opcion;
    }
}

