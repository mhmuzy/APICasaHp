using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Entities;

namespace Projeto.Domain.Clientes.DomainServices.Contarcts
{
    public interface IClienteDomainService
    {
        void Cadastrar(Cliente c);

        void Atualizar(Cliente c);

        void Exluir(Cliente c);

        List<Cliente> ConsultarTodos(Cliente c);

        Cliente ConsultarPorId(int idCliente);

    }
}
