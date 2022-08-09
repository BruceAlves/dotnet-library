using dotnet_library.Conexao.Livros;
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
            SessaoUsuario.CodigoRecuperacao = guid.ToString().ToUpper().Substring(0, 4);
            SessaoUsuario.Email = txtEmailValidacao.Text;

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
                    mail.IsBodyHtml = true;
                    mail.Subject = "Recuperação de senha";
                    mail.Body = @"<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Document</title>

    <style>
        #DivRecuperacao{

            width: 350px;
            height: 300px;
            background-color: grey;
            margin-left: auto;
            margin-right: auto;
            padding: 20px;
            text-align: center;
            border-radius: 15px;
            color: white;
        }
        #DivCodigo{
            width: 200px;
            height: 100px;
            background-color: cornflowerblue;
            padding: 5px;
            margin-left: auto;
            margin-right: auto;
            text-align: center;
        }

        #DivCodigo p{

            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <div id='DivRecuperacao'>
        <h3>
            Recuperação de senha DotNet Library!
        </h3>
        <div id='DivCodigo'>
            <p>
                CÓDIGO: 
            </p>
            <h2>
               " + SessaoUsuario.CodigoRecuperacao + @" 
            </h2>
        </div>
    </div>
</body>
</html>";

                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new NetworkCredential(emailRemetente, senhaEmail);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);

                    MessageBox.Show("Código de verificação foi enviado para o email informado, confira sua caixa de spam!","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                    Recuperar_Senha recuperar_Senha = new Recuperar_Senha();
                    recuperar_Senha.ShowDialog();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
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
