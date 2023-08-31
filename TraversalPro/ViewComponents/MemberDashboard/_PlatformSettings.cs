using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.ViewComponents.MemberDashboard
{
    public class _PlatformSettings:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
