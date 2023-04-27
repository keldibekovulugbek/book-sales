using BookSales.Domain.Common;
using BookSales.Domain.Enums;

namespace BookSales.Domain.Entities.Products;

public class Product : Auditable
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    
    public decimal Price { get; set; }
    
    public float Score { get; set; } = 5f;

    public long AuthorId { get; set; }
    public Author Author { get; set; } = null!;
    
    public string ImagePath { get; set; } = string.Empty;
    
    public string ISBN { get; set; } = string.Empty;
    
    public short Year { get; set; }
    
    public int CountOfPages { get; set; }
    
    public string Publisher { get; set; } = string.Empty;
    
    public CoverType CoverType { get; set; }
    
    public string? Tarjimon { get; set; } = string.Empty;
    
    public string Language { get; set; } = string.Empty;
}
