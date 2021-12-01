using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solucja_Lab4.Models;

namespace Solucja_Lab4.Data
{
    public class Solucja_Lab4Context : DbContext
    {
        public Solucja_Lab4Context (DbContextOptions<Solucja_Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<Solucja_Lab4.Models.Books> Books { get; set; }
    }
}
