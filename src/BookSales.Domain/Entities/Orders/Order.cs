using BookSales.Domain.Common;
using BookSales.Domain.Entities.Products;
using BookSales.Domain.Entities.Users;

namespace BookSales.Domain.Entities.Orders
{
    public class Order : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; } = null!;

        public long ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public long PaymentId { get; set; }
        public Payment Payment { get; set; } = null!;

        public decimal Amount { get; set; }

    }
}
