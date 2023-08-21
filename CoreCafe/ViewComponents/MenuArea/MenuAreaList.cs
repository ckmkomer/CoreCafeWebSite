using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents.MenuArea
{
    public class MenuAreaList : ViewComponent
    {
        SpecialMealOfferManager specialMealOfferManager = new
            SpecialMealOfferManager(new EfSpecialMealOfferRepository());
        public IViewComponentResult Invoke()
        {
            var values = specialMealOfferManager.TGetList();
            return View(values);
        }
    }
}
