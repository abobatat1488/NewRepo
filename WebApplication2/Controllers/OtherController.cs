using Microsoft.AspNetCore.Mvc;

namespace MobileStore.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
