using Dotz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Mapping
{
    public class ProdutoParceiroMapping : IEntityTypeConfiguration<ProdutoParceiro>
    {
        public void Configure(EntityTypeBuilder<ProdutoParceiro> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.HasOne(x => x.Parceiro).WithMany(x => x.ProdutoParceiro).HasForeignKey(x => x.CodigoParceiro);
            builder.HasOne(x => x.Produto).WithMany(x => x.ProdutoParceiro).HasForeignKey(x => x.CodigoProduto);
        }
    }
}
