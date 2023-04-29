using BookSales.Application.Utils;
using BookSales.DataAccess.Common;
using BookSales.Domain.Common;

namespace BookSales.DataAccess.Interfaces.Common;

public interface IGenericRepository<T> where T : BaseEntity
{
    public Task<T> CreateAsync(T entity);
    public Task<T> DeleteAsync(long id);
    public Task<T?> FindByIdAsync(long id);
    public Task<PagedList<T>> GetAllAsync(PaginationParams @params);
    public Task<T> UpdateAsync(long id, T entity);
}
