namespace EstructuraSelectiva.GUI
{
    partial class frm_NumeroMedioGUI
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
            this.lbl_Numero1 = new System.Windows.Forms.Label();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.lbl_Num3 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Num3 = new System.Windows.Forms.TextBox();
            this.txt_NumMedio = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Numero1
            // 
            this.lbl_Numero1.AutoSize = true;
            this.lbl_Numero1.Location = new System.Drawing.Point(40, 34);
            this.lbl_Numero1.Name = "lbl_Numero1";
            this.lbl_Numero1.Size = new System.Drawing.Size(53, 13);
            this.lbl_Numero1.TabIndex = 0;
            this.lbl_Numero1.Text = "Numero 1";
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.Location = new System.Drawing.Point(40, 62);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(53, 13);
            this.lbl_Numero2.TabIndex = 1;
            this.lbl_Numero2.Text = "Numero 2";
            // 
            // lbl_Num3
            // 
            this.lbl_Num3.AutoSize = true;
            this.lbl_Num3.Location = new System.Drawing.Point(40, 89);
            this.lbl_Num3.Name = "lbl_Num3";
            this.lbl_Num3.Size = new System.Drawing.Size(53, 13);
            this.lbl_Num3.TabIndex = 2;
            this.lbl_Num3.Text = "Numero 3";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(27, 118);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(75, 13);
            this.lbl_Resultado.TabIndex = 3;
            this.lbl_Resultado.Text = "Numero medio";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(119, 34);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(100, 20);
            this.txt_Num1.TabIndex = 4;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(119, 59);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(100, 20);
            this.txt_Num2.TabIndex = 5;
            // 
            // txt_Num3
            // 
            this.txt_Num3.Location = new System.Drawing.Point(119, 82);
            this.txt_Num3.Name = "txt_Num3";
            this.txt_Num3.Size = new System.Drawing.Size(100, 20);
            this.txt_Num3.TabIndex = 6;
            // 
            // txt_NumMedio
            // 
            this.txt_NumMedio.Location = new System.Drawing.Point(119, 115);
            this.txt_NumMedio.Name = "txt_NumMedio";
            this.txt_NumMedio.Size = new System.Drawing.Size(100, 20);
            this.txt_NumMedio.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(119, 169);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_NumeroMedioGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_NumMedio);
            this.Controls.Add(this.txt_Num3);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_Num3);
            this.Controls.Add(this.lbl_Numero2);
            this.Controls.Add(this.lbl_Numero1);
            this.Name = "frm_NumeroMedioGUI";
            this.Text = "Numero de en medio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Numero1;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.Label lbl_Num3;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Num3;
        private System.Windows.Forms.TextBox txt_NumMedio;
        private System.Windows.Forms.Button btn_Calcular;
    }
}