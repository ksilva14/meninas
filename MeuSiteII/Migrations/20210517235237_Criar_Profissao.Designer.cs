// <auto-generated />
using System;
using MeuSiteII.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeuSiteII.Migrations
{
    [DbContext(typeof(MeuSiteContext))]
    [Migration("20210517235237_Criar_Profissao")]
    partial class Criar_Profissao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("MeuSiteII.Models.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cpf")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sexo")
                        .HasColumnType("INTEGER");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("MeuSiteII.Models.Profissao", b =>
                {
                    b.Property<int>("ProfissaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("ProfissaoId");

                    b.ToTable("Profissao");
                });
#pragma warning restore 612, 618
        }
    }
}
