using Microsoft.AspNetCore.Mvc;

namespace TraversalPro.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
