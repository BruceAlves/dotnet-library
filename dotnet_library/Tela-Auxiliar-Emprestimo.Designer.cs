namespace dotnet_library
{
    partial class Tela_Auxiliar_Emprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Auxiliar_Emprestimo));
            this.bntLivrosDisponiveis = new System.Windows.Forms.Button();
            this.bntLivrosEmprestados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntLivrosDisponiveis
            // 
            this.bntLivrosDisponiveis.Location = new System.Drawing.Point(12, 61);
            this.bntLivrosDisponiveis.Name = "bntLivrosDisponiveis";
            this.bntLivrosDisponiveis.Size = new System.Drawing.Size(124, 56);
            this.bntLivrosDisponiveis.TabIndex = 0;
            this.bntLivrosDisponiveis.Text = "Livros Disponíveis";
            this.bntLivrosDisponiveis.UseVisualStyleBackColor = true;
            this.bntLivrosDisponiveis.Click += new System.EventHandler(this.bntLivrosDisponiveis_Click);
            // 
            // bntLivrosEmprestados
            // 
            this.bntLivrosEmprestados.Location = new System.Drawing.Point(243, 61);
            this.bntLivrosEmprestados.Name = "bntLivrosEmprestados";
            this.bntLivrosEmprestados.Size = new System.Drawing.Size(124, 56);
            this.bntLivrosEmprestados.TabIndex = 1;
            this.bntLivrosEmprestados.Text = "Livros Emprestados";
            this.bntLivrosEmprestados.UseVisualStyleBackColor = true;
            this.bntLivrosEmprestados.Click += new System.EventHandler(this.bntLivrosEmprestados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione uma Opção";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Tela_Auxiliar_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(384, 178);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntLivrosEmprestados);
            this.Controls.Add(this.bntLivrosDisponiveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Auxiliar_Emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Auxiliar Emprestimo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_Auxiliar_Emprestimo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntLivrosDisponiveis;
        private System.Windows.Forms.Button bntLivrosEmprestados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}