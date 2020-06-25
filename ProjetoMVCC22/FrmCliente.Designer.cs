namespace ProjetoMVCC22
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
            this.txtCpfC22 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaeC22 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeC22 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCpfC22
            // 
            this.txtCpfC22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtCpfC22.Location = new System.Drawing.Point(100, 100);
            this.txtCpfC22.Name = "txtCpfC22";
            this.txtCpfC22.Size = new System.Drawing.Size(243, 23);
            this.txtCpfC22.TabIndex = 14;
            this.txtCpfC22.TextChanged += new System.EventHandler(this.txtCpfC30_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.Location = new System.Drawing.Point(169, 305);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(112, 51);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(97, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome da mãe:";
            // 
            // txtMaeC22
            // 
            this.txtMaeC22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtMaeC22.Location = new System.Drawing.Point(100, 241);
            this.txtMaeC22.Name = "txtMaeC22";
            this.txtMaeC22.Size = new System.Drawing.Size(243, 23);
            this.txtMaeC22.TabIndex = 11;
            this.txtMaeC22.TextChanged += new System.EventHandler(this.txtMaeC22_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(97, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome completo:";
            // 
            // txtNomeC22
            // 
            this.txtNomeC22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNomeC22.Location = new System.Drawing.Point(100, 174);
            this.txtNomeC22.Name = "txtNomeC22";
            this.txtNomeC22.Size = new System.Drawing.Size(243, 23);
            this.txtNomeC22.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(97, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 434);
            this.Controls.Add(this.txtCpfC22);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaeC22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeC22);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpfC22;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaeC22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeC22;
        private System.Windows.Forms.Label label1;
    }
}

