using LB.Application.Interfaces;

namespace LB.Domain;

/// <summary>
/// Contains all DB data
/// </summary>
public class DbContext : IDbContext
{
    public List<ICustomer> Customers { get; set; }
    public List<IProject> Projects { get; set; }
    public List<ITicket> Tickets { get; set; }
}
