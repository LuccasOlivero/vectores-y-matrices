namespace WindowsFormsApp3
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
            this.comboBoxGeneros = new System.Windows.Forms.ComboBox();
            this.generosLabel = new System.Windows.Forms.Label();
            this.peliculasLabel = new System.Windows.Forms.Label();
            this.comboBoxPeliculas = new System.Windows.Forms.ComboBox();
            this.generosNuevaPeli = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxGeneros
            // 
            this.comboBoxGeneros.FormattingEnabled = true;
            this.comboBoxGeneros.Location = new System.Drawing.Point(46, 59);
            this.comboBoxGeneros.Name = "comboBoxGeneros";
            this.comboBoxGeneros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGeneros.TabIndex = 0;
            this.comboBoxGeneros.SelectedIndexChanged += new System.EventHandler(this.comboBoxGeneros_SelectedIndexChanged);
            // 
            // generosLabel
            // 
            this.generosLabel.AutoSize = true;
            this.generosLabel.Location = new System.Drawing.Point(43, 43);
            this.generosLabel.Name = "generosLabel";
            this.generosLabel.Size = new System.Drawing.Size(47, 13);
            this.generosLabel.TabIndex = 1;
            this.generosLabel.Text = "Generos";
            // 
            // peliculasLabel
            // 
            this.peliculasLabel.AutoSize = true;
            this.peliculasLabel.Location = new System.Drawing.Point(286, 43);
            this.peliculasLabel.Name = "peliculasLabel";
            this.peliculasLabel.Size = new System.Drawing.Size(49, 13);
            this.peliculasLabel.TabIndex = 3;
            this.peliculasLabel.Text = "Peliculas";
            // 
            // comboBoxPeliculas
            // 
            this.comboBoxPeliculas.FormattingEnabled = true;
            this.comboBoxPeliculas.Location = new System.Drawing.Point(289, 59);
            this.comboBoxPeliculas.Name = "comboBoxPeliculas";
            this.comboBoxPeliculas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeliculas.TabIndex = 2;
            // 
            // generosNuevaPeli
            // 
            this.generosNuevaPeli.AutoSize = true;
            this.generosNuevaPeli.Location = new System.Drawing.Point(43, 101);
            this.generosNuevaPeli.Name = "generosNuevaPeli";
            this.generosNuevaPeli.Size = new System.Drawing.Size(47, 13);
            this.generosNuevaPeli.TabIndex = 5;
            this.generosNuevaPeli.Text = "Generos";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(46, 117);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.Location = new System.Drawing.Point(290, 98);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(120, 95);
            this.listBoxPeliculas.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(455, 256);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxPeliculas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generosNuevaPeli);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.peliculasLabel);
            this.Controls.Add(this.comboBoxPeliculas);
            this.Controls.Add(this.generosLabel);
            this.Controls.Add(this.comboBoxGeneros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGeneros;
        private System.Windows.Forms.Label generosLabel;
        private System.Windows.Forms.Label peliculasLabel;
        private System.Windows.Forms.ComboBox comboBoxPeliculas;
        private System.Windows.Forms.Label generosNuevaPeli;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.TextBox textBox1;
    }
}

