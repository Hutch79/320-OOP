using LB.Domain;

namespace LB.Application.Interfaces;

public interface IDbContext
{
    List<ICustomer> Customers { get; set; }
    List<IProject> Projects { get; set; }
    List<ITicket> Tickets { get; set; }
}