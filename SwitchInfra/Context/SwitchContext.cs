using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SwitchDomain.Entities;
using SwitchInfra.Config;

namespace SwitchInfra.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SwitchContext>
    {
        private readonly IConfiguration _configuration;
        
        public SwitchContext CreateDbContext(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SwitchApi"))
                .AddJsonFile("config.json")
                .Build();

            var connectionString = config.GetConnectionString("SwitchDB");
            var builder = new DbContextOptionsBuilder<SwitchContext>();
            builder.UseMySql(connectionString );
            return new SwitchContext(builder.Options);
        }
    }
    
    public class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; } 

        public SwitchContext(DbContextOptions options) : base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}