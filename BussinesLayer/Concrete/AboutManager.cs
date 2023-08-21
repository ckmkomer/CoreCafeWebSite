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
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TAdd(About t)
		{
			_aboutDal.Insert(t);
		}

		public void TDelete(About t)
		{
			_aboutDal.Delete(t);
		}

		public About TGetByID(int id)
		{
			 return _aboutDal.GetByID(id);
		}

		public List<About> TGetList()
		{
			return _aboutDal.GetList();
		}

		public List<About> TGetListbyFilter(int id)
		{
			return _aboutDal.GetbyFilter(x=>x.ID== id);
		}

		public void TUpdate(About t)
		{
			_aboutDal.Update(t);
		}
	}
}
