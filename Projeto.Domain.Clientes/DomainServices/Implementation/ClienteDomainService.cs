using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Entities;
using Projeto.Domain.Clientes.DomainServices.Contarcts;
using Projeto.Domain.Clientes.Infra.Repositories;
using Projeto.Domain.Clientes.Infra.Messages;

namespace Projeto.Domain.Clientes.DomainServices.Implementation
{
    public class ClienteDomainService : IClienteDomainService
    {
        /// <summary>
        /// atributos..
        /// </summary>
        /// <param name="c"></param>
        private IClienteRepository repository;
        private IEmailMessages message;

        public ClienteDomainService(IClienteRepository repository, 
                                    IEmailMessages message)
        {
            this.repository = repository;
            this.message = message;
        }

        public void Atualizar(Cliente c)
        {
            repository.Update(c);
        }

        public void Cadastrar(Cliente c)
        {
            ///Verificar se o email não esta cadastrado..
            if ( ! repository.HasEmail(c.Email))
            {
                repository.Insert(c); ///gravando..
                message.EnviarConfirmacaoDeCadastro(c); ///enviando o email..
            }
            else
            {
                throw new Exception("Email já cadastrado. Tente outro.");         
            }
        }

        public Cliente ConsultarPorId(int idCliente)
        {
            return repository.FindById(idCliente);
        }

        public List<Cliente> ConsultarTodos(Cliente c)
        {
            return repository.FindAll();
        }

        public void Exluir(Cliente c)
        {
            repository.Delete(c);
        }
    }
}
