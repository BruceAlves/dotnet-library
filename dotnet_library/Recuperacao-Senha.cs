using dotnet_library.Conexao.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library
{
    public partial class Recuperacao_Senha : Form
    {
        public Recuperacao_Senha()
        {
            InitializeComponent();
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {

            Usuario usuario = new();
            bool resultado = usuario.VerificarEmailUsuario(txtEmailValidacao.Text);

            Guid guid = Guid.NewGuid();
            string senhaTemporaria = guid.ToString().ToUpper().Substring(0, 4);

            string emailRemetente = ConfigurationManager.AppSettings["emailfrom"]!;
            string senhaEmail = ConfigurationManager.AppSettings["senhaEmail"]!;

            if (resultado)
            {
                try
                {
                    SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");
                    var mail = new MailMessage();
                    mail.From = new MailAddress(emailRemetente);
                    mail.To.Add(txtEmailValidacao.Text);

                    mail.Subject = "Recuperação de senha";
                    mail.Body = $"Sua senha temporaria é {senhaTemporaria}";

                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new NetworkCredential(emailRemetente, senhaEmail);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Email Enviado!");
            }
            else
            {
                MessageBox.Show($@"Não foi possível recuperar a senha!
               Digite um email válido!", "Email Invalido!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRecuperarSenha_MouseHover(object sender, EventArgs e)
        {
            btnRecuperarSenha.BackColor = Color.DodgerBlue;
        }

        private void btnRecuperarSenha_MouseLeave(object sender, EventArgs e)
        {
            btnRecuperarSenha.BackColor = Color.White;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.DodgerBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
        }

        private void btnLimpar_MouseHover(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.DodgerBlue;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.White;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Login voltarLogin = new Login();
            voltarLogin.Show();
            this.Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEmailValidacao.Text = string.Empty;
        }

        private void Recuperacao_Senha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }
    }
}
