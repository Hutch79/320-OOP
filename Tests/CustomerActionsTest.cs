using JetBrains.Annotations;
using LB.Application;
using LB.Domain;
using CustomerActions = LB.Application.CustomerActions;

namespace _4218_Test;

[TestSubject(typeof(CustomerActions))]
public class CustomerActionsTest
{

    [Fact]
    public void CustomerActionsTicketNr()
    {
        // Arrange
        TestDB dbContext = new();
        var DBPreparation = new LbDatabasePreparation(dbContext);
        DBPreparation.Seed();

        var customer = new CustomerActions(dbContext);

        // Act
        var customer1 = customer.GetCustomer(dbContext.Tickets[1].Id).Name;

        // Assert
        Assert.Equal(dbContext.Customers[1].Name, customer1);
    }

    [Fact]
    public void CustomerActionsProjectId()
    {
        // Arrange
        TestDB dbContext = new();
        var DBPreparation = new LbDatabasePreparation(dbContext);
        DBPreparation.Seed();

        var customer = new CustomerActions(dbContext);

        // Act
        var customer2 = customer.GetCustomer(dbContext.Projects[2].Id).Name;

        // Assert
        Assert.Equal(dbContext.Customers[2].Name, customer2);
    }
}