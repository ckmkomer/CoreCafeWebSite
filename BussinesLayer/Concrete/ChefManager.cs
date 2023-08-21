using BussinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
	public class ChefManager : IChefService
	{
		IChefDal _chefDal;

		public ChefManager(IChefDal chefDal)
		{
			_chefDal = chefDal;
		}

		public void TAdd(Chef t)
		{
			_chefDal.Insert(t);
		}

		public void TDelete(Chef t)
		{
			_chefDal.Delete(t);
		}

		public Chef TGetByID(int id)
		{
			return _chefDal.GetByID(id);
		}

		public List<Chef> TGetList()
		{
			return _chefDal.GetList();
		}

		public List<Chef> TGetListbyFilter(int id)
		{
			return _chefDal.GetbyFilter(x=>x.ChefID== id);
		}

		public void TUpdate(Chef t)
		{
			_chefDal.Update(t);
		}
	}
}
