using BookSales.Domain.Common;
using BookSales.Domain.Entities.Users;

namespace BookSales.Domain.Entities.Products
{
    public class Feedback : Auditable
    {
        public short Score { get; set; }
        
        public long UserId { get; set; }
        public User User { get; set; } = null!;

        public long ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public string Comment { get; set; } = string.Empty;
    }
}
