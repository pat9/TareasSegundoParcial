namespace SistemaVolado.GUI
{
    partial class frm_SistemaGUI
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
            this.lbl_Compra = new System.Windows.Forms.Label();
            this.lbl_Moneda = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_Compra = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.cmb_Moneda = new System.Windows.Forms.ComboBox();
            this.btn_Regreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Compra
            // 
            this.lbl_Compra.AutoSize = true;
            this.lbl_Compra.Location = new System.Drawing.Point(25, 26);
            this.lbl_Compra.Name = "lbl_Compra";
            this.lbl_Compra.Size = new System.Drawing.Size(43, 13);
            this.lbl_Compra.TabIndex = 0;
            this.lbl_Compra.Text = "Compra";
            // 
            // lbl_Moneda
            // 
            this.lbl_Moneda.AutoSize = true;
            this.lbl_Moneda.Location = new System.Drawing.Point(25, 52);
            this.lbl_Moneda.Name = "lbl_Moneda";
            this.lbl_Moneda.Size = new System.Drawing.Size(46, 13);
            this.lbl_Moneda.TabIndex = 1;
            this.lbl_Moneda.Text = "Moneda";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(28, 83);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "Total";
            // 
            // txt_Compra
            // 
            this.txt_Compra.Location = new System.Drawing.Point(78, 23);
            this.txt_Compra.Name = "txt_Compra";
            this.txt_Compra.Size = new System.Drawing.Size(121, 20);
            this.txt_Compra.TabIndex = 3;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(78, 76);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(121, 20);
            this.txt_Total.TabIndex = 4;
            // 
            // cmb_Moneda
            // 
            this.cmb_Moneda.FormattingEnabled = true;
            this.cmb_Moneda.Items.AddRange(new object[] {
            "Sol",
            "Aguila",
            "Intermedio"});
            this.cmb_Moneda.Location = new System.Drawing.Point(78, 49);
            this.cmb_Moneda.Name = "cmb_Moneda";
            this.cmb_Moneda.Size = new System.Drawing.Size(121, 21);
            this.cmb_Moneda.TabIndex = 5;
            this.cmb_Moneda.Text = "Seleccione...";
            this.cmb_Moneda.SelectedIndexChanged += new System.EventHandler(this.cmb_Moneda_SelectedIndexChanged);
            // 
            // btn_Regreso
            // 
            this.btn_Regreso.Location = new System.Drawing.Point(53, 111);
            this.btn_Regreso.Name = "btn_Regreso";
            this.btn_Regreso.Size = new System.Drawing.Size(101, 25);
            this.btn_Regreso.TabIndex = 6;
            this.btn_Regreso.Text = "Regresar";
            this.btn_Regreso.UseVisualStyleBackColor = true;
            this.btn_Regreso.Click += new System.EventHandler(this.btn_Regreso_Click);
            // 
            // frm_SistemaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 148);
            this.Controls.Add(this.btn_Regreso);
            this.Controls.Add(this.cmb_Moneda);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Compra);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_Moneda);
            this.Controls.Add(this.lbl_Compra);
            this.Name = "frm_SistemaGUI";
            this.Text = "Sistema de volado";
            this.Load += new System.EventHandler(this.frm_SistemaGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Compra;
        private System.Windows.Forms.Label lbl_Moneda;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_Compra;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.ComboBox cmb_Moneda;
        private System.Windows.Forms.Button btn_Regreso;
    }
}