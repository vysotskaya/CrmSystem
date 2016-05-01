using Bsuir.CrmSystem.DataAccess.Entities;

namespace Bsuir.CrmSystem.DataAccess.Interfaces.Repositories
{
    public interface IOrderArchiveRepository : IRepository<OrderArchive>
    {
        int Create(OrderArchive entity);
        void Update(OrderArchive entity);
        void Delete(OrderArchive entity);
    }
}
