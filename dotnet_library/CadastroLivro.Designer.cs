
namespace dotnet_library
{
    partial class CadastroLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivro));
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.btnCancelarCadastroLivro = new System.Windows.Forms.Button();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxGenero
            // 
            this.cbxGenero.AllowDrop = true;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(12, 86);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxGenero.Size = new System.Drawing.Size(197, 23);
            this.cbxGenero.TabIndex = 0;
           
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(279, 131);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarLivro.TabIndex = 1;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // btnCancelarCadastroLivro
            // 
            this.btnCancelarCadastroLivro.Location = new System.Drawing.Point(360, 131);
            this.btnCancelarCadastroLivro.Name = "btnCancelarCadastroLivro";
            this.btnCancelarCadastroLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastroLivro.TabIndex = 2;
            this.btnCancelarCadastroLivro.Text = "Limpar";
            this.btnCancelarCadastroLivro.UseVisualStyleBackColor = true;
            this.btnCancelarCadastroLivro.Click += new System.EventHandler(this.btnCancelarCadastroLivro_Click);
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(12, 39);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(197, 23);
            this.txtNomeLivro.TabIndex = 3;
            this.txtNomeLivro.Enter += new System.EventHandler(this.txtNomeLivro_Enter);
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(238, 86);
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(197, 23);
            this.txtSinopse.TabIndex = 6;
            this.txtSinopse.Enter += new System.EventHandler(this.txtSinopse_Enter);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(238, 39);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(197, 23);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.Enter += new System.EventHandler(this.txtAutor_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sinopse";
            // 
            // CadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(456, 169);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarCadastroLivro);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNomeLivro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroLivro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroLivro_FormClosed);
            this.Load += new System.EventHandler(this.CadastroLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Button btnCancelarCadastroLivro;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}