using Dotz.Domain.Entities;
using Dotz.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dotz.Infra.Data.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        DbSet<Cliente> Cliente { get; set; }
        DbSet<ClienteEndereco>ClienteEndereco{get;set;}
        DbSet<ClientePedido> ClientePedido { get; set; }
        DbSet<ClienteMovimentacao> clienteMovimentacao { get; set; }
        DbSet<ClienteResgate> ClienteResgate { get; set; }
        DbSet<Produto> Produto { get; set; }
        DbSet<Parceiro> Parceiro { get; set; }
        DbSet<ProdutoParceiro> ProdutoParceiro { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            base.OnConfiguring(optionsBuilder); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new ClienteEnderecoMapping());
            modelBuilder.ApplyConfiguration(new ClienteMovimentacaoMapping());
            modelBuilder.ApplyConfiguration(new ClienteResgateMapping());
            modelBuilder.ApplyConfiguration(new ParceiroMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new ClientePedidoMapping());
            modelBuilder.ApplyConfiguration(new ProdutoParceiroMapping());
            base.OnModelCreating(modelBuilder);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
