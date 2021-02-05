﻿// <auto-generated />
using System;
using Dotz.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dotz.Infra.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210204020642_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Dotz.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Documento")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefoneComercial")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefoneResidencial")
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.ClienteEndereco", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<int>("CodigoCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<bool>("EnderecoPrincipal")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoCliente");

                    b.ToTable("ClienteEndereco");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.ClienteMovimentacao", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodigoCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TipoMovimentacao")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoCliente");

                    b.ToTable("ClienteMovimentacao");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.ClienteResgate", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodigoCliente")
                        .HasColumnType("int");

                    b.Property<int>("CodigoParceiro")
                        .HasColumnType("int");

                    b.Property<int>("CodigoProduto")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("QtdePontosUtilizados")
                        .HasColumnType("int");

                    b.Property<int>("QtdeProduto")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoCliente");

                    b.HasIndex("CodigoParceiro");

                    b.HasIndex("CodigoProduto");

                    b.ToTable("ClienteResgate");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.Parceiro", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("longtext");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("Parceiro");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("ECategoriaProduto")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.ClienteEndereco", b =>
                {
                    b.HasOne("Dotz.Domain.Entities.Cliente", "Cliente")
                        .WithMany("ClienteEndereco")
                        .HasForeignKey("CodigoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.ClienteMovimentacao", b =>
                {
                    b.HasOne("Dotz.Domain.Entities.Cliente", "Cliente")
                        .WithMany("ClienteMovimentacao")
                        .HasForeignKey("CodigoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.ClienteResgate", b =>
                {
                    b.HasOne("Dotz.Domain.Entities.Cliente", "Cliente")
                        .WithMany("ClienteResgate")
                        .HasForeignKey("CodigoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dotz.Domain.Entities.Parceiro", "Parceiro")
                        .WithMany("ClienteResgate")
                        .HasForeignKey("CodigoParceiro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dotz.Domain.Entities.Produto", "Produto")
                        .WithMany("ClienteResgate")
                        .HasForeignKey("CodigoProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Parceiro");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("ClienteEndereco");

                    b.Navigation("ClienteMovimentacao");

                    b.Navigation("ClienteResgate");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.Parceiro", b =>
                {
                    b.Navigation("ClienteResgate");
                });

            modelBuilder.Entity("Dotz.Domain.Entities.Produto", b =>
                {
                    b.Navigation("ClienteResgate");
                });
#pragma warning restore 612, 618
        }
    }
}