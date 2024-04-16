namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.ponto = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.maismenos = new System.Windows.Forms.Button();
            this.somar = new System.Windows.Forms.Button();
            this.subitrair = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.restodivisao = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.cancelaeapaga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(300, 53);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Enter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Enter.Location = new System.Drawing.Point(11, 390);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(298, 50);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "=";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // ponto
            // 
            this.ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto.Location = new System.Drawing.Point(163, 334);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(70, 50);
            this.ponto.TabIndex = 8;
            this.ponto.Text = ".";
            this.ponto.UseVisualStyleBackColor = true;
            this.ponto.Click += new System.EventHandler(this.virgula_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(87, 334);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 50);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // maismenos
            // 
            this.maismenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.maismenos.Location = new System.Drawing.Point(11, 334);
            this.maismenos.Name = "maismenos";
            this.maismenos.Size = new System.Drawing.Size(70, 50);
            this.maismenos.TabIndex = 10;
            this.maismenos.Text = "+/-";
            this.maismenos.UseVisualStyleBackColor = true;
            this.maismenos.Click += new System.EventHandler(this.maismenos_Click);
            // 
            // somar
            // 
            this.somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.somar.Location = new System.Drawing.Point(239, 334);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(70, 50);
            this.somar.TabIndex = 11;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // subitrair
            // 
            this.subitrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.subitrair.Location = new System.Drawing.Point(239, 278);
            this.subitrair.Name = "subitrair";
            this.subitrair.Size = new System.Drawing.Size(70, 50);
            this.subitrair.TabIndex = 12;
            this.subitrair.Text = "-";
            this.subitrair.UseVisualStyleBackColor = true;
            this.subitrair.Click += new System.EventHandler(this.subitrair_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.multiplicar.Location = new System.Drawing.Point(239, 222);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(70, 50);
            this.multiplicar.TabIndex = 13;
            this.multiplicar.Text = "×";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.dividir.Location = new System.Drawing.Point(241, 166);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(70, 50);
            this.dividir.TabIndex = 14;
            this.dividir.Text = "÷";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(163, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 50);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(87, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 50);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(11, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 50);
            this.button4.TabIndex = 18;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(87, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 50);
            this.button5.TabIndex = 19;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(163, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 50);
            this.button6.TabIndex = 20;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button14_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(163, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 50);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button15_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(87, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 50);
            this.button8.TabIndex = 22;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button16_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(11, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 50);
            this.button7.TabIndex = 23;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button17_Click);
            // 
            // restodivisao
            // 
            this.restodivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.restodivisao.Location = new System.Drawing.Point(11, 110);
            this.restodivisao.Name = "restodivisao";
            this.restodivisao.Size = new System.Drawing.Size(70, 50);
            this.restodivisao.TabIndex = 30;
            this.restodivisao.Text = "%";
            this.restodivisao.UseVisualStyleBackColor = true;
            this.restodivisao.Click += new System.EventHandler(this.restodivisao_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonCopy.Location = new System.Drawing.Point(163, 110);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(70, 50);
            this.buttonCopy.TabIndex = 31;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // apagar
            // 
            this.apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.apagar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.apagar.Location = new System.Drawing.Point(239, 110);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(70, 50);
            this.apagar.TabIndex = 32;
            this.apagar.Text = "⬅";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click_1);
            // 
            // cancelaeapaga
            // 
            this.cancelaeapaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelaeapaga.Location = new System.Drawing.Point(87, 110);
            this.cancelaeapaga.Name = "cancelaeapaga";
            this.cancelaeapaga.Size = new System.Drawing.Size(70, 50);
            this.cancelaeapaga.TabIndex = 33;
            this.cancelaeapaga.Text = "CE";
            this.cancelaeapaga.UseVisualStyleBackColor = true;
            this.cancelaeapaga.Click += new System.EventHandler(this.cancelaeapaga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 459);
            this.Controls.Add(this.cancelaeapaga);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.restodivisao);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.subitrair);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.maismenos);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.ponto);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button ponto;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button maismenos;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button subitrair;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button restodivisao;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button cancelaeapaga;
    }
}

