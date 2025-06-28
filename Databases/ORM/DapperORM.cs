using System.Data.SqlClient;
using Dapper;
using Databases.Models;

namespace Databases.ORM;

public class DapperORM
{

    public static void GetPeople()
    {
        using var connection = new SqlConnection("YourConnectionString");
        var people = connection.Query<PersonModel>("SELECT Id, Name FROM People");
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Id}: {person.Name}");
        }
    }

}
