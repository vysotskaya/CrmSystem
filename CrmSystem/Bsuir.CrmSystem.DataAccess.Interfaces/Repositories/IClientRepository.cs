using Bsuir.CrmSystem.DataAccess.Entities;

namespace Bsuir.CrmSystem.DataAccess.Interfaces.Repositories
{
    public interface IClientRepository : IRepository<Client>
    {
        void Update(Client entity);
    }
}
