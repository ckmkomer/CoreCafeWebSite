using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
	public interface ISpecialMealOfferDal:IGenericDal<SpecialMealOffer>
	{
        List<SpecialMealOffer> GetSpecialMealOfferListWithCategory();
    }
}
