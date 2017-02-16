namespace Ciclos
{
    partial class frm_PromGUI
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
            this.lbl_NumCalf = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.txt_Prom = new System.Windows.Forms.TextBox();
            this.lbl_Prom = new System.Windows.Forms.Label();
            this.btn_Capture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_NumCalf
            // 
            this.lbl_NumCalf.AutoSize = true;
            this.lbl_NumCalf.Location = new System.Drawing.Point(47, 32);
            this.lbl_NumCalf.Name = "lbl_NumCalf";
            this.lbl_NumCalf.Size = new System.Drawing.Size(110, 13);
            this.lbl_NumCalf.TabIndex = 0;
            this.lbl_NumCalf.Text = "Numero Calficaciones";
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(50, 48);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 20);
            this.txt_Num.TabIndex = 1;
            // 
            // txt_Prom
            // 
            this.txt_Prom.Location = new System.Drawing.Point(50, 120);
            this.txt_Prom.Name = "txt_Prom";
            this.txt_Prom.Size = new System.Drawing.Size(100, 20);
            this.txt_Prom.TabIndex = 3;
            // 
            // lbl_Prom
            // 
            this.lbl_Prom.AutoSize = true;
            this.lbl_Prom.Location = new System.Drawing.Point(72, 104);
            this.lbl_Prom.Name = "lbl_Prom";
            this.lbl_Prom.Size = new System.Drawing.Size(51, 13);
            this.lbl_Prom.TabIndex = 2;
            this.lbl_Prom.Text = "Promedio";
            // 
            // btn_Capture
            // 
            this.btn_Capture.Location = new System.Drawing.Point(47, 75);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(107, 23);
            this.btn_Capture.TabIndex = 4;
            this.btn_Capture.Text = "Capturar";
            this.btn_Capture.UseVisualStyleBackColor = true;
            this.btn_Capture.Click += new System.EventHandler(this.btn_Capture_Click);
            // 
            // frm_PromGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 170);
            this.Controls.Add(this.btn_Capture);
            this.Controls.Add(this.txt_Prom);
            this.Controls.Add(this.lbl_Prom);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.lbl_NumCalf);
            this.Name = "frm_PromGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NumCalf;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_Prom;
        private System.Windows.Forms.Label lbl_Prom;
        private System.Windows.Forms.Button btn_Capture;
    }
}

