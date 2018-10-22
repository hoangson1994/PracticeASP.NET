using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeASP.Models;

namespace PracticeASP.Models
{
    public class PracticeASPContext : DbContext
    {
        public PracticeASPContext (DbContextOptions<PracticeASPContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeASP.Models.Product> Product { get; set; }

        public DbSet<PracticeASP.Models.Category> Category { get; set; }
    }
}
