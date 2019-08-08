using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class ClienteEdicaoViewModel
    {
        public int IdCliente
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Por favor, informe o nome.")]
        public string Nome
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Por favor, informe o email.")]
        public string Email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Por favor, informe a cidade.")]
        public string Cidade
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Por favor, informe o estado.")]
        public string Estado
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Por favor, informe o cep.")]
        public string Cep
        {
            get;
            set;
        }

    }
}
