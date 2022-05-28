using Microsoft.AspNetCore.Mvc;

namespace CakesOrder.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
