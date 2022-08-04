
namespace dotnet_library
{
    partial class Recuperacao_Senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperacao_Senha));
            this.txtEmailValidacao = new System.Windows.Forms.TextBox();
            this.btnRecuperarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailValidacao
            // 
            this.txtEmailValidacao.Location = new System.Drawing.Point(32, 88);
            this.txtEmailValidacao.Name = "txtEmailValidacao";
            this.txtEmailValidacao.Size = new System.Drawing.Size(265, 23);
            this.txtEmailValidacao.TabIndex = 0;
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.Location = new System.Drawing.Point(32, 127);
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Size = new System.Drawing.Size(111, 31);
            this.btnRecuperarSenha.TabIndex = 1;
            this.btnRecuperarSenha.Text = "Recuperar Senha";
            this.btnRecuperarSenha.UseVisualStyleBackColor = true;
            this.btnRecuperarSenha.Click += new System.EventHandler(this.btnRecuperarSenha_Click);
            this.btnRecuperarSenha.MouseLeave += new System.EventHandler(this.btnRecuperarSenha_MouseLeave);
            this.btnRecuperarSenha.MouseHover += new System.EventHandler(this.btnRecuperarSenha_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe seu email";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 127);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(106, 164);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 31);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseLeave += new System.EventHandler(this.btnLimpar_MouseLeave);
            this.btnLimpar.MouseHover += new System.EventHandler(this.btnLimpar_MouseHover);
            // 
            // Recuperacao_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(327, 254);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecuperarSenha);
            this.Controls.Add(this.txtEmailValidacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recuperacao_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperacao_Senha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recuperacao_Senha_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailValidacao;
        private System.Windows.Forms.Button btnRecuperarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
    }
}