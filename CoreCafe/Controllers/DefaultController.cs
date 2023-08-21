using AutoMapper;
using BussinesLayer.Concrete;
using CafeWebSite.Models;

using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    
	public class DefaultController : Controller
	{
       
       

        

        public IActionResult Index()
		{
			return View();
		}


        [HttpGet]
        public IActionResult Resarvation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Resarvation(Reservation reservation )
        {
            ReservationManager _reservationManager = new ReservationManager(new EfReservationRepository());
            try
            {
                
                _reservationManager.TAdd(reservation);


                TempData["result"] = "Rezarvasyon başarılı bir şekilde oluşmuştur.";

                return RedirectToAction("Default", "Index");
            }
            catch (Exception )
            {
                TempData["result"] = "Rezarvasyonunuz oluşmamıştır lütfen daha sonra tekrar deneyiniz.";

                return RedirectToAction("Default,Index");
            }

            
        }
    }


}
