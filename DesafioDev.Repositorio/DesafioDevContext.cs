using DesafioDev.Repositorio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Reflection;

namespace DesafioDev.Repositorio
{
    public class DesafioDevContext : DbContext
    {
        public DesafioDevContext(DbContextOptions<DesafioDevContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Cidade> Cidade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(entidade =>
            {
                entidade.HasKey(e => e.id).HasName("pk_pessoa");

                entidade.Property(e => e.nome).HasMaxLength(70);

                entidade.Property(e => e.tipo_pessoa).HasMaxLength(2);

                entidade.Property(e => e.cpf_cnpj).HasMaxLength(14);

                entidade.Property(e => e.cep).HasMaxLength(8);

                entidade.Property(e => e.endereco).HasMaxLength(100);

                entidade.Property(e => e.numero);

                entidade.Property(e => e.complemento).HasMaxLength(20);

                entidade.Property(e => e.bairro).HasMaxLength(50);

                entidade.Property(e => e.data_nascimento_fundacao);

                entidade.Property(e => e.data_cadastro);

                entidade.Property(e => e.email).HasMaxLength(50);

                entidade.Property(e => e.celular).HasMaxLength(20);

                entidade.Property(e => e.sit_cadastral).HasMaxLength(2);

                entidade.Property(e => e.cidade_id);
            });

            modelBuilder.Entity<Cidade>(entidade =>
            {
                entidade.HasKey(e => e.id).HasName("pk_cidade");

                entidade.Property(e => e.nome).HasMaxLength(25);

                entidade.Property(e => e.estado).HasMaxLength(2);
            });
        }
    }

    public class DesafioDevContextFactory : IDesignTimeDbContextFactory<DesafioDevContext>
    {
        public DesafioDevContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DesafioDevContext>();
            builder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=DesafioDevBanco;Integrated Security=True",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(DesafioDevContext).GetTypeInfo().Assembly.GetName().Name));

          
            return new DesafioDevContext(builder.Options);
        }
    }
}
