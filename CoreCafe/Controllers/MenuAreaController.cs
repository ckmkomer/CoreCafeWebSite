using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    public class MenuAreaController : Controller
    {
        SpecialMealOfferManager specialMealOfferManager= new SpecialMealOfferManager(new EfSpecialMealOfferRepository());
        public IActionResult Index()
        {
            var values = specialMealOfferManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddMenuArea()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMenuArea(SpecialMealOffer specialMeal)
        {
            specialMealOfferManager.TAdd(specialMeal);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMenuArea(int id)
        {
            var values = specialMealOfferManager.TGetByID(id);
            specialMealOfferManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditMenuArea(int id)
        {
            var values = specialMealOfferManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditMenuArea(SpecialMealOffer specialMeal)
        {
            specialMealOfferManager.TUpdate(specialMeal);
            return RedirectToAction("Index");
        }
    }
}
