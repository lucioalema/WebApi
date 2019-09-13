using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banco.WebApi.Data;
using Banco.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Banco.WebApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ApplicationDbContext _context;

        public ClienteService(ApplicationDbContext context)
        {
            _context = context;

            if (!_context.Clientes.Any())
            {
                _context.Clientes.AddRange(
                    new Cliente()
                    {
                        Apellido = "Perez",
                        Nombre = "Juan",
                        FechaNacimiento = DateTime.Now,
                        FechaAlta = DateTime.Now
                    },
                    new Cliente()
                    {
                        Apellido = "Castro",
                        Nombre = "Luis",
                        FechaNacimiento = DateTime.Now.AddYears(1),
                        FechaAlta = DateTime.Now
                    }
                );
                _context.SaveChanges();
            }
        }
        public async Task AddAsync(Cliente cliente)
        {
            cliente.FechaAlta = DateTime.Now;
            _context.Clientes.Add(cliente);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(x => x.Id == Id);
            _context.Clientes.Remove(cliente);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cliente>> GetAsync()
        {
            return await _context.Clientes
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Cliente> GetAsync(int Id)
        {
            return await _context.Clientes
                .FindAsync(Id);
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
