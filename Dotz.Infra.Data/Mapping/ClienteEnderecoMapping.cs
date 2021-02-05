using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    public class ClienteEnderecoMapping : IEntityTypeConfiguration<ClienteEndereco>
    {
        public void Configure(EntityTypeBuilder<ClienteEndereco> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.HasOne(x => x.Cliente).WithMany(x => x.ClienteEndereco).HasForeignKey(x => x.CodigoCliente);
        }
    }
}
