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
	public class MenuItemManager : IMenuItemService
	{
		IMenutemDal _menutemDal;

		public MenuItemManager(IMenutemDal menutemDal)
		{
			_menutemDal = menutemDal;
		}

		public void TAdd(MenuItem t)
		{
			_menutemDal.Insert(t);
		}

		public void TDelete(MenuItem t)
		{
			_menutemDal.Delete(t);
		}

		public MenuItem TGetByID(int id)
		{
		return	_menutemDal.GetByID(id);
		}

		public List<MenuItem> TGetList()
		{
			return _menutemDal.GetList();
		}

		public List<MenuItem> TGetListbyFilter(int id)
		{
			return _menutemDal.GetbyFilter(x=>x.MenuItemID==id);
		}

		public void TUpdate(MenuItem t)
		{
			
			_menutemDal.Update(t);
		}
	}
}
