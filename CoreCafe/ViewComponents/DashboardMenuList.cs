using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents
{
    public class DashboardMenuList:ViewComponent
    {
        MenuItemManager _menuıtemManager = new MenuItemManager(new EfMenuItemRepository());



        public IViewComponentResult Invoke()
        {
            var values = _menuıtemManager.TGetList();
            return View(values);
        }
    }
}
