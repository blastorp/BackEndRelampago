using Microsoft.AspNetCore.Mvc;

namespace RelampagoP.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
