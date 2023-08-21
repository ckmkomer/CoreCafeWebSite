using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    public class ReazarvationController : Controller
    {
        ReservationManager reservationManager =new ReservationManager(new EfReservationRepository());
        public IActionResult Index()
        {
           var values= reservationManager.TGetList();
            return View(values);
        }
    }
}
