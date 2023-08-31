using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.ViewComponents.AdminDashboard
{
    public class _TotalRevenue: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
