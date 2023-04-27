using BookSales.Domain.Common;

namespace BookSales.Domain.Entities.Products;

public class Category : Auditable
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

}
