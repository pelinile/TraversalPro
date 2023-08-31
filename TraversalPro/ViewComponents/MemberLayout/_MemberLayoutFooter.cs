using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.ViewComponents.MemberLayout
{
    public class _MemberLayoutFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
