using System.Web.Mvc;
using Bsuir.CrmSystem.DataServices.Interfacies;

namespace Bsuir.CrmSystem.MvcPL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientService _clientService;

        public HomeController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}