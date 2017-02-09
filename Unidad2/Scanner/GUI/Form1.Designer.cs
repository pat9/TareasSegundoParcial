namespace Scanner
{
    partial class frm_Escan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Escan));
            this.btn_Escanear = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_Red = new System.Windows.Forms.Label();
            this.lbl_SubMask = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Red = new System.Windows.Forms.TextBox();
            this.txt_Mask = new System.Windows.Forms.TextBox();
            this.btn_Bloc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Escanear
            // 
            this.btn_Escanear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Escanear.Image")));
            this.btn_Escanear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Escanear.Location = new System.Drawing.Point(109, 38);
            this.btn_Escanear.Name = "btn_Escanear";
            this.btn_Escanear.Size = new System.Drawing.Size(98, 40);
            this.btn_Escanear.TabIndex = 0;
            this.btn_Escanear.Text = "Escanear";
            this.btn_Escanear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Escanear.UseVisualStyleBackColor = true;
            this.btn_Escanear.Click += new System.EventHandler(this.btn_Escanear_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(75, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(180, 18);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Sistema de escaneo V 1.0";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(12, 100);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(17, 13);
            this.lbl_IP.TabIndex = 2;
            this.lbl_IP.Text = "IP";
            // 
            // lbl_Red
            // 
            this.lbl_Red.AutoSize = true;
            this.lbl_Red.Location = new System.Drawing.Point(12, 126);
            this.lbl_Red.Name = "lbl_Red";
            this.lbl_Red.Size = new System.Drawing.Size(27, 13);
            this.lbl_Red.TabIndex = 3;
            this.lbl_Red.Text = "Red";
            // 
            // lbl_SubMask
            // 
            this.lbl_SubMask.AutoSize = true;
            this.lbl_SubMask.Location = new System.Drawing.Point(172, 94);
            this.lbl_SubMask.Name = "lbl_SubMask";
            this.lbl_SubMask.Size = new System.Drawing.Size(67, 13);
            this.lbl_SubMask.TabIndex = 4;
            this.lbl_SubMask.Text = "SubMascara";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(55, 97);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 20);
            this.txt_IP.TabIndex = 5;
            // 
            // txt_Red
            // 
            this.txt_Red.Location = new System.Drawing.Point(55, 123);
            this.txt_Red.Name = "txt_Red";
            this.txt_Red.Size = new System.Drawing.Size(100, 20);
            this.txt_Red.TabIndex = 6;
            // 
            // txt_Mask
            // 
            this.txt_Mask.Location = new System.Drawing.Point(175, 110);
            this.txt_Mask.Name = "txt_Mask";
            this.txt_Mask.Size = new System.Drawing.Size(100, 20);
            this.txt_Mask.TabIndex = 7;
            // 
            // btn_Bloc
            // 
            this.btn_Bloc.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bloc.Image")));
            this.btn_Bloc.Location = new System.Drawing.Point(130, 165);
            this.btn_Bloc.Name = "btn_Bloc";
            this.btn_Bloc.Size = new System.Drawing.Size(63, 53);
            this.btn_Bloc.TabIndex = 8;
            this.btn_Bloc.UseVisualStyleBackColor = true;
            this.btn_Bloc.Click += new System.EventHandler(this.btn_Bloc_Click);
            // 
            // frm_Escan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 230);
            this.Controls.Add(this.btn_Bloc);
            this.Controls.Add(this.txt_Mask);
            this.Controls.Add(this.txt_Red);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.lbl_SubMask);
            this.Controls.Add(this.lbl_Red);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Escanear);
            this.Name = "frm_Escan";
            this.Text = "Escaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Escanear;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_Red;
        private System.Windows.Forms.Label lbl_SubMask;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Red;
        private System.Windows.Forms.TextBox txt_Mask;
        private System.Windows.Forms.Button btn_Bloc;
    }
}

