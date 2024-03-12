using LB.Application.Interfaces;
using LB.Domain;

namespace LB.Application;

public class Customer
{
    private IDbContext _dbContext;
    public Customer(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    /// <summary>
    /// Returns the Customer for specific TicketId
    /// </summary>
    /// <param name="ticketId">int</param>
    /// <returns>Customer</returns>
    public ICustomer GetCustomer(int ticketId)
    {
        var projectId = _dbContext.Tickets.Single(t => t.Id == ticketId).ProjectId;
        return _dbContext.Projects.Single(p => p.Id == projectId).Customer;
    }

    /// <summary>
    /// Returns the Customer for specific ProjectId
    /// </summary>
    /// <param name="projectId">string</param>
    /// <returns Customer>Customer</returns>
    public ICustomer GetCustomer(string projectId)
    {
        return _dbContext.Projects.Single(p => p.Id == projectId).Customer;
    }
}