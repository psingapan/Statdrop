using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Statdrop.Models;

namespace Statdrop.Data
{
    public class StatdropContext : DbContext
    {
        public StatdropContext (DbContextOptions<StatdropContext> options)
            : base(options)
        {
        }

        public DbSet<Statdrop.Models.Solutions> Solutions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statdrop.Models.Solutions>().HasData(

                new Statdrop.Models.Solutions
                {
                    Id = 1,
                    Title = "Scrims",
                    Team = "Unicorns n Rainbows",
                    Rival = "Ballers",
                    RivalScore = 23,
                    TeamScore = 30,
                    DatePlayed = DateTime.Now

                },
                 new Statdrop.Models.Solutions
                 {
                     Id = 2,
                     Title = "Scrims2",
                     Team = "GrayJoy",
                     Rival = "Peons",
                     RivalScore = 32,
                     TeamScore = 29,
                     DatePlayed = DateTime.Now

                 });
        }
    }
  
}
