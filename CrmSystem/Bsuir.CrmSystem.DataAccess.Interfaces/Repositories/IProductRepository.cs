using Bsuir.CrmSystem.DataAccess.Entities;

namespace Bsuir.CrmSystem.DataAccess.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        int Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
