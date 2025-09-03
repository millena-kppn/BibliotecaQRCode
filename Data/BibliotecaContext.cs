using BibliotecaQRCode.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace BibliotecaQRCode.Data
{
    //criar o contexto da base de dados
    public class BibliotecaContext : DbContext
    {
        public DbSet<Aluno> Alunos => Set<Aluno>();
        public DbSet<Livro> Livros => Set<Livro>();
        public DbSet<Emprestimo> Emprestimos => Set<Emprestimo>();
        //public DbSet<Admin> Admins { get; set; }ALTERAR
        public DbSet<Admin> Admins => Set<Admin>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // salvar o .db na pasta do usuário (recomendado)
            var dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "biblioteca.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            // salvar na pasta da aplicação (útil para testes locais)
            // var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "biblioteca.db");
            // optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emprestimo>()
                .HasOne(e => e.Aluno)
                .WithMany(a => a.Emprestimos)
                .HasForeignKey(e => e.AlunoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Emprestimo>()
                .HasOne(e => e.Livro)
                .WithMany(l => l.Emprestimos)
                .HasForeignKey(e => e.LivroId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Aluno>()
                .HasIndex(a => a.Matricula)
                .IsUnique();

            modelBuilder.Entity<Livro>()
                .HasIndex(l => l.CodigoQR)
                .IsUnique();
        }
    }
    //TESTE LOCAL (para verificar se o banco de dados está funcionando corretamente)
    //public class BibliotecaContext : DbContext
    //{
    //    public DbSet<Livro> Livros { get; set; }
    //    public DbSet<Aluno> Alunos { get; set; }
    //    public DbSet<Emprestimo> Emprestimos { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        var caminhoBanco = @"C:\Users\Pichau\AppData\Local\biblioteca.db";
    //        optionsBuilder.UseSqlite($"Data Source={caminhoBanco}");
    //    }
    //}
}
