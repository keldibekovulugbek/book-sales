using BookSales.Domain.Common;
using BookSales.Domain.Enums;

namespace BookSales.Domain.Entities.Users;

public class User : Auditable
{

    public string FirstName { get; set; } = String.Empty;

    public string LastName { get; set; } = String.Empty;

    public string? ImagePath { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; } = false;

    public string PasswordHash { get; set; } = String.Empty;

    public string Salt { get; set; } = String.Empty;

    public UserRole Role { get; set; } = UserRole.User;

    public DateTime UpdatedAt { get; set; }
}
