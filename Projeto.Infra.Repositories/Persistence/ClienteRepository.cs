using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Entities;
using Projeto.Domain.Clientes.Infra.Repositories;
using Projeto.Infra.Repositories.Context;

namespace Projeto.Infra.Repositories.Persistence
{
    public class ClienteRepository
        : BaseRepository<Cliente>, IClienteRepository
    {
        public bool HasEmail(string email)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Cliente.Count(c => c.Equals(email)) > 0;
            }
        }
    }
}
