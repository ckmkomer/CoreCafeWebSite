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
	public class ContactInfoManager : IContactInfoService
	{
		IContactInfoDal _contactInfoDal;

		public ContactInfoManager(IContactInfoDal contactInfoDal)
		{
			_contactInfoDal = contactInfoDal;
		}

		public void TAdd(ContactInfo t)
		{
			_contactInfoDal.Insert(t);
		}

		public void TDelete(ContactInfo t)
		{
			_contactInfoDal.Delete(t);
		}

		public ContactInfo TGetByID(int id)
		{
			return _contactInfoDal.GetByID(id);
		}

		public List<ContactInfo> TGetList()
		{
		return _contactInfoDal.GetList();
		}

		public List<ContactInfo> TGetListbyFilter(int id)
		{
			return _contactInfoDal.GetbyFilter(x=>x.ID== id);
		}

		public void TUpdate(ContactInfo t)
		{
			_contactInfoDal.Update(t);
		}
	}
}
