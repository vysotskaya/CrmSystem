using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Bsuir.CrmSystem.DataServices.Interfacies;

namespace Bsuir.CrmSystem.MvcPL.Controllers
{
    public class ClientController : ApiController
    {
        private IClientService _clientService => (IClientService) DependencyResolver.Current.GetService(typeof (IClientService));

        [System.Web.Http.HttpGet]
        public IEnumerable<object> Get()
        {
            var clients = _clientService.GetAll()?.ToList();
            return clients;
        }
    }
}
