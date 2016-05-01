using Bsuir.CrmSystem.DataAccess.Entities;

namespace Bsuir.CrmSystem.DataAccess.Interfaces.Repositories
{
    public interface IClientOrderRepository : IRepository<ClientOrder>
    {
        int Create(ClientOrder entity);
        void Update(ClientOrder entity);
        void Delete(ClientOrder entity);
    }
}
