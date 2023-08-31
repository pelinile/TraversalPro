using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.Areas.Member.Controllers
{
    public class CommentController : Controller
    {
        [Area("Member")]
        [AllowAnonymous] //beni bütün kurallardan muaf tut
        public IActionResult Index()
        {
            return View();
        }
    }
}
