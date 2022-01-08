using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bosca_Dana_Lab8.Models;

namespace Bosca_Dana_Lab8.Data
{
    public class Bosca_Dana_Lab8Context : DbContext
    {
        public Bosca_Dana_Lab8Context (DbContextOptions<Bosca_Dana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bosca_Dana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bosca_Dana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Bosca_Dana_Lab8.Models.Category> Category { get; set; }
    }
}
