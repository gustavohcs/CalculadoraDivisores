
namespace CalculadoraDivisores.Manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.lblDivisores = new System.Windows.Forms.Label();
            this.textBoxDivisores = new System.Windows.Forms.TextBox();
            this.lblPrimos = new System.Windows.Forms.Label();
            this.textBoxPrimos = new System.Windows.Forms.TextBox();
            this.imgTitulo = new System.Windows.Forms.PictureBox();
            this.lblVersao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(172, 99);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(176, 23);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(48, 101);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(116, 15);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Número de Entrada: ";
            this.lblInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(414, 101);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // lblDivisores
            // 
            this.lblDivisores.AutoSize = true;
            this.lblDivisores.Location = new System.Drawing.Point(49, 147);
            this.lblDivisores.Name = "lblDivisores";
            this.lblDivisores.Size = new System.Drawing.Size(108, 15);
            this.lblDivisores.TabIndex = 3;
            this.lblDivisores.Text = "Números divisores:";
            this.lblDivisores.Click += new System.EventHandler(this.lblDivisores_Click);
            // 
            // textBoxDivisores
            // 
            this.textBoxDivisores.Location = new System.Drawing.Point(49, 174);
            this.textBoxDivisores.Multiline = true;
            this.textBoxDivisores.Name = "textBoxDivisores";
            this.textBoxDivisores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDivisores.Size = new System.Drawing.Size(440, 175);
            this.textBoxDivisores.TabIndex = 4;
            this.textBoxDivisores.ReadOnly = true;
            this.textBoxDivisores.BackColor = System.Drawing.SystemColors.Window;
            // 
            // lblPrimos
            // 
            this.lblPrimos.AutoSize = true;
            this.lblPrimos.Location = new System.Drawing.Point(49, 361);
            this.lblPrimos.Name = "lblPrimos";
            this.lblPrimos.Size = new System.Drawing.Size(97, 15);
            this.lblPrimos.TabIndex = 5;
            this.lblPrimos.Text = "Divisores Primos:";
            this.lblPrimos.Click += new System.EventHandler(this.lblPrimos_Click);
            // 
            // textBoxPrimos
            // 
            this.textBoxPrimos.Location = new System.Drawing.Point(49, 386);
            this.textBoxPrimos.Multiline = true;
            this.textBoxPrimos.Name = "textBoxPrimos";
            this.textBoxPrimos.Size = new System.Drawing.Size(440, 38);
            this.textBoxPrimos.TabIndex = 6;
            this.textBoxPrimos.ReadOnly = true;
            this.textBoxPrimos.BackColor = System.Drawing.SystemColors.Window;

            // 
            // imgTitulo
            // 
            this.imgTitulo.Image = global::CalculadoraDivisores.Manager.Properties.Resources.titulo;
            this.imgTitulo.Location = new System.Drawing.Point(35, 12);
            this.imgTitulo.Name = "imgTitulo";
            this.imgTitulo.Size = new System.Drawing.Size(481, 67);
            this.imgTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTitulo.TabIndex = 7;
            this.imgTitulo.TabStop = false;
            this.imgTitulo.Click += new System.EventHandler(this.imgTitulo_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(450, 456);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(41, 15);
            this.lblVersao.TabIndex = 8;
            this.lblVersao.Text = "Versão";
            this.lblVersao.Click += new System.EventHandler(this.lblVersao_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(552, 473);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.imgTitulo);
            this.Controls.Add(this.textBoxPrimos);
            this.Controls.Add(this.lblPrimos);
            this.Controls.Add(this.textBoxDivisores);
            this.Controls.Add(this.lblDivisores);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Calculadora de Divisores";
            this.Text = "Calculadora de Divisores";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label lblDivisores;
        private System.Windows.Forms.TextBox textBoxDivisores;
        private System.Windows.Forms.Label lblPrimos;
        private System.Windows.Forms.TextBox textBoxPrimos;
        private System.Windows.Forms.PictureBox imgTitulo;
        private System.Windows.Forms.Label lblVersao;
    }
}

