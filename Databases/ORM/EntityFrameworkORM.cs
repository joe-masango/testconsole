using Databases.Models;
using Microsoft.EntityFrameworkCore;

namespace Databases.ORM;

public class EntityFrameworkORM
{

    public static void GetPeople()
    {
        using var context = new AppDbContext();
        var people = context.People.ToList();
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Id}: {person.Name}");
        }
    }

}


public class AppDbContext : DbContext
{
    public DbSet<PersonModel> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer("YourConnectionString");
}

