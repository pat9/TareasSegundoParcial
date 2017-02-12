namespace EstructuraSelectiva.GUI
{
    partial class frm_SumaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SumaGUI));
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_Resul = new System.Windows.Forms.TextBox();
            this.lbl_Res = new System.Windows.Forms.Label();
            this.btn_Sumar = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(48, 54);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 20);
            this.txt_Num.TabIndex = 0;
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(48, 35);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(50, 13);
            this.lbl_Numero.TabIndex = 1;
            this.lbl_Numero.Text = "Numero: ";
            // 
            // txt_Resul
            // 
            this.txt_Resul.Location = new System.Drawing.Point(51, 104);
            this.txt_Resul.Name = "txt_Resul";
            this.txt_Resul.Size = new System.Drawing.Size(100, 20);
            this.txt_Resul.TabIndex = 2;
            // 
            // lbl_Res
            // 
            this.lbl_Res.AutoSize = true;
            this.lbl_Res.Location = new System.Drawing.Point(51, 85);
            this.lbl_Res.Name = "lbl_Res";
            this.lbl_Res.Size = new System.Drawing.Size(55, 13);
            this.lbl_Res.TabIndex = 3;
            this.lbl_Res.Text = "Resultado";
            // 
            // btn_Sumar
            // 
            this.btn_Sumar.Location = new System.Drawing.Point(183, 50);
            this.btn_Sumar.Name = "btn_Sumar";
            this.btn_Sumar.Size = new System.Drawing.Size(75, 23);
            this.btn_Sumar.TabIndex = 4;
            this.btn_Sumar.Text = "Sumar";
            this.btn_Sumar.UseVisualStyleBackColor = true;
            this.btn_Sumar.Click += new System.EventHandler(this.btn_Sumar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Regresar.FlatAppearance.BorderSize = 0;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Regresar.Image")));
            this.btn_Regresar.Location = new System.Drawing.Point(347, 12);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(73, 75);
            this.btn_Regresar.TabIndex = 11;
            this.btn_Regresar.UseVisualStyleBackColor = false;
            // 
            // frm_SumaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 167);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Sumar);
            this.Controls.Add(this.lbl_Res);
            this.Controls.Add(this.txt_Resul);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.txt_Num);
            this.Name = "frm_SumaGUI";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox txt_Resul;
        private System.Windows.Forms.Label lbl_Res;
        private System.Windows.Forms.Button btn_Sumar;
        private System.Windows.Forms.Button btn_Regresar;
    }
}