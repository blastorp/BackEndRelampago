using Microsoft.AspNetCore.Mvc;

namespace RelampagoP.Controllers
{
    public class EjeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
