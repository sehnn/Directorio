using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directorio.Data
{
    public class SeedDb
    {

        private readonly DataContext _context;


        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckAgendassAsync();
        }

        private async Task CheckAgendassAsync()
        {
            if (!_context.Agendas.Any())
            {
                _context.Agendas.Add(new Entities.Agenda { Nombre = "Raul" });
                _context.Agendas.Add(new Entities.Agenda { Nombre = "Saul" });
                _context.Agendas.Add(new Entities.Agenda { Nombre = "Dan" });

                await _context.SaveChangesAsync();
            }
        }
    }
}
