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
			this.NumericX = new System.Windows.Forms.NumericUpDown();
			this.button5 = new System.Windows.Forms.Button();
			this.NumericY = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.NumericZ = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.NumericA = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.NumericB = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.NumericC = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.listBox1 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.NumericX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericC)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Inicializar Lista";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.InicializarLista);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button2.Location = new System.Drawing.Point(12, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Adicionar Elemento";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.AdicionaElemento);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 495);
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
			this.button4.Location = new System.Drawing.Point(12, 70);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(119, 41);
			this.button4.TabIndex = 3;
			this.button4.Text = "Adicionar Elemento em X Posição";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.AdicionarElementoXPosição);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "X =";
			// 
			// NumericX
			// 
			this.NumericX.Location = new System.Drawing.Point(38, 118);
			this.NumericX.Name = "NumericX";
			this.NumericX.Size = new System.Drawing.Size(93, 20);
			this.NumericX.TabIndex = 5;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button5.Location = new System.Drawing.Point(12, 144);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(119, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "Remover Elemento Y";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.RemoverElemento);
			// 
			// NumericY
			// 
			this.NumericY.Location = new System.Drawing.Point(38, 173);
			this.NumericY.Name = "NumericY";
			this.NumericY.Size = new System.Drawing.Size(93, 20);
			this.NumericY.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Y =";
			// 
			// NumericZ
			// 
			this.NumericZ.Location = new System.Drawing.Point(38, 260);
			this.NumericZ.Name = "NumericZ";
			this.NumericZ.Size = new System.Drawing.Size(93, 20);
			this.NumericZ.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 262);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Z =";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button6.Location = new System.Drawing.Point(12, 199);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(119, 55);
			this.button6.TabIndex = 9;
			this.button6.Text = "Adicionar Elemento Após Elemento com Z Valor";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.AdicionarElementoAposZValor);
			// 
			// NumericA
			// 
			this.NumericA.Location = new System.Drawing.Point(38, 333);
			this.NumericA.Name = "NumericA";
			this.NumericA.Size = new System.Drawing.Size(93, 20);
			this.NumericA.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 335);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "A =";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button7.Location = new System.Drawing.Point(12, 286);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(119, 41);
			this.button7.TabIndex = 12;
			this.button7.Text = "Trocar Elemento A por Elemento B";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.TrocarElementosAB);
			// 
			// NumericB
			// 
			this.NumericB.Location = new System.Drawing.Point(38, 359);
			this.NumericB.Name = "NumericB";
			this.NumericB.Size = new System.Drawing.Size(93, 20);
			this.NumericB.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 361);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "B =";
			// 
			// NumericC
			// 
			this.NumericC.Location = new System.Drawing.Point(38, 446);
			this.NumericC.Name = "NumericC";
			this.NumericC.Size = new System.Drawing.Size(93, 20);
			this.NumericC.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 448);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "C =";
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button8.Location = new System.Drawing.Point(12, 385);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(119, 55);
			this.button8.TabIndex = 17;
			this.button8.Text = "Remover Elemento com Valor ou Posição C";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(12, 472);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(63, 17);
			this.radioButton1.TabIndex = 20;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Posição";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(81, 472);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(49, 17);
			this.radioButton2.TabIndex = 21;
			this.radioButton2.Text = "Valor";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(205, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(190, 498);
			this.listBox1.TabIndex = 22;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 530);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.NumericC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.NumericB);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.NumericA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.NumericZ);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.NumericY);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.NumericX);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Lista Encadeada";
			this.Load += new System.EventHandler(this.CarregarPrograma);
			((System.ComponentModel.ISupportInitialize)(this.NumericX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericC)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NumericX;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.NumericUpDown NumericY;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown NumericZ;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.NumericUpDown NumericA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.NumericUpDown NumericB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown NumericC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.ListBox listBox1;

    }
}

