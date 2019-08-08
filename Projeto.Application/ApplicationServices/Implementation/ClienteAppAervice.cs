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
            Cliente c = new Cliente();
            c.Endereco = new Endereco();

            c.IdCliente = model.IdCliente;
            c.Nome = model.Nome;
            c.Email = model.Email;
            c.DataNascimento = DateTime.Now;
            c.Endereco.Logradouro = model.Cidade;
            c.Endereco.Estado = model.Estado;
            c.Endereco.Cep = model.Cep;

            doamin.Atualizar(c);
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

        public List<Cliente> Consultar()
        {
            List<Cliente> model = doamin.ConsultarTodos();

            
            return model;
        }

        public Cliente ConsultarPorId(int id)
        {
            Cliente model = doamin.ConsultarPorId(id);

            return model;
        }

        List<ClienteConsultaViewModel> IAppServiceCliente.Consultar()
        {
            throw new NotImplementedException();
        }

        List<ClienteConsultaViewModel> IAppServiceCliente.ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
