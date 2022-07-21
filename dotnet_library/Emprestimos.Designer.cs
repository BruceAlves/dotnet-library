namespace dotnet_library
{
    partial class Emprestimos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emprestimos));
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.lbLivros = new System.Windows.Forms.Label();
            this.bntEmprestar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(28, 49);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.RowTemplate.Height = 25;
            this.dgvLivros.Size = new System.Drawing.Size(257, 319);
            this.dgvLivros.TabIndex = 0;
            // 
            // lbLivros
            // 
            this.lbLivros.AutoSize = true;
            this.lbLivros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLivros.ForeColor = System.Drawing.Color.White;
            this.lbLivros.Location = new System.Drawing.Point(28, 25);
            this.lbLivros.Name = "lbLivros";
            this.lbLivros.Size = new System.Drawing.Size(55, 21);
            this.lbLivros.TabIndex = 1;
            this.lbLivros.Text = "Livros:";
            // 
            // bntEmprestar
            // 
            this.bntEmprestar.Location = new System.Drawing.Point(28, 374);
            this.bntEmprestar.Name = "bntEmprestar";
            this.bntEmprestar.Size = new System.Drawing.Size(102, 32);
            this.bntEmprestar.TabIndex = 2;
            this.bntEmprestar.Text = "Emprestar";
            this.bntEmprestar.UseVisualStyleBackColor = true;
            this.bntEmprestar.Click += new System.EventHandler(this.bntEmprestar_Click);
            // 
            // Emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(315, 418);
            this.Controls.Add(this.bntEmprestar);
            this.Controls.Add(this.lbLivros);
            this.Controls.Add(this.dgvLivros);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emprestimos";
            this.Text = "Emprestimos";
            this.Load += new System.EventHandler(this.Emprestimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Label lbLivros;
        private System.Windows.Forms.Button bntEmprestar;
    }
}