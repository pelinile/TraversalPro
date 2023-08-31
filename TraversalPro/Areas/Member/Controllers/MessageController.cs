using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
