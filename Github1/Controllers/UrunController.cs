using Microsoft.AspNetCore.Mvc;

namespace Github1.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
