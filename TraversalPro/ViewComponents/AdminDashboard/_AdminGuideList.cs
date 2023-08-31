using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.ViewComponents.AdminDashboard
{
    public class _AdminGuideList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
