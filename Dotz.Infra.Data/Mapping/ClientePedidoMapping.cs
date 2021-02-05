using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    public class ClientePedidoMapping : IEntityTypeConfiguration<ClientePedido>
    {
        public void Configure(EntityTypeBuilder<ClientePedido> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.HasOne(x => x.Cliente).WithMany(x => x.ClientePedido).HasForeignKey(x => x.CodigoCliente);
            builder.HasOne(x => x.ClienteEndereco).WithMany(x => x.ClientePedido).HasForeignKey(x => x.CodigoClienteEndereco);
            builder.HasOne(x => x.ClienteResgate).WithMany(x => x.ClientePedido).HasForeignKey(x => x.CodigoClienteResgate);
        }
    }
}
