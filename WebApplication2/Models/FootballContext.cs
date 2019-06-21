using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class FootballContext:DbContext
    {
        public FootballContext (DbContextOptions<FootballContext > options):base (options)
        {

        }

      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne<Address>(s => s.Address)
                .WithOne(ad => ad.Player)
                .HasForeignKey<Address>(ad => ad.PlayerId);
        }*/

        public DbSet<Player> players { get; set; }
        public DbSet <Team > teams { get; set; }
        public DbSet <Address > addresses { get; set; }
    }
}
