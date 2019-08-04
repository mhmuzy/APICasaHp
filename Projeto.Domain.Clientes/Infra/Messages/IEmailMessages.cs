using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Entities;

namespace Projeto.Domain.Clientes.Infra.Messages
{
    public interface IEmailMessages
    {
        void EnviarConfirmacaoDeCadastro(Cliente c);
    }
}
