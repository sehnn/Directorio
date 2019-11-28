using Directorio.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directorio.Data
{
    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }


        public DbSet<Agenda> Agendas { get; set; } 


    }
}
