using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VrumVrumCar.Models;

namespace VrumVrumCar.Data
{
    public class VrumVrumCarContext : DbContext
    {
        public VrumVrumCarContext(DbContextOptions<VrumVrumCarContext> options)
            : base(options)
        {
        }

        public DbSet<VrumVrumCar.Models.Carro> Carro { get; set; } = default!;
        public DbSet<VrumVrumCar.Models.Cliente>? Cliente { get; set; }
        public DbSet<VrumVrumCar.Models.Vendedor>? Vendedor { get; set; }
        public DbSet<VrumVrumCar.Models.Nota>? Nota { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurando decimal com precisão de 18 dígitos e 2 casas decimais
            modelBuilder.Entity<Carro>()
                .Property(c => c.Preco)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Nota>()
                .Property(n => n.ValorVenda)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Vendedor>()
                .Property(v => v.Salario)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
