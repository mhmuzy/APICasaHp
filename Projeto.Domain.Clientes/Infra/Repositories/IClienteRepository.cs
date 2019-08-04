using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Entities;

namespace Projeto.Domain.Clientes.Infra.Repositories
{
    public interface IClienteRepository
        : IBaseRepository<Cliente>
    {
        bool HasEmail(string email);
    }
}
