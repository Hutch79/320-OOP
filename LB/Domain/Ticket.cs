using LB.Application.Interfaces;

namespace LB.Domain;

/// <summary>
/// Represents the Ticket DB Table
/// </summary>
public class Ticket : ITicket
{
    public int Id { get; set; }
    public string ProjectId { get; set; }
    public string Title { get; set; }
}