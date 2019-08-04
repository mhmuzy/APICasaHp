using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Repositories.Mappings
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");

            HasKey(e => e.IdEndereco);

            Property(e => e.IdEndereco)
                .HasColumnName("IdEndereco")
                .IsRequired();

            Property(e => e.Logradouro)
                .HasColumnName("Logradouro")
                .HasMaxLength(200)
                .IsRequired();

            Property(e => e.Cidade)
                .HasColumnName("Cidadae")
                .IsRequired();

            Property(e => e.Estado)
                .HasColumnName("Estado")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Cep)
                .HasColumnName("Cep")
                .HasMaxLength(10)
                .IsRequired();

            ///Relacionamento 1 para 1
            HasRequired(e => e.Cliente)
                ///Endereço TEM Cliente Obrigatoriamente
                .WithOptional(c => c.Endereco);
                ///Cliente TEM Endereco Opcionalmente
        }
    }
}
