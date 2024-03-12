using System.Data.Common;
using LB.Application;
using LB.Domain;
using Customer = LB.Application.Customer;

namespace LB;

public class Program
{
    static void Main(string[] args)
    {
        DbContext dbContext = new();
        DataSeeder dataSeeder = new(dbContext);
        dataSeeder.Seed();
        Console.Write("hui");

        var customer = new Customer(dbContext);
        customer.GetCustomer(1);

    }
}