namespace matematicas
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
            this.lblserie = new System.Windows.Forms.Label();
            this.lblrespuesta_serie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnmedia_aritmetica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(12, 37);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(39, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "SERIE";
            // 
            // lblrespuesta_serie
            // 
            this.lblrespuesta_serie.AutoSize = true;
            this.lblrespuesta_serie.Location = new System.Drawing.Point(12, 92);
            this.lblrespuesta_serie.Name = "lblrespuesta_serie";
            this.lblrespuesta_serie.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta_serie.TabIndex = 1;
            this.lblrespuesta_serie.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnmedia_aritmetica
            // 
            this.btnmedia_aritmetica.Location = new System.Drawing.Point(15, 140);
            this.btnmedia_aritmetica.Name = "btnmedia_aritmetica";
            this.btnmedia_aritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnmedia_aritmetica.TabIndex = 3;
            this.btnmedia_aritmetica.Text = "Calcular X";
            this.btnmedia_aritmetica.UseVisualStyleBackColor = true;
            this.btnmedia_aritmetica.Click += new System.EventHandler(this.btnmedia_aritmetica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnmedia_aritmetica);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblrespuesta_serie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.Label lblrespuesta_serie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnmedia_aritmetica;
    }
}

