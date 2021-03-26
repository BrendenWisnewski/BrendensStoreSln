using System.Linq;

namespace Products.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}