using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface ISpecialMealOfferService : IGenericService<SpecialMealOffer>
    {
        List<SpecialMealOffer> GetSpecialMealOfferListWithCategory(int id);
    }
}
