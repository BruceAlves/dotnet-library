
namespace dotnet_library
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 238);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastrarLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarLivro.Location = new System.Drawing.Point(12, 116);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(128, 31);
            this.btnCadastrarLivro.TabIndex = 2;
            this.btnCadastrarLivro.Text = "Cadastrar Livro";
            this.btnCadastrarLivro.UseVisualStyleBackColor = false;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            this.btnCadastrarLivro.MouseLeave += new System.EventHandler(this.btnCadastrarLivro_MouseLeave);
            this.btnCadastrarLivro.MouseHover += new System.EventHandler(this.btnCadastrarLivro_MouseHover);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEmprestimos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmprestimos.Location = new System.Drawing.Point(12, 164);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(128, 31);
            this.btnEmprestimos.TabIndex = 3;
            this.btnEmprestimos.Text = "Emprestimos";
            this.btnEmprestimos.UseVisualStyleBackColor = false;
            this.btnEmprestimos.Click += new System.EventHandler(this.btnEmprestimos_Click);
            this.btnEmprestimos.MouseLeave += new System.EventHandler(this.btnEmprestimos_MouseLeave);
            this.btnEmprestimos.MouseHover += new System.EventHandler(this.btnEmprestimos_MouseHover);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastroCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastroCliente.Location = new System.Drawing.Point(12, 69);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(128, 31);
            this.btnCadastroCliente.TabIndex = 1;
            this.btnCadastroCliente.Text = "Cadastro Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            this.btnCadastroCliente.MouseLeave += new System.EventHandler(this.btnCadastroCliente_MouseLeave);
            this.btnCadastroCliente.MouseHover += new System.EventHandler(this.btnCadastroCliente_MouseHover);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastroUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastroUsuario.Location = new System.Drawing.Point(12, 21);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(128, 31);
            this.btnCadastroUsuario.TabIndex = 0;
            this.btnCadastroUsuario.Text = "Cadastro Usuário";
            this.btnCadastroUsuario.UseVisualStyleBackColor = false;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroUsuario_Click);
            this.btnCadastroUsuario.MouseLeave += new System.EventHandler(this.btnCadastroUsuario_MouseLeave);
            this.btnCadastroUsuario.MouseHover += new System.EventHandler(this.btnCadastroUsuario_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(12, 211);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 31);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(470, 262);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.btnEmprestimos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dotnet Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.Button btnLogout;
    }
}