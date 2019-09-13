using Banco.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Id = 1000,
                    Apellido = "Perez",
                    Nombre = "Juan",
                    FechaNacimiento = new DateTime(1990, 1, 1),
                    FechaAlta = DateTime.Now
                },
                new Cliente()
                {
                    Id = 1001,
                    Apellido = "Castro",
                    Nombre = "Luis",
                    FechaNacimiento = new DateTime(1988, 10, 12),
                    FechaAlta = DateTime.Now
                }
            );

            builder.Entity<Cuenta>().HasData
            (
                new Cuenta()
                {
                    Id = 1,
                    Numero = new Random().Next(1000, 9999),
                    ClienteId = 1000
                },
                new Cuenta()
                {
                    Id = 2,
                    Numero = new Random().Next(1000, 9999),
                    ClienteId = 1001
                }
            );
        }
    }
}
