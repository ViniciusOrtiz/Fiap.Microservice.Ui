﻿// <auto-generated />
using Fiap.Microservices.Ui.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Microservices.Ui.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Fiap.Microservices.Ui.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });
#pragma warning restore 612, 618
        }
    }
}