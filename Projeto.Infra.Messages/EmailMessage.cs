using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Infra.Messages;
using Projeto.Domain.Clientes.Entities;
using System.Net.Mail;
using System.Net;

namespace Projeto.Infra.Messages
{
    public class EmailMessage : IEmailMessages
    {
        private string conta = "mhmuzy857@gmail.com";
        private string senha = "Brasil2019.12";
        public void EnviarConfirmacaoDeCadastro(Cliente c)
        {
            MailMessage mail = new MailMessage(conta, c.Email);
            mail.Subject = "Confirmação de cadastro de cliente";
            mail.Body = $"<h1>Parabéns</h1><br/>{c.Nome}, " +
                $"sua conta de cliente foi criada com sucesso";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true; //Criptografia
            smtp.Credentials = new NetworkCredential(conta, senha);
            smtp.Send(mail); //enviando a mensagem..
        }
    }
}
