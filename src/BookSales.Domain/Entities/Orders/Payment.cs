using BookSales.Domain.Common;
using BookSales.Domain.Enums;

namespace BookSales.Domain.Entities.Orders;

public class Payment : Auditable 
{
    public decimal Amount { get; set; }

    public long SessionId { get; set; }
    public Session Session { get; set; } = null!;

    public PaymentStatus Status { get; set; } = PaymentStatus.Unapproved;
}
