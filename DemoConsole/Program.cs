using DemoConsole.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ActorDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.Migrate();


                var movie = context.Movies.FirstOrDefault(m => m.Title.Contains("Fiction"));
                movie.Title = "Criminalnoe Chtivo";

                var newAwardList = new Award[]
                {
                    new Award {
                        Title = AwardType.Oscar,
                        DeliveryYear = 2017
                    },
                    new Award {
                        Title = AwardType.Oscar,
                        DeliveryYear = 2016
                    }
                };

                var newActor = new Actor
                {
                    Name = "Tom Cruz",
                    Age = 44,
                    Awards = newAwardList
                };


                newActor.ActorMovies = new List<ActorMovie>
                {
                    new ActorMovie {
                        Actor = newActor,
                        Movie = movie
                    }
                };

                context.Actors.Add(newActor);

                context.SaveChanges();


                context.Actors.Remove(context.Actors.FirstOrDefault(a => a.Name == "Tom Cruz"));

                context.SaveChanges();
            }
        }
    }
}
