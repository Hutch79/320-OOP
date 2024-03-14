using LB.Application.Interfaces;

namespace _4218_Test;

public class TestDB : IDbContext
{
    public List<ICustomer> Customers { get; set; }
    public List<IProject> Projects { get; set; }
    public List<ITicket> Tickets { get; set; }
}