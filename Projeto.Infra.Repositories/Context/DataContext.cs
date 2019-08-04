using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Entities;
using Projeto.Infra.Repositories.Mappings;
using System.Data.Entity;

namespace Projeto.Infra.Repositories.Context
{
    /// <summary>
    /// Regra 1) HERDAR DbContext..
    /// </summary>
    public class DataContext : DbContext
    {
        ///Regra 2) Construtor para enviar a connectionstring para a DbContext
        public DataContext()
            : base() ///TODO..
        {

        }

        ///Regra 3) Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
        }

        public DbSet<Cliente> Cliente
        {
            get;
            set;
        }

        public DbSet<Endereco> Endereco
        {
            get;
            set;
        }
    }
}
