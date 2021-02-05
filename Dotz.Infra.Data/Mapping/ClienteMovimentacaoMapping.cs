using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.Infra.Data.Mapping
{
    class ClienteMovimentacaoMapping : IEntityTypeConfiguration<ClienteMovimentacao>
    {
        public void Configure(EntityTypeBuilder<ClienteMovimentacao> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.HasOne(x => x.Cliente).WithMany(x => x.ClienteMovimentacao).HasForeignKey(x => x.CodigoCliente);
        }
    }
}
