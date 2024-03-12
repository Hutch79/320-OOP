using LB.Application.Interfaces;

namespace LB.Domain;

/// <summary>
/// Represents the Customer DB Table
/// </summary>
public class Customer : ICustomer
{
    public string Name { get; set; }
}