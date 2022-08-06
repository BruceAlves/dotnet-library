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
            this.bntLivrosDisponiveis.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntLivrosDisponiveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLivrosDisponiveis.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntLivrosDisponiveis.ForeColor = System.Drawing.SystemColors.Window;
            this.bntLivrosDisponiveis.Location = new System.Drawing.Point(225, 56);
            this.bntLivrosDisponiveis.Name = "bntLivrosDisponiveis";
            this.bntLivrosDisponiveis.Size = new System.Drawing.Size(181, 71);
            this.bntLivrosDisponiveis.TabIndex = 0;
            this.bntLivrosDisponiveis.Text = "Livros disponíveis";
            this.bntLivrosDisponiveis.UseVisualStyleBackColor = false;
            this.bntLivrosDisponiveis.Click += new System.EventHandler(this.bntLivrosDisponiveis_Click);
            // 
            // bntLivrosEmprestados
            // 
            this.bntLivrosEmprestados.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntLivrosEmprestados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLivrosEmprestados.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntLivrosEmprestados.ForeColor = System.Drawing.SystemColors.Window;
            this.bntLivrosEmprestados.Location = new System.Drawing.Point(225, 153);
            this.bntLivrosEmprestados.Name = "bntLivrosEmprestados";
            this.bntLivrosEmprestados.Size = new System.Drawing.Size(181, 72);
            this.bntLivrosEmprestados.TabIndex = 1;
            this.bntLivrosEmprestados.Text = "Livros emprestados";
            this.bntLivrosEmprestados.UseVisualStyleBackColor = false;
            this.bntLivrosEmprestados.Click += new System.EventHandler(this.bntLivrosEmprestados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione uma opção";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Tela_Auxiliar_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(447, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntLivrosEmprestados);
            this.Controls.Add(this.bntLivrosDisponiveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Auxiliar_Emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione uma opção";
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