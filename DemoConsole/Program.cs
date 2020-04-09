using DemoConsole.Entities;
using Microsoft.EntityFrameworkCore;
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
            using (var context = new ActorDbContext())
            {
                context.Database.Migrate();

                foreach (var Actor in context.Actors.Include("Awards"))
                {
                    Console.WriteLine($"Name: {Actor.Name},\t\t" +
                                        $"Age: {Actor.Age},\t\t" +
                                        $"AcademyWinner: {Actor.AcademyWinner}");
                }
            }
        }
    }
}
