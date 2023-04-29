using BookSales.Domain.Common;

namespace BookSales.Domain.Entities.Products;

public class NestedCategory : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public long CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
