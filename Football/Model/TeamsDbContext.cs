using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Football.Model
{
    public class TeamsDbContext : DbContext
    {
        public virtual DbSet<Teams> Teams { get; set; }

        public TeamsDbContext(DbContextOptions<TeamsDbContext> options) : base(options)
        {

        }

    }
}
