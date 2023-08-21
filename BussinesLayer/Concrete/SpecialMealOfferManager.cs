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
	public class SpecialMealOfferManager : ISpecialMealOfferService
	{
		ISpecialMealOfferDal _specialMealOfferDal;

		public SpecialMealOfferManager(ISpecialMealOfferDal specialMealOfferDal)
		{
			_specialMealOfferDal = specialMealOfferDal;
		}

       
        public List<SpecialMealOffer> GetSpecialMealOfferListWithCategory(int id)
        {
			return _specialMealOfferDal.GetbyFilter(x => x.CategoryMenuID == id);
		}

        public void TAdd(SpecialMealOffer t)
		{
			_specialMealOfferDal.Insert(t);
		}

		public void TDelete(SpecialMealOffer t)
		{
			_specialMealOfferDal.Delete(t);
		}

		public SpecialMealOffer TGetByID(int id)
		{
			return _specialMealOfferDal.GetByID(id);
		}

		public List<SpecialMealOffer> TGetList()
		{
			return _specialMealOfferDal.GetList();
		}

		public List<SpecialMealOffer> TGetListbyFilter(int id)
		{
			return _specialMealOfferDal.GetbyFilter(x=>x.SpecialMealOfferID == id);
		}

		public void TUpdate(SpecialMealOffer t)
		{
			_specialMealOfferDal.Update(t);
		}
	}
}
