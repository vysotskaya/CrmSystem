using System.Collections.Generic;
using Bsuir.CrmSystem.DataAccess.Entities;

namespace Bsuir.CrmSystem.DataServices.Interfacies
{
    public interface IClientService
    {
        IEnumerable<Client> GetAll();
    }
}
