using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Clientes.Entities
{
    public class Cliente
    {
        public int IdCliente
        {
            get;
            set;
        }

        public string Nome
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public DateTime DataNascimento
        {
            get;
            set;
        }

        ///Associacao 1p1
        public Endereco Endereco
        {
            get;
            set;
        }
    }
}
