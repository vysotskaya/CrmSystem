using System.Web.Mvc;

namespace Bsuir.CrmSystem.MvcPL.Controllers
{
    public class PartialsController : Controller
    {
        public ActionResult Main()
        {
            return PartialView("_Main");
        }

        public ActionResult Planning()
        {
            return PartialView("_Planning");
        }

        public ActionResult Clients()
        {
            return PartialView("_Clients");
        }

        public ActionResult Suppliers()
        {
            return PartialView("_Suppliers");
        }

        public ActionResult Archive()
        {
            return PartialView("_Archive");
        }

        public ActionResult Products()
        {
            return PartialView("_Products");
        }
    }
}