using Bsuir.CrmSystem.DataAccess.Entities;

namespace Bsuir.CrmSystem.DataAccess.Interfaces.Repositories
{
    public interface ISupplierOrderRepository : IRepository<SupplierOrder>
    {
        int Create(SupplierOrder entity);
        void Update(SupplierOrder entity);
        void Delete(SupplierOrder entity);
    }
}
