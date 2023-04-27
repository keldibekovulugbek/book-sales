using BookSales.Domain.Common;
using BookSales.Domain.Entities.Products;
using BookSales.Domain.Entities.Users;

namespace BookSales.Domain.Entities.Orders
{
    public class CartItem : Auditable
    {
        public long SessionId { get; set; }
        public Session Session { get; set; } = null!;

        public long ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
