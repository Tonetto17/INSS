namespace inss2206
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_SalarioInicial = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Inss = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_ImpostoRenda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_SalarioFinal = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o seu sálario:";
            // 
            // tbox_SalarioInicial
            // 
            this.tbox_SalarioInicial.Location = new System.Drawing.Point(235, 51);
            this.tbox_SalarioInicial.Name = "tbox_SalarioInicial";
            this.tbox_SalarioInicial.Size = new System.Drawing.Size(100, 29);
            this.tbox_SalarioInicial.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(128, 97);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(163, 32);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular ";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seu inss é de:";
            // 
            // lb_Inss
            // 
            this.lb_Inss.AutoSize = true;
            this.lb_Inss.Location = new System.Drawing.Point(174, 166);
            this.lb_Inss.Name = "lb_Inss";
            this.lb_Inss.Size = new System.Drawing.Size(25, 24);
            this.lb_Inss.TabIndex = 4;
            this.lb_Inss.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seu imposto de renda é de:";
            // 
            // lb_ImpostoRenda
            // 
            this.lb_ImpostoRenda.AutoSize = true;
            this.lb_ImpostoRenda.Location = new System.Drawing.Point(288, 220);
            this.lb_ImpostoRenda.Name = "lb_ImpostoRenda";
            this.lb_ImpostoRenda.Size = new System.Drawing.Size(25, 24);
            this.lb_ImpostoRenda.TabIndex = 6;
            this.lb_ImpostoRenda.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sálario Final:";
            // 
            // lb_SalarioFinal
            // 
            this.lb_SalarioFinal.AutoSize = true;
            this.lb_SalarioFinal.Location = new System.Drawing.Point(162, 270);
            this.lb_SalarioFinal.Name = "lb_SalarioFinal";
            this.lb_SalarioFinal.Size = new System.Drawing.Size(25, 24);
            this.lb_SalarioFinal.TabIndex = 8;
            this.lb_SalarioFinal.Text = "...";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(128, 320);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(163, 32);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(400, 364);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lb_SalarioFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_ImpostoRenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Inss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.tbox_SalarioInicial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_SalarioInicial;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Inss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_ImpostoRenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_SalarioFinal;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

