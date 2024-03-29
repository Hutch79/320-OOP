﻿using LB.Application.Interfaces;
using LB.Domain;

namespace LB.Application;

public class DataSeeder
{
    private IDbContext _dbContext;

    /// <param name="dbContext"></param>
    public DataSeeder(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Creates demo database data in the given dbContext
    /// </summary>
    public void Seed()
    {
        _dbContext.Customers = (new List<ICustomer>()
        {
            new Customer() { Name = "Gianluca" },
            new Customer() { Name = "Jendrik" },
            new Customer() {Name = "Raphael"},
        });

        _dbContext.Projects = (new List<IProject>()
        {
            new Project() {Id = "IT Stuff", Customer = _dbContext.Customers[0]}, // Gianluca
            new Project() {Id = "Cats", Customer = _dbContext.Customers[1]}, // Jendrik
            new Project() {Id = "Hunger", Customer = _dbContext.Customers[2]}, // Raphael
        });

        _dbContext.Tickets = (new List<ITicket>()
        {
            new Ticket() {Id = 1000, ProjectId = "IT Stuff", Title = "Proxmox Server Update"},
            new Ticket() {Id = 1001, ProjectId = "Cats", Title = "Neue Katzenklappe"},
            new Ticket() {Id = 1002, ProjectId = "Hunger", Title = "Pomchips"},
            new Ticket() {Id = 1003, ProjectId = "IT Stuff", Title = "GitLab Installation"},
        });
    }
}
