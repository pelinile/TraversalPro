using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using TraversalPro.Areas.Member.Models;

namespace TraversalPro.Areas.Member.Controllers
{
    [Area("Member")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated && !string.IsNullOrEmpty(User.Identity.Name))
            {
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                if (values != null)
                {
                    ViewBag.userName = values.Name + " " + values.Surname;
                    ViewBag.userImage = values.ImageUrl;
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return View();
            //public async Task<IActionResult> Index()
            //{
            //    var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //    ViewBag.userName = values.Name + " " + values.Surname;
            //    ViewBag.userImage = values.ImageUrl;
            //    return View();
            //}
            //public async Task<IActionResult> Index() //ben değiştirdim
            //{
            //    if (!string.IsNullOrEmpty(User.Identity.Name))
            //    {

            //        var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //        ViewBag.userName = values.Name + " " + values.Surname;
            //        ViewBag.userImage = values.ImageUrl;
            //        return View(values);

            //    }
            //    return View();
            //}

            //public async Task<IActionResult> Index()
            //{
            //    if (!string.IsNullOrEmpty(User.Identity.Name))
            //    {
            //        var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //        if (values != null)
            //        {
            //            ViewBag.userName = values.Name + " " + values.Surname;
            //            ViewBag.userImage = values.ImageUrl;
            //            return View();
            //        }
            //        else
            //        { return RedirectToAction("SignUp"); }

            //    }
            //    else
            //    {
            //        return RedirectToAction("Login");
            //    }
            //}
        }
        public async Task <IActionResult> MemberDashboard()
        {
            return View();

        }
    }
}