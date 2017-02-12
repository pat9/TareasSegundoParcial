namespace EstructuraSelectiva.GUI
{
    partial class frm_ReforestacionGUI
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Hectarias = new System.Windows.Forms.Label();
            this.lbl_PorPino = new System.Windows.Forms.Label();
            this.lbl_PorOya = new System.Windows.Forms.Label();
            this.txt_Hectareas = new System.Windows.Forms.TextBox();
            this.grb_Porcentajes = new System.Windows.Forms.GroupBox();
            this.txt_PorCedro = new System.Windows.Forms.TextBox();
            this.txt_PorOyamel = new System.Windows.Forms.TextBox();
            this.txt_PorPino = new System.Windows.Forms.TextBox();
            this.lbl_PorCedro = new System.Windows.Forms.Label();
            this.grb_Cantidad = new System.Windows.Forms.GroupBox();
            this.txt_CantCedro = new System.Windows.Forms.TextBox();
            this.txt_CantOyamel = new System.Windows.Forms.TextBox();
            this.txt_CantPino = new System.Windows.Forms.TextBox();
            this.lbl_CantCedro = new System.Windows.Forms.Label();
            this.lbl_CantOyamel = new System.Windows.Forms.Label();
            this.lbl_CantPinos = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.grb_Porcentajes.SuspendLayout();
            this.grb_Cantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(129, 29);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(241, 36);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Calculo de arboles";
            // 
            // lbl_Hectarias
            // 
            this.lbl_Hectarias.AutoSize = true;
            this.lbl_Hectarias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hectarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hectarias.Location = new System.Drawing.Point(131, 91);
            this.lbl_Hectarias.Name = "lbl_Hectarias";
            this.lbl_Hectarias.Size = new System.Drawing.Size(83, 20);
            this.lbl_Hectarias.TabIndex = 1;
            this.lbl_Hectarias.Text = "Hectareas";
            // 
            // lbl_PorPino
            // 
            this.lbl_PorPino.AutoSize = true;
            this.lbl_PorPino.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PorPino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PorPino.Location = new System.Drawing.Point(19, 30);
            this.lbl_PorPino.Name = "lbl_PorPino";
            this.lbl_PorPino.Size = new System.Drawing.Size(142, 20);
            this.lbl_PorPino.TabIndex = 2;
            this.lbl_PorPino.Text = "Porcentaje de Pino";
            // 
            // lbl_PorOya
            // 
            this.lbl_PorOya.AutoSize = true;
            this.lbl_PorOya.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PorOya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PorOya.Location = new System.Drawing.Point(19, 59);
            this.lbl_PorOya.Name = "lbl_PorOya";
            this.lbl_PorOya.Size = new System.Drawing.Size(164, 20);
            this.lbl_PorOya.TabIndex = 3;
            this.lbl_PorOya.Text = "Porcentaje de Oyamel";
            // 
            // txt_Hectareas
            // 
            this.txt_Hectareas.Location = new System.Drawing.Point(234, 93);
            this.txt_Hectareas.Name = "txt_Hectareas";
            this.txt_Hectareas.Size = new System.Drawing.Size(116, 20);
            this.txt_Hectareas.TabIndex = 4;
            // 
            // grb_Porcentajes
            // 
            this.grb_Porcentajes.BackColor = System.Drawing.Color.Transparent;
            this.grb_Porcentajes.Controls.Add(this.txt_PorCedro);
            this.grb_Porcentajes.Controls.Add(this.txt_PorOyamel);
            this.grb_Porcentajes.Controls.Add(this.txt_PorPino);
            this.grb_Porcentajes.Controls.Add(this.lbl_PorCedro);
            this.grb_Porcentajes.Controls.Add(this.lbl_PorOya);
            this.grb_Porcentajes.Controls.Add(this.lbl_PorPino);
            this.grb_Porcentajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Porcentajes.Location = new System.Drawing.Point(17, 144);
            this.grb_Porcentajes.Name = "grb_Porcentajes";
            this.grb_Porcentajes.Size = new System.Drawing.Size(388, 131);
            this.grb_Porcentajes.TabIndex = 5;
            this.grb_Porcentajes.TabStop = false;
            this.grb_Porcentajes.Text = "Porcentajes";
            // 
            // txt_PorCedro
            // 
            this.txt_PorCedro.Location = new System.Drawing.Point(217, 87);
            this.txt_PorCedro.Name = "txt_PorCedro";
            this.txt_PorCedro.Size = new System.Drawing.Size(116, 24);
            this.txt_PorCedro.TabIndex = 7;
            // 
            // txt_PorOyamel
            // 
            this.txt_PorOyamel.Location = new System.Drawing.Point(217, 55);
            this.txt_PorOyamel.Name = "txt_PorOyamel";
            this.txt_PorOyamel.Size = new System.Drawing.Size(116, 24);
            this.txt_PorOyamel.TabIndex = 6;
            // 
            // txt_PorPino
            // 
            this.txt_PorPino.Location = new System.Drawing.Point(217, 26);
            this.txt_PorPino.Name = "txt_PorPino";
            this.txt_PorPino.Size = new System.Drawing.Size(116, 24);
            this.txt_PorPino.TabIndex = 5;
            // 
            // lbl_PorCedro
            // 
            this.lbl_PorCedro.AutoSize = true;
            this.lbl_PorCedro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PorCedro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PorCedro.Location = new System.Drawing.Point(19, 89);
            this.lbl_PorCedro.Name = "lbl_PorCedro";
            this.lbl_PorCedro.Size = new System.Drawing.Size(154, 20);
            this.lbl_PorCedro.TabIndex = 4;
            this.lbl_PorCedro.Text = "Porcentaje de Cedro";
            // 
            // grb_Cantidad
            // 
            this.grb_Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.grb_Cantidad.Controls.Add(this.txt_CantCedro);
            this.grb_Cantidad.Controls.Add(this.txt_CantOyamel);
            this.grb_Cantidad.Controls.Add(this.txt_CantPino);
            this.grb_Cantidad.Controls.Add(this.lbl_CantCedro);
            this.grb_Cantidad.Controls.Add(this.lbl_CantOyamel);
            this.grb_Cantidad.Controls.Add(this.lbl_CantPinos);
            this.grb_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Cantidad.Location = new System.Drawing.Point(17, 299);
            this.grb_Cantidad.Name = "grb_Cantidad";
            this.grb_Cantidad.Size = new System.Drawing.Size(388, 131);
            this.grb_Cantidad.TabIndex = 8;
            this.grb_Cantidad.TabStop = false;
            this.grb_Cantidad.Text = "Cantidad de arboles";
            // 
            // txt_CantCedro
            // 
            this.txt_CantCedro.Location = new System.Drawing.Point(217, 87);
            this.txt_CantCedro.Name = "txt_CantCedro";
            this.txt_CantCedro.Size = new System.Drawing.Size(116, 24);
            this.txt_CantCedro.TabIndex = 7;
            // 
            // txt_CantOyamel
            // 
            this.txt_CantOyamel.Location = new System.Drawing.Point(217, 55);
            this.txt_CantOyamel.Name = "txt_CantOyamel";
            this.txt_CantOyamel.Size = new System.Drawing.Size(116, 24);
            this.txt_CantOyamel.TabIndex = 6;
            // 
            // txt_CantPino
            // 
            this.txt_CantPino.Location = new System.Drawing.Point(217, 26);
            this.txt_CantPino.Name = "txt_CantPino";
            this.txt_CantPino.Size = new System.Drawing.Size(116, 24);
            this.txt_CantPino.TabIndex = 5;
            // 
            // lbl_CantCedro
            // 
            this.lbl_CantCedro.AutoSize = true;
            this.lbl_CantCedro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantCedro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantCedro.Location = new System.Drawing.Point(19, 89);
            this.lbl_CantCedro.Name = "lbl_CantCedro";
            this.lbl_CantCedro.Size = new System.Drawing.Size(142, 20);
            this.lbl_CantCedro.TabIndex = 4;
            this.lbl_CantCedro.Text = "Cantidad de Cedro";
            // 
            // lbl_CantOyamel
            // 
            this.lbl_CantOyamel.AutoSize = true;
            this.lbl_CantOyamel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantOyamel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantOyamel.Location = new System.Drawing.Point(19, 59);
            this.lbl_CantOyamel.Name = "lbl_CantOyamel";
            this.lbl_CantOyamel.Size = new System.Drawing.Size(152, 20);
            this.lbl_CantOyamel.TabIndex = 3;
            this.lbl_CantOyamel.Text = "Cantidad de Oyamel";
            // 
            // lbl_CantPinos
            // 
            this.lbl_CantPinos.AutoSize = true;
            this.lbl_CantPinos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantPinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantPinos.Location = new System.Drawing.Point(19, 30);
            this.lbl_CantPinos.Name = "lbl_CantPinos";
            this.lbl_CantPinos.Size = new System.Drawing.Size(134, 20);
            this.lbl_CantPinos.TabIndex = 2;
            this.lbl_CantPinos.Text = "Cantidad  de Pino";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.Transparent;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(442, 329);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(85, 38);
            this.btn_Calcular.TabIndex = 9;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(452, 29);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(89, 36);
            this.btn_Regresar.TabIndex = 10;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // frm_ReforestacionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EstructuraSelectiva.Properties.Resources.Pantalla_1_1;
            this.ClientSize = new System.Drawing.Size(569, 465);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.grb_Cantidad);
            this.Controls.Add(this.grb_Porcentajes);
            this.Controls.Add(this.txt_Hectareas);
            this.Controls.Add(this.lbl_Hectarias);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ReforestacionGUI";
            this.Text = "Reforestacion";
            this.grb_Porcentajes.ResumeLayout(false);
            this.grb_Porcentajes.PerformLayout();
            this.grb_Cantidad.ResumeLayout(false);
            this.grb_Cantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Hectarias;
        private System.Windows.Forms.Label lbl_PorPino;
        private System.Windows.Forms.Label lbl_PorOya;
        private System.Windows.Forms.TextBox txt_Hectareas;
        private System.Windows.Forms.GroupBox grb_Porcentajes;
        private System.Windows.Forms.Label lbl_PorCedro;
        private System.Windows.Forms.TextBox txt_PorCedro;
        private System.Windows.Forms.TextBox txt_PorOyamel;
        private System.Windows.Forms.TextBox txt_PorPino;
        private System.Windows.Forms.GroupBox grb_Cantidad;
        private System.Windows.Forms.TextBox txt_CantCedro;
        private System.Windows.Forms.TextBox txt_CantOyamel;
        private System.Windows.Forms.TextBox txt_CantPino;
        private System.Windows.Forms.Label lbl_CantCedro;
        private System.Windows.Forms.Label lbl_CantOyamel;
        private System.Windows.Forms.Label lbl_CantPinos;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Regresar;
    }
}