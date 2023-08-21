using BussinesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents.Header
{
    public class Header:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
