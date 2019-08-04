using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Application.ViewModels;

namespace Projeto.Application.ApplicationServices.Contracts
{
    public interface IAppServiceCliente
    {
        void Cadastrar(ClienteCadastroViewModel model);

        void Alterar(ClienteEdicaoViewModel model);

        List<ClienteConsultaViewModel> Consultar();

        List<ClienteConsultaViewModel> ConsultarPorId(int id);
    }
}
