using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App01.Models;

namespace App01.Data
{
    public class App01Context : DbContext
    {
        public App01Context (DbContextOptions<App01Context> options)
            : base(options)
        {
        }

        public DbSet<App01.Models.Movie> Movie { get; set; } = default!;
    }
}
