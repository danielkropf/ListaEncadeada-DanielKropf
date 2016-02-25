namespace _2015_3003_1BIM_ListaEncadeada
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.numeric1 = new System.Windows.Forms.NumericUpDown();
			this.numeric2 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.numeric3 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.numeric5 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.numeric4 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.posicaoRadio = new System.Windows.Forms.RadioButton();
			this.valorRadio = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric4)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(335, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Inicializar Lista";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.InicializarLista);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button2.Location = new System.Drawing.Point(12, 49);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Adiciona Elemento";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.AdicionaElemento);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 457);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(119, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Exibir Lista";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.ExibirLista);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button4.Location = new System.Drawing.Point(12, 78);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(119, 39);
			this.button4.TabIndex = 3;
			this.button4.Text = "Adiciona Elemento em posição \"X\"";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.AdicionarElementoXPos);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "X =";
			// 
			// numeric1
			// 
			this.numeric1.Location = new System.Drawing.Point(43, 123);
			this.numeric1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numeric1.Name = "numeric1";
			this.numeric1.ReadOnly = true;
			this.numeric1.Size = new System.Drawing.Size(88, 20);
			this.numeric1.TabIndex = 5;
			// 
			// numeric2
			// 
			this.numeric2.Location = new System.Drawing.Point(43, 205);
			this.numeric2.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numeric2.Name = "numeric2";
			this.numeric2.ReadOnly = true;
			this.numeric2.Size = new System.Drawing.Size(88, 20);
			this.numeric2.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "X =";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button5.Location = new System.Drawing.Point(12, 149);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(119, 50);
			this.button5.TabIndex = 6;
			this.button5.Text = "Adiciona Elemento Após Elemento com Valor \"X\"";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.AdicionarElementoAposXValor);
			// 
			// numeric3
			// 
			this.numeric3.Location = new System.Drawing.Point(43, 300);
			this.numeric3.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numeric3.Name = "numeric3";
			this.numeric3.ReadOnly = true;
			this.numeric3.Size = new System.Drawing.Size(88, 20);
			this.numeric3.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 303);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "X =";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button6.Location = new System.Drawing.Point(12, 231);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(119, 63);
			this.button6.TabIndex = 9;
			this.button6.Text = "Trocar posição de elemento \"X\" com elemento de posição \"Y\"";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.TrocarPosXPosY);
			// 
			// numeric5
			// 
			this.numeric5.Location = new System.Drawing.Point(43, 408);
			this.numeric5.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numeric5.Name = "numeric5";
			this.numeric5.ReadOnly = true;
			this.numeric5.Size = new System.Drawing.Size(88, 20);
			this.numeric5.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 411);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "X =";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button7.Location = new System.Drawing.Point(12, 352);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(119, 50);
			this.button7.TabIndex = 12;
			this.button7.Text = "Remover Elemento Usando Posiçao/Valor \"X\"";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.RemoverElemento);
			// 
			// numeric4
			// 
			this.numeric4.Location = new System.Drawing.Point(43, 326);
			this.numeric4.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numeric4.Name = "numeric4";
			this.numeric4.ReadOnly = true;
			this.numeric4.Size = new System.Drawing.Size(88, 20);
			this.numeric4.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 329);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Y =";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(137, 47);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(210, 433);
			this.listBox1.TabIndex = 17;
			// 
			// posicaoRadio
			// 
			this.posicaoRadio.AutoSize = true;
			this.posicaoRadio.Checked = true;
			this.posicaoRadio.Location = new System.Drawing.Point(12, 434);
			this.posicaoRadio.Name = "posicaoRadio";
			this.posicaoRadio.Size = new System.Drawing.Size(63, 17);
			this.posicaoRadio.TabIndex = 18;
			this.posicaoRadio.TabStop = true;
			this.posicaoRadio.Text = "Posição";
			this.posicaoRadio.UseVisualStyleBackColor = true;
			// 
			// valorRadio
			// 
			this.valorRadio.AutoSize = true;
			this.valorRadio.Location = new System.Drawing.Point(81, 434);
			this.valorRadio.Name = "valorRadio";
			this.valorRadio.Size = new System.Drawing.Size(49, 17);
			this.valorRadio.TabIndex = 19;
			this.valorRadio.Text = "Valor";
			this.valorRadio.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 489);
			this.Controls.Add(this.valorRadio);
			this.Controls.Add(this.posicaoRadio);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.numeric4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.numeric5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.numeric3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.numeric2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.numeric1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = " ";
			this.Load += new System.EventHandler(this.CarregarPrograma);
			((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.NumericUpDown numeric2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numeric3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numeric5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown numeric4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.RadioButton posicaoRadio;
		private System.Windows.Forms.RadioButton valorRadio;

    }
}

