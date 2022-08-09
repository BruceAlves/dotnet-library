
namespace dotnet_library
{
    partial class Recuperar_Senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar_Senha));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComfirmarCodigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnComfirmar = new System.Windows.Forms.Button();
            this.txtComfirmarSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCriarSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupComfirmarSenha = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupComfirmarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(140, 116);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '*';
            this.txtCodigo.Size = new System.Drawing.Size(177, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para verificar a sua conta, insira o código de segurança que enviamos por e-mail:" +
    "";
            // 
            // btnComfirmarCodigo
            // 
            this.btnComfirmarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComfirmarCodigo.Location = new System.Drawing.Point(323, 114);
            this.btnComfirmarCodigo.Name = "btnComfirmarCodigo";
            this.btnComfirmarCodigo.Size = new System.Drawing.Size(122, 24);
            this.btnComfirmarCodigo.TabIndex = 9;
            this.btnComfirmarCodigo.Text = "Confirmar código";
            this.btnComfirmarCodigo.UseVisualStyleBackColor = true;
            this.btnComfirmarCodigo.Click += new System.EventHandler(this.btnComfirmarCodigo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Insira o código de segurança";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Código de segurança:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnComfirmar
            // 
            this.btnComfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComfirmar.Enabled = false;
            this.btnComfirmar.Location = new System.Drawing.Point(346, 55);
            this.btnComfirmar.Name = "btnComfirmar";
            this.btnComfirmar.Size = new System.Drawing.Size(116, 24);
            this.btnComfirmar.TabIndex = 20;
            this.btnComfirmar.Text = "Confirmar senha";
            this.btnComfirmar.UseVisualStyleBackColor = true;
            this.btnComfirmar.Click += new System.EventHandler(this.btnComfirmar_Click_1);
            // 
            // txtComfirmarSenha
            // 
            this.txtComfirmarSenha.Enabled = false;
            this.txtComfirmarSenha.Location = new System.Drawing.Point(137, 57);
            this.txtComfirmarSenha.Name = "txtComfirmarSenha";
            this.txtComfirmarSenha.PasswordChar = '*';
            this.txtComfirmarSenha.Size = new System.Drawing.Size(203, 23);
            this.txtComfirmarSenha.TabIndex = 19;
            this.txtComfirmarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Comfirmar senha:";
            // 
            // txtCriarSenha
            // 
            this.txtCriarSenha.Enabled = false;
            this.txtCriarSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCriarSenha.Location = new System.Drawing.Point(137, 22);
            this.txtCriarSenha.Name = "txtCriarSenha";
            this.txtCriarSenha.PasswordChar = '*';
            this.txtCriarSenha.Size = new System.Drawing.Size(325, 23);
            this.txtCriarSenha.TabIndex = 17;
            this.txtCriarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Criar  nova senha:";
            // 
            // groupComfirmarSenha
            // 
            this.groupComfirmarSenha.Controls.Add(this.btnComfirmar);
            this.groupComfirmarSenha.Controls.Add(this.txtComfirmarSenha);
            this.groupComfirmarSenha.Controls.Add(this.label4);
            this.groupComfirmarSenha.Controls.Add(this.txtCriarSenha);
            this.groupComfirmarSenha.Controls.Add(this.label3);
            this.groupComfirmarSenha.Location = new System.Drawing.Point(17, 154);
            this.groupComfirmarSenha.Name = "groupComfirmarSenha";
            this.groupComfirmarSenha.Size = new System.Drawing.Size(468, 100);
            this.groupComfirmarSenha.TabIndex = 21;
            this.groupComfirmarSenha.TabStop = false;
            this.groupComfirmarSenha.Visible = false;
            // 
            // Recuperar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(509, 266);
            this.Controls.Add(this.groupComfirmarSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComfirmarCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Recuperar_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar senha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupComfirmarSenha.ResumeLayout(false);
            this.groupComfirmarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComfirmarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnComfirmar;
        private System.Windows.Forms.TextBox txtComfirmarSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCriarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupComfirmarSenha;
    }
}