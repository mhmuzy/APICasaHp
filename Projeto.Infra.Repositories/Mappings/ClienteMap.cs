﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Repositories.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(c => c.IdCliente);

            Property(c => c.IdCliente)
                .HasColumnName("IdCliente")
                .IsRequired();

            Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnName("Email")
                .HasMaxLength(300)
                .IsRequired()
                .HasColumnAnnotation("IX_Email", new IndexAnnotation(
                    new IndexAttribute() { IsUnique = true }));

            Property(c => c.DataNascimento)
                .HasColumnName("DataNascimento")
                .IsRequired();
        }
    }
}
