﻿using BussinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
	public class ReservationManager : IReservationService
	{
		IReservationDal _reservationDal;

		public ReservationManager(IReservationDal reservationDal)
		{
			_reservationDal = reservationDal;
		}

		public void TAdd(Reservation t)
		{
			_reservationDal.Insert(t);
		}

       
        

        public void TDelete(Reservation t)
		{
			_reservationDal.Delete(t);
		}

		public Reservation TGetByID(int id)
		{
		return _reservationDal.GetByID(id);
		}

		public List<Reservation> TGetList()
		{
			return _reservationDal.GetList();
		}

		public List<Reservation> TGetListbyFilter(int id)
		{
			return _reservationDal.GetbyFilter(x=>x.ID==id);
		}

		public void TUpdate(Reservation t)
		{
			_reservationDal.Update(t);
		}
	}
}
