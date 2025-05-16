using Ecommerce.Objects.Models;

namespace Ecommerce.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
        Task GerarPedido(T entity);
        Task Update(T entity);
        Task<bool> SaveChanges();
    }
}