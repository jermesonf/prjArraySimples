namespace PrjArraySimples
{
    partial class FrmArraySimples
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnVarrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(40, 97);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(127, 20);
            this.txtValor.TabIndex = 0;
            // 
            // btnVarrer
            // 
            this.btnVarrer.Location = new System.Drawing.Point(40, 123);
            this.btnVarrer.Name = "btnVarrer";
            this.btnVarrer.Size = new System.Drawing.Size(127, 23);
            this.btnVarrer.TabIndex = 1;
            this.btnVarrer.Text = "Varredura";
            this.btnVarrer.UseVisualStyleBackColor = true;
            this.btnVarrer.Click += new System.EventHandler(this.btnVarrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "P1 = 27, P2 = 73, P3 = 99";
            // 
            // FrmArraySimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVarrer);
            this.Controls.Add(this.txtValor);
            this.Name = "FrmArraySimples";
            this.Text = "Array Simples";
            this.Load += new System.EventHandler(this.FrmArraySimples_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnVarrer;
        private System.Windows.Forms.Label label1;
    }
}

