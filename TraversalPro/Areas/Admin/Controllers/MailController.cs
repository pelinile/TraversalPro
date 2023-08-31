using Microsoft.AspNetCore.Mvc;
using TraversalPro.Models;

namespace TraversalPro.Areas.Admin.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            return View();
        }
    }
}
