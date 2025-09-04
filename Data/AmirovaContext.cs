using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Amirova.Models;

namespace Amirova.Data
{
    public class AmirovaContext : DbContext
    {
        public AmirovaContext (DbContextOptions<AmirovaContext> options)
            : base(options)
        {
        }

        public DbSet<Amirova.Models.Movie> Movie { get; set; } = default!;
    }
}
