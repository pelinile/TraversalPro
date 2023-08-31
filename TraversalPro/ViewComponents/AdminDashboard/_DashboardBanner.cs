using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.ViewComponents.AdminDashboard
{
    public class _DashboardBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
