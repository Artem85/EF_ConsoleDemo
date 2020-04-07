using DemoConsole.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ActorDbContext())
            {
                db.Actors.AddRange(
                    new Actor
                    {
                        Name = "Bruce Lee",
                        Age = 75,
                        AcademyWinner = false
                    },
                    new Actor
                    {
                        Name = "Madonna",
                        Age = 65,
                        AcademyWinner = true
                    });

                var count = db.SaveChanges();

                Console.WriteLine($"{count} records added");

                foreach (var Actor in db.Actors)
                {
                    Console.WriteLine($"Name: {Actor.Name},\t\t" +
                                        $"Age: {Actor.Age},\t\t" +
                                        $"AcademyWinner: {Actor.AcademyWinner}");
                }
            }
        }
    }
}
