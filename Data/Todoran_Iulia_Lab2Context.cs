using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todoran_Iulia_Lab2.Models;

namespace Todoran_Iulia_Lab2.Data
{
    public class Todoran_Iulia_Lab2Context : DbContext
    {
        public Todoran_Iulia_Lab2Context (DbContextOptions<Todoran_Iulia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Todoran_Iulia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Todoran_Iulia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
