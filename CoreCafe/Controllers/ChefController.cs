using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CafeWebSite.Controllers
{
    public class ChefController : Controller
    {
        ChefManager chefManager = new ChefManager(new EfChefRepository());
        public IActionResult Index()
        {
            var values = chefManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddChef()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddChef(Chef chef)
        {
            ChefValidation validationRules = new ChefValidation();
            ValidationResult result = validationRules.Validate(chef);
            if (result.IsValid)
            {
                chefManager.TAdd(chef);
                TempData["Status"] = "Veri başarılı bir şekilde eklendi.";
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(chef);
        }
        public IActionResult DeleteChef(int id)
        {
            var values = chefManager.TGetByID(id);
            chefManager.TDelete(values);
            TempData["Status"] = "Veri başarılı bir şekilde silindi.";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditChef(int id)
        {
            var values = chefManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditChef(Chef chef)
        {
            chefManager.TUpdate(chef);
            TempData["Status"] = "Veri başarılı bir şekilde güncellendi.";
            return RedirectToAction("Index");
        }
    }
}
