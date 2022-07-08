namespace dotnet_library
{
    partial class Cadastro_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(33, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 23);
            this.txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(33, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(33, 148);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(241, 23);
            this.txtCep.TabIndex = 4;
            this.txtCep.Leave += new System.EventHandler(this.Sair);
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(280, 46);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(179, 23);
            this.txtRua.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(280, 99);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(263, 23);
            this.txtBairro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(280, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(280, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(462, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(285, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estado";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(462, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(81, 23);
            this.txtNumero.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(280, 148);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(123, 23);
            this.txtEstado.TabIndex = 13;
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.Location = new System.Drawing.Point(33, 185);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(97, 31);
            this.bntCadastrar.TabIndex = 14;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.UseVisualStyleBackColor = true;
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(433, 185);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(110, 31);
            this.bntLimpar.TabIndex = 15;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(409, 148);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(134, 23);
            this.txtCidade.TabIndex = 16;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.ForeColor = System.Drawing.SystemColors.Window;
            this.lb.Location = new System.Drawing.Point(409, 130);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(44, 15);
            this.lb.TabIndex = 17;
            this.lb.Text = "Cidade";
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(566, 266);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cadastro_Cliente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lb;
    }
}