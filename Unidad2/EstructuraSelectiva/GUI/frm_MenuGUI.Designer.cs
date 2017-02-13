namespace EstructuraSelectiva
{
    partial class frm_MenuGUI
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
            this.bnt_Pro1 = new System.Windows.Forms.Button();
            this.btn_Pro2 = new System.Windows.Forms.Button();
            this.btn_Pro3 = new System.Windows.Forms.Button();
            this.btn_Pro4 = new System.Windows.Forms.Button();
            this.btn_Pro5 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_Pro1
            // 
            this.bnt_Pro1.Location = new System.Drawing.Point(53, 77);
            this.bnt_Pro1.Name = "bnt_Pro1";
            this.bnt_Pro1.Size = new System.Drawing.Size(75, 23);
            this.bnt_Pro1.TabIndex = 0;
            this.bnt_Pro1.Text = "1";
            this.bnt_Pro1.UseVisualStyleBackColor = true;
            this.bnt_Pro1.Click += new System.EventHandler(this.bnt_Pro1_Click);
            // 
            // btn_Pro2
            // 
            this.btn_Pro2.Location = new System.Drawing.Point(134, 77);
            this.btn_Pro2.Name = "btn_Pro2";
            this.btn_Pro2.Size = new System.Drawing.Size(75, 23);
            this.btn_Pro2.TabIndex = 1;
            this.btn_Pro2.Text = "2";
            this.btn_Pro2.UseVisualStyleBackColor = true;
            this.btn_Pro2.Click += new System.EventHandler(this.btn_Pro2_Click);
            // 
            // btn_Pro3
            // 
            this.btn_Pro3.Location = new System.Drawing.Point(215, 77);
            this.btn_Pro3.Name = "btn_Pro3";
            this.btn_Pro3.Size = new System.Drawing.Size(75, 23);
            this.btn_Pro3.TabIndex = 2;
            this.btn_Pro3.Text = "3";
            this.btn_Pro3.UseVisualStyleBackColor = true;
            this.btn_Pro3.Click += new System.EventHandler(this.btn_Pro3_Click);
            // 
            // btn_Pro4
            // 
            this.btn_Pro4.Location = new System.Drawing.Point(299, 77);
            this.btn_Pro4.Name = "btn_Pro4";
            this.btn_Pro4.Size = new System.Drawing.Size(75, 23);
            this.btn_Pro4.TabIndex = 3;
            this.btn_Pro4.Text = "4";
            this.btn_Pro4.UseVisualStyleBackColor = true;
            this.btn_Pro4.Click += new System.EventHandler(this.btn_Pro4_Click);
            // 
            // btn_Pro5
            // 
            this.btn_Pro5.Location = new System.Drawing.Point(381, 77);
            this.btn_Pro5.Name = "btn_Pro5";
            this.btn_Pro5.Size = new System.Drawing.Size(75, 23);
            this.btn_Pro5.TabIndex = 4;
            this.btn_Pro5.Text = "5";
            this.btn_Pro5.UseVisualStyleBackColor = true;
            this.btn_Pro5.Click += new System.EventHandler(this.btn_Pro5_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(215, 117);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_MenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Pro5);
            this.Controls.Add(this.btn_Pro4);
            this.Controls.Add(this.btn_Pro3);
            this.Controls.Add(this.btn_Pro2);
            this.Controls.Add(this.bnt_Pro1);
            this.Name = "frm_MenuGUI";
            this.Text = "Menú             ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_Pro1;
        private System.Windows.Forms.Button btn_Pro2;
        private System.Windows.Forms.Button btn_Pro3;
        private System.Windows.Forms.Button btn_Pro4;
        private System.Windows.Forms.Button btn_Pro5;
        private System.Windows.Forms.Button btn_Salir;
    }
}

