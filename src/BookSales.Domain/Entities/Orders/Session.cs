using BookSales.Domain.Common;
using BookSales.Domain.Entities.Users;
using BookSales.Domain.Enums;

namespace BookSales.Domain.Entities.Orders
{
    public class Session : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; } = null!;

        public decimal TotalPrice { get; set; }

        public SessionStatus status { get; set; } = SessionStatus.Active;
    }
}
