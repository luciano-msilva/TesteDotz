using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    public class ClienteResgateMapping : IEntityTypeConfiguration<ClienteResgate>
    {
        public void Configure(EntityTypeBuilder<ClienteResgate> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.HasOne(x => x.Cliente).WithMany(x => x.ClienteResgate).HasForeignKey(x => x.CodigoCliente);
            builder.HasOne(x => x.Produto).WithMany(x => x.ClienteResgate).HasForeignKey(x => x.CodigoProduto);
            builder.HasOne(x => x.Parceiro).WithMany(x => x.ClienteResgate).HasForeignKey(x => x.CodigoParceiro);            
        }
    }
}
