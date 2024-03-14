using System.Data.Common;
using LB.Application;
using LB.Domain;

namespace LB;

public class Program
{
    static void Main(string[] args)
    {
        DbContext dbContext = new();
        DataSeeder dataSeeder = new(dbContext);
        dataSeeder.Seed();

        var customer = new CustomerActions(dbContext);
        var kunde = customer.GetCustomer(1001);
        Console.WriteLine($"Kunde: {kunde.Name}");

    }
}