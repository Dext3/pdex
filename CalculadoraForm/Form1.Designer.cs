namespace CalculadoraForm
{
    partial class Form1
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
            this.mtbResultado = new System.Windows.Forms.MaskedTextBox();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btmais = new System.Windows.Forms.Button();
            this.btmenos = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btmulTiplicar = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbResultado
            // 
            this.mtbResultado.Location = new System.Drawing.Point(22, 12);
            this.mtbResultado.Name = "mtbResultado";
            this.mtbResultado.Size = new System.Drawing.Size(275, 20);
            this.mtbResultado.TabIndex = 0;
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(22, 48);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 23);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.btNumero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(103, 48);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 23);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.btNumero);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(184, 48);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 23);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.btNumero);
            // 
            // btmais
            // 
            this.btmais.Location = new System.Drawing.Point(265, 48);
            this.btmais.Name = "btmais";
            this.btmais.Size = new System.Drawing.Size(32, 23);
            this.btmais.TabIndex = 4;
            this.btmais.Text = "+";
            this.btmais.UseVisualStyleBackColor = true;
            this.btmais.Click += new System.EventHandler(this.btOperacao);
            // 
            // btmenos
            // 
            this.btmenos.Location = new System.Drawing.Point(265, 77);
            this.btmenos.Name = "btmenos";
            this.btmenos.Size = new System.Drawing.Size(32, 23);
            this.btmenos.TabIndex = 8;
            this.btmenos.Text = "-";
            this.btmenos.UseVisualStyleBackColor = true;
            this.btmenos.Click += new System.EventHandler(this.btOperacao);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(184, 77);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 23);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.btNumero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(103, 77);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 23);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.btNumero);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(22, 77);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 23);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.btNumero);
            // 
            // btmulTiplicar
            // 
            this.btmulTiplicar.Location = new System.Drawing.Point(265, 106);
            this.btmulTiplicar.Name = "btmulTiplicar";
            this.btmulTiplicar.Size = new System.Drawing.Size(32, 23);
            this.btmulTiplicar.TabIndex = 12;
            this.btmulTiplicar.Text = "/";
            this.btmulTiplicar.UseVisualStyleBackColor = true;
            this.btmulTiplicar.Click += new System.EventHandler(this.btOperacao);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(184, 106);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.btNumero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(103, 106);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.btNumero);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(22, 106);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.btNumero);
            // 
            // btMult
            // 
            this.btMult.Location = new System.Drawing.Point(265, 135);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(32, 23);
            this.btMult.TabIndex = 16;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btOperacao);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(184, 135);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(75, 23);
            this.btIgual.TabIndex = 15;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(103, 135);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 23);
            this.bt0.TabIndex = 14;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.btNumero);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(22, 135);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 13;
            this.button16.Text = "Limpar";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btLimpar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 184);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btmulTiplicar);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btmenos);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btmais);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.mtbResultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbResultado;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btmais;
        private System.Windows.Forms.Button btmenos;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btmulTiplicar;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button button16;
    }
}

