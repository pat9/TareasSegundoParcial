namespace EjemplosHerramientas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chk_Raton = new System.Windows.Forms.CheckBox();
            this.chk_Libreta = new System.Windows.Forms.CheckBox();
            this.chk_Internet = new System.Windows.Forms.CheckBox();
            this.chk_Imp = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pc_Imagen = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmb_Opcion = new System.Windows.Forms.ComboBox();
            this.pic_Imagen = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Imagen)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 217);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Yellow;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.chk_Imp);
            this.tabPage1.Controls.Add(this.chk_Internet);
            this.tabPage1.Controls.Add(this.chk_Libreta);
            this.tabPage1.Controls.Add(this.chk_Raton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SELECCION";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.pc_Imagen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IMAGENES";
            // 
            // chk_Raton
            // 
            this.chk_Raton.AutoSize = true;
            this.chk_Raton.Location = new System.Drawing.Point(44, 31);
            this.chk_Raton.Name = "chk_Raton";
            this.chk_Raton.Size = new System.Drawing.Size(55, 17);
            this.chk_Raton.TabIndex = 0;
            this.chk_Raton.Text = "Raton";
            this.chk_Raton.UseVisualStyleBackColor = true;
            // 
            // chk_Libreta
            // 
            this.chk_Libreta.AutoSize = true;
            this.chk_Libreta.Location = new System.Drawing.Point(44, 54);
            this.chk_Libreta.Name = "chk_Libreta";
            this.chk_Libreta.Size = new System.Drawing.Size(58, 17);
            this.chk_Libreta.TabIndex = 1;
            this.chk_Libreta.Text = "Libreta";
            this.chk_Libreta.UseVisualStyleBackColor = true;
            // 
            // chk_Internet
            // 
            this.chk_Internet.AutoSize = true;
            this.chk_Internet.Location = new System.Drawing.Point(44, 77);
            this.chk_Internet.Name = "chk_Internet";
            this.chk_Internet.Size = new System.Drawing.Size(62, 17);
            this.chk_Internet.TabIndex = 2;
            this.chk_Internet.Text = "Internet";
            this.chk_Internet.UseVisualStyleBackColor = true;
            // 
            // chk_Imp
            // 
            this.chk_Imp.AutoSize = true;
            this.chk_Imp.Location = new System.Drawing.Point(44, 100);
            this.chk_Imp.Name = "chk_Imp";
            this.chk_Imp.Size = new System.Drawing.Size(90, 17);
            this.chk_Imp.TabIndex = 3;
            this.chk_Imp.Text = "Impresora HP";
            this.chk_Imp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pc_Imagen
            // 
            this.pc_Imagen.Location = new System.Drawing.Point(23, 20);
            this.pc_Imagen.Name = "pc_Imagen";
            this.pc_Imagen.Size = new System.Drawing.Size(196, 109);
            this.pc_Imagen.TabIndex = 0;
            this.pc_Imagen.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tabPage3.Controls.Add(this.pic_Imagen);
            this.tabPage3.Controls.Add(this.cmb_Opcion);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(251, 191);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Menú imagenes";
            // 
            // cmb_Opcion
            // 
            this.cmb_Opcion.FormattingEnabled = true;
            this.cmb_Opcion.Items.AddRange(new object[] {
            "Niña",
            "Casa",
            "Auto",
            "Computadora"});
            this.cmb_Opcion.Location = new System.Drawing.Point(59, 12);
            this.cmb_Opcion.Name = "cmb_Opcion";
            this.cmb_Opcion.Size = new System.Drawing.Size(121, 21);
            this.cmb_Opcion.TabIndex = 0;
            this.cmb_Opcion.Text = "Seleccione...";
            this.cmb_Opcion.SelectedIndexChanged += new System.EventHandler(this.cmb_Opcion_SelectedIndexChanged);
            // 
            // pic_Imagen
            // 
            this.pic_Imagen.Location = new System.Drawing.Point(26, 55);
            this.pic_Imagen.Name = "pic_Imagen";
            this.pic_Imagen.Size = new System.Drawing.Size(203, 121);
            this.pic_Imagen.TabIndex = 1;
            this.pic_Imagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Imagen)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chk_Imp;
        private System.Windows.Forms.CheckBox chk_Internet;
        private System.Windows.Forms.CheckBox chk_Libreta;
        private System.Windows.Forms.CheckBox chk_Raton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pc_Imagen;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pic_Imagen;
        private System.Windows.Forms.ComboBox cmb_Opcion;
    }
}

