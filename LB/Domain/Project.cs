using LB.Application.Interfaces;

namespace LB.Domain;

/// <summary>
/// Represents the Project DB Table
/// </summary>
public class Project : IProject
{
    public string Id { get; set; }
    public ICustomer Customer { get; set; }
}