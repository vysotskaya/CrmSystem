using System.Collections.Generic;
using Bsuir.CrmSystem.DataAccess.Entities;
using Bsuir.CrmSystem.DataAccess.Interfaces.Repositories;
using Bsuir.CrmSystem.DataServices.Interfacies;

namespace Bsuir.CrmSystem.DataServices.Concrete
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }
    }
}
