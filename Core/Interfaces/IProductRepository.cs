using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductBuyIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}