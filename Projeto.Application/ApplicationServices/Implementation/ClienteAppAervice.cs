using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Application.ApplicationServices.Contracts;
using Projeto.Application.ViewModels;
using Projeto.Domain.Clientes.DomainServices.Contarcts;
using Projeto.Domain.Clientes.Entities;

namespace Projeto.Application.ApplicationServices.Implementation
{
    public class ClienteAppAervice
        : IAppServiceCliente
    {
        private IClienteDomainService doamin; //atributo

        public ClienteAppAervice(IClienteDomainService doamin)
        {
            this.doamin = doamin;
        }

        public void Alterar(ClienteEdicaoViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ClienteCadastroViewModel model)
        {
            Cliente c = new Cliente();
            c.Endereco = new Endereco();

            c.Nome = model.Nome;
            c.Email = model.Email;
            c.DataNascimento = DateTime.Now;
            c.Endereco.Logradouro = model.Cidade;
            c.Endereco.Estado = model.Estado;
            c.Endereco.Cep = model.Cep;

            doamin.Cadastrar(c); //gravando..
        }

        public List<ClienteConsultaViewModel> Consultar()
        {
            throw new NotImplementedException();
        }

        public List<ClienteConsultaViewModel> ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
