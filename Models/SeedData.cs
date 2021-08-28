using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Statdrop.Data;


namespace Statdrop.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StatdropContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StatdropContext>>()))
            {
                // Look for any matches.
                if (context.Solutions.Any())
                {
                    return;   // DB has been seeded
                }

                context.Solutions.AddRange(
                    new Solutions
                    {
                        Id= 1,
                        Title = "Monday Scrims",
                        DatePlayed = DateTime.Now,
                        Team = "Rangers",
                        Rival = "Cloud 9",
                        TeamScore = 20,
                        RivalScore= 30
                    },

                    new Solutions
                    {
                        Id = 2,
                        Title = "Tuesday Scrims",
                        DatePlayed = DateTime.Now,
                        Team = "Rangers",
                        Rival = "Team Liquid",
                        TeamScore = 20,
                        RivalScore= 15
                    },

                    new Solutions
                    {
                        Id = 3,
                        Title = "Wed Scrims",
                        DatePlayed = DateTime.Now,
                        Team = "Rangers",
                        Rival = "Splyce",
                        TeamScore = 20,
                        RivalScore = 15
                    },

                    new Solutions
                    {
                        Id = 4,
                        Title = "Thursday Scrims",
                        DatePlayed = DateTime.Now,
                        Team = "Rangers",
                        Rival = "Riot10",
                        TeamScore = 20,
                        RivalScore = 15
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}
    

