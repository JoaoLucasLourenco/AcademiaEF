﻿// <auto-generated />
using System;
using Academia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Academia.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Academia.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoId"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoId");

                    b.HasIndex("PersonalId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Academia.Models.Exercicio", b =>
                {
                    b.Property<int>("ExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExercicioId"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TreinoId")
                        .HasColumnType("int");

                    b.HasKey("ExercicioId");

                    b.HasIndex("TreinoId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("Academia.Models.Personal", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalId"));

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalId");

                    b.ToTable("Personais");
                });

            modelBuilder.Entity("Academia.Models.Treino", b =>
                {
                    b.Property<int>("TreinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TreinoId"));

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.HasKey("TreinoId");

                    b.HasIndex("AlunoId");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("Academia.Models.Aluno", b =>
                {
                    b.HasOne("Academia.Models.Personal", "Personal")
                        .WithMany("Alunos")
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Academia.Models.Exercicio", b =>
                {
                    b.HasOne("Academia.Models.Treino", null)
                        .WithMany("Exercicios")
                        .HasForeignKey("TreinoId");
                });

            modelBuilder.Entity("Academia.Models.Treino", b =>
                {
                    b.HasOne("Academia.Models.Aluno", "Aluno")
                        .WithMany("Treinos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("Academia.Models.Aluno", b =>
                {
                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("Academia.Models.Personal", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("Academia.Models.Treino", b =>
                {
                    b.Navigation("Exercicios");
                });
#pragma warning restore 612, 618
        }
    }
}
