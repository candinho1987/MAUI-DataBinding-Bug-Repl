using testbinding.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;



namespace testbinding//.Models.Context
{
    public class AppDbContext : DbContext
    {

        // tem que rodar update-database para atualizar o banco
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Medida> Medida { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Grade> Cores { get; set; }
        public DbSet<Grade> Tamanhos { get; set; }
        public DbSet<Serial> Serial { get; set; }
        public DbSet<Validade> Validade { get; set; }
        public DbSet<Uf> Uf { get; set; }
        public DbSet<Municipios> Municipios { get; set; }
        //public DbSet<Configuracao> Configuracoes { get; set; }


        protected override void ConfigureConventions(
    ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>()
                .HavePrecision(6, 2);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = "Server=localhost;user id=root;password=;Initial Catalog=EasyMaUi";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Clientes>()
            .Property(e => e.Id)
            .IsUnicode(false);
            
            modelBuilder.Entity<Usuarios>()
            .Property(e => e.Id)
            .IsUnicode(false);
            modelBuilder.Entity<Grupo>()
            .Property(e => e.Id)
            .IsUnicode(false);
            modelBuilder.Entity<Produtos>()
           .Property(e => e.Id)
           .IsUnicode(false);
           
            modelBuilder.Entity<Produtos>()
                  .Property(e => e.Preco)
                  .HasPrecision(6, 2);
            modelBuilder.Entity<Produtos>()
                  .Property(e => e.Custo)
                  .HasPrecision(6, 2);

            modelBuilder.Entity<Medida>()
           .Property(e => e.Id)
           .IsUnicode(false);
            modelBuilder.Entity<Estoque>()
            .Property(e => e.Id)
            .IsUnicode(false);
            modelBuilder.Entity<Estoque>()
                 .Property(e => e.Quantidade)
                 .HasPrecision(6, 2);

            modelBuilder.Entity<Grade>()
           .Property(e => e.Id)
           .IsUnicode(false);
            modelBuilder.Entity<Cores>()
           .Property(e => e.Id)
           .IsUnicode(false);
            modelBuilder.Entity<Tamanhos>()
           .Property(e => e.Id)
           .IsUnicode(false);

            modelBuilder.Entity<Serial>()
           .Property(e => e.Id)
           .IsUnicode(false);
            modelBuilder.Entity<Validade>()
           .Property(e => e.Id)
           .IsUnicode(false);
            modelBuilder.Entity<Municipios>()
           .Property(e => e.Id)
           .IsUnicode(false);
            modelBuilder.Entity<Uf>()
           .Property(e => e.Id)
           .IsUnicode(false);
            modelBuilder.Entity<Usuarios>()
               .HasData(new Usuarios {Id=1, Usuario = "Administrador", Senha = "123456" });
            modelBuilder.Entity<Clientes>().Property(p => p.Foto)
        .HasColumnType("MediumBlob");
        }



    }
}
