using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Clientes.Entities
{
    public class Endereco
    {
        public int IdEndereco
        {
            get;
            set;
        }

        public string Logradouro
        {
            get;
            set;
        }

        public string Cidade
        {
            get;
            set;
        }

        public string Estado
        {
            get;
            set;
        }

        public string Cep
        {
            get;
            set;
        }

        ///Associacao 1p1
        public Cliente Cliente
        {
            get;
            set;
        }
    }
}
