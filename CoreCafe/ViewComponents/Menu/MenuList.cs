using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents.Menu
{
    public class MenuList:ViewComponent
    {
        MenuItemManager menuItemManager = new MenuItemManager(new EfMenuItemRepository());
        public IViewComponentResult Invoke()
        {
            var values = menuItemManager.TGetList();
            return View(values);
        }
    }
}
