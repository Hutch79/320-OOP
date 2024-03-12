namespace LB.Application.Interfaces;

public interface ITicket
{
    int Id { get; set; }
    string ProjectId { get; set; }
    string Title { get; set; }
}