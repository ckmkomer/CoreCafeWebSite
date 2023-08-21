using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
	public class EfSpecialMealOfferRepository:GenericRepository<SpecialMealOffer>,ISpecialMealOfferDal
	{
        public List<SpecialMealOffer> GetSpecialMealOfferListWithCategory()
        {
            using (var c = new Context())
                return c.SpecialMealOffers.Include(x => x.CategoryMenuID).ToList();
        }


    }
}
