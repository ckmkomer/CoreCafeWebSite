using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents
{
    public class DashboardResarvationList:ViewComponent
    {
        ReservationManager reservationManager = new ReservationManager(new EfReservationRepository());
        public IViewComponentResult Invoke()
        {
            var values = reservationManager.TGetList();
            return View(values);
        }
    }
}
