using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents.Chef
{
    public class ChefList:ViewComponent
    {
        ChefManager chefManager = new ChefManager(new EfChefRepository());
        public IViewComponentResult Invoke()
        {
            var values = chefManager.TGetList();
            return View(values);
        }
    }
}
