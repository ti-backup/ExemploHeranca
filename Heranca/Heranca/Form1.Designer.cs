namespace Heranca
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
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.cmbAnimais = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTeste
            // 
            this.txtTeste.Location = new System.Drawing.Point(374, 84);
            this.txtTeste.Multiline = true;
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(226, 245);
            this.txtTeste.TabIndex = 0;
            // 
            // cmbAnimais
            // 
            this.cmbAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimais.FormattingEnabled = true;
            this.cmbAnimais.Location = new System.Drawing.Point(64, 51);
            this.cmbAnimais.Name = "cmbAnimais";
            this.cmbAnimais.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimais.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbAnimais);
            this.Controls.Add(this.txtTeste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeste;
        private System.Windows.Forms.ComboBox cmbAnimais;
    }
}

