using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
