namespace LB.Application.Interfaces;

public interface IProject
{
    string Id { get; set; }
    ICustomer Customer { get; set; }
}