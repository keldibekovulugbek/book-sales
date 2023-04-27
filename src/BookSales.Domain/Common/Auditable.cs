namespace BookSales.Domain.Common;

public class Auditable : BaseEntity
{
    public DateTime CreatedAt { get; set; }
}
