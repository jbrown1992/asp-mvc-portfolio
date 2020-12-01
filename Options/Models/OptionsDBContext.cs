using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Options.Models;

namespace Options.Models
{
    public class OptionsDBContext : DbContext
    {
        public OptionsDBContext(DbContextOptions<OptionsDBContext> options):base(options)
        {

        }

        public DbSet<Option> Options { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<Options.Models.SharePrice> SharePrice { get; set; }



    }
}
