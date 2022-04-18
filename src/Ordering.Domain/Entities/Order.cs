using Ordering.Domain.Common;

namespace Ordering.Domain.Entities;

public class Order : EntityBase
{
    public Order(string? userName, decimal totalPrice)
    {
        UserName = userName;
        TotalPrice = totalPrice;
    }

    public string? UserName { get; set; }
    public decimal TotalPrice { get; set; }
}
