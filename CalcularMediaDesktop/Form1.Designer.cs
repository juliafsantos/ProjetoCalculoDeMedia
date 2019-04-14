namespace CalcularMediaDesktop
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "P2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Média";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(271, 218);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(193, 65);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 20);
            this.txtP2.TabIndex = 5;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(193, 29);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 20);
            this.txtP1.TabIndex = 6;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(87, 218);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 7;
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(168, 125);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(122, 23);
            this.btnCalcularMedia.TabIndex = 8;
            this.btnCalcularMedia.Text = "Calcular Média";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 288);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcular Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnCalcularMedia;
    }
}

