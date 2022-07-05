
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxGenero
            // 
            this.cbxGenero.AllowDrop = true;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(34, 250);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxGenero.Size = new System.Drawing.Size(197, 23);
            this.cbxGenero.TabIndex = 0;
            this.cbxGenero.Text = "Gênero";
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(53, 319);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarLivro.TabIndex = 1;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // btnCancelarCadastroLivro
            // 
            this.btnCancelarCadastroLivro.Location = new System.Drawing.Point(143, 319);
            this.btnCancelarCadastroLivro.Name = "btnCancelarCadastroLivro";
            this.btnCancelarCadastroLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastroLivro.TabIndex = 2;
            this.btnCancelarCadastroLivro.Text = "Cancelar";
            this.btnCancelarCadastroLivro.UseVisualStyleBackColor = true;
            this.btnCancelarCadastroLivro.Click += new System.EventHandler(this.btnCancelarCadastroLivro_Click);
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(37, 92);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(197, 23);
            this.txtNomeLivro.TabIndex = 3;
            this.txtNomeLivro.Text = "Nome do Livro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.txtSinopse);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNomeLivro);
            this.panel1.Controls.Add(this.btnCadastrarLivro);
            this.panel1.Controls.Add(this.btnCancelarCadastroLivro);
            this.panel1.Controls.Add(this.cbxGenero);
            this.panel1.Location = new System.Drawing.Point(195, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 373);
            this.panel1.TabIndex = 4;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(34, 200);
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(197, 23);
            this.txtSinopse.TabIndex = 6;
            this.txtSinopse.Text = "Sinopse";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(34, 141);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(197, 23);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastro de  Livros";
            // 
            // CadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroLivro";
            this.Text = "CadastroLivro";
            this.Load += new System.EventHandler(this.CadastroLivro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Button btnCancelarCadastroLivro;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtAutor;
    }
}