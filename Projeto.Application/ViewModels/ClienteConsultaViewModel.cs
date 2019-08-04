using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class ClienteConsultaViewModel
    {
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

        public  string Cep
        {
            get;
            set;
        }
    }
}
