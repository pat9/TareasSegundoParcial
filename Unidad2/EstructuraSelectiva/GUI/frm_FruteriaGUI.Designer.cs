namespace EstructuraSelectiva.GUI
{
    partial class frm_FruteriaGUI
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
            this.lbl_Kilos = new System.Windows.Forms.Label();
            this.lbl_PrecioKilo = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Kilos = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_PrecioKilo = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Kilos
            // 
            this.lbl_Kilos.AutoSize = true;
            this.lbl_Kilos.Location = new System.Drawing.Point(43, 40);
            this.lbl_Kilos.Name = "lbl_Kilos";
            this.lbl_Kilos.Size = new System.Drawing.Size(29, 13);
            this.lbl_Kilos.TabIndex = 0;
            this.lbl_Kilos.Text = "Kilos";
            // 
            // lbl_PrecioKilo
            // 
            this.lbl_PrecioKilo.AutoSize = true;
            this.lbl_PrecioKilo.Location = new System.Drawing.Point(43, 72);
            this.lbl_PrecioKilo.Name = "lbl_PrecioKilo";
            this.lbl_PrecioKilo.Size = new System.Drawing.Size(74, 13);
            this.lbl_PrecioKilo.TabIndex = 1;
            this.lbl_PrecioKilo.Text = "Precio por kilo";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(46, 104);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.lbl_Total.TabIndex = 2;
            this.lbl_Total.Text = "Total";
            // 
            // txt_Kilos
            // 
            this.txt_Kilos.Location = new System.Drawing.Point(143, 37);
            this.txt_Kilos.Name = "txt_Kilos";
            this.txt_Kilos.Size = new System.Drawing.Size(100, 20);
            this.txt_Kilos.TabIndex = 3;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(143, 101);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 4;
            // 
            // txt_PrecioKilo
            // 
            this.txt_PrecioKilo.Location = new System.Drawing.Point(143, 69);
            this.txt_PrecioKilo.Name = "txt_PrecioKilo";
            this.txt_PrecioKilo.Size = new System.Drawing.Size(100, 20);
            this.txt_PrecioKilo.TabIndex = 5;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(100, 153);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_FruteriaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_PrecioKilo);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Kilos);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_PrecioKilo);
            this.Controls.Add(this.lbl_Kilos);
            this.Name = "frm_FruteriaGUI";
            this.Text = "Fruteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kilos;
        private System.Windows.Forms.Label lbl_PrecioKilo;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Kilos;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_PrecioKilo;
        private System.Windows.Forms.Button btn_Calcular;
    }
}