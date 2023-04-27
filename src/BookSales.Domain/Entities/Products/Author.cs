using BookSales.Domain.Common;

namespace BookSales.Domain.Entities.Products;

public class Author : Auditable
{
    public string FirstName { get; set; } = String.Empty;

    public string LastName { get; set; } = String.Empty;

    public string? ImagePath { get; set; }

    public string? Description { get; set; }
}
