namespace Proyecto_Algebra_Lineal
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
            this.button1 = new System.Windows.Forms.Button();
            this.Kernels = new System.Windows.Forms.ComboBox();
            this.F_Original = new System.Windows.Forms.PictureBox();
            this.F_Procesada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Personalizado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Fotografia = new System.Windows.Forms.Button();
            this.Seleccion_Imagen = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.F_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_Procesada)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Realizar Kernel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kernels
            // 
            this.Kernels.FormattingEnabled = true;
            this.Kernels.Items.AddRange(new object[] {
            "Difuminado",
            "Realzar",
            "Sobel Inferior",
            "Sobel Superior",
            "Sobel Izquierdo",
            "Sobel Derecho",
            "Contorno",
            "Afilar",
            "Original"});
            this.Kernels.Location = new System.Drawing.Point(278, 87);
            this.Kernels.Name = "Kernels";
            this.Kernels.Size = new System.Drawing.Size(219, 24);
            this.Kernels.TabIndex = 1;
            this.Kernels.SelectedIndexChanged += new System.EventHandler(this.Kernels_SelectedIndexChanged);
            // 
            // F_Original
            // 
            this.F_Original.Location = new System.Drawing.Point(668, 12);
            this.F_Original.Name = "F_Original";
            this.F_Original.Size = new System.Drawing.Size(316, 236);
            this.F_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.F_Original.TabIndex = 2;
            this.F_Original.TabStop = false;
            // 
            // F_Procesada
            // 
            this.F_Procesada.Location = new System.Drawing.Point(668, 290);
            this.F_Procesada.Name = "F_Procesada";
            this.F_Procesada.Size = new System.Drawing.Size(316, 234);
            this.F_Procesada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.F_Procesada.TabIndex = 3;
            this.F_Procesada.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione Kernel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kernel Personalizado";
            // 
            // Personalizado
            // 
            this.Personalizado.Location = new System.Drawing.Point(278, 264);
            this.Personalizado.Name = "Personalizado";
            this.Personalizado.Size = new System.Drawing.Size(219, 22);
            this.Personalizado.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Realizar Kernel Personalizado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fotografia
            // 
            this.Fotografia.Location = new System.Drawing.Point(278, 425);
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.Size = new System.Drawing.Size(219, 26);
            this.Fotografia.TabIndex = 8;
            this.Fotografia.Text = "Seleccionar Fotografia";
            this.Fotografia.UseVisualStyleBackColor = true;
            this.Fotografia.Click += new System.EventHandler(this.Fotografia_Click);
            // 
            // Seleccion_Imagen
            // 
            this.Seleccion_Imagen.FileName = "Seleccion_Imagen";
            this.Seleccion_Imagen.Filter = "Archivos PNG(*.png)|*.png|Archivos JPG(*.jpg)|*.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Formato: a,b,c,d,e,f,g,h,i";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 560);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fotografia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Personalizado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Procesada);
            this.Controls.Add(this.F_Original);
            this.Controls.Add(this.Kernels);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.F_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_Procesada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Kernels;
        private System.Windows.Forms.PictureBox F_Original;
        private System.Windows.Forms.PictureBox F_Procesada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Personalizado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Fotografia;
        private System.Windows.Forms.OpenFileDialog Seleccion_Imagen;
        private System.Windows.Forms.Label label3;
    }
}

