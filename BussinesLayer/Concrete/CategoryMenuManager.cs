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
	public class CategoryMenuManager : ICategoryMenuService
	{
		ICategoryMenuDal _categoryMenuDal;

		public CategoryMenuManager(ICategoryMenuDal categoryMenuDal)
		{
			_categoryMenuDal = categoryMenuDal;
		}

		public void TAdd(CategoryMenu t)
		{
			_categoryMenuDal.Insert(t);
		}

		public void TDelete(CategoryMenu t)
		{
			_categoryMenuDal.Delete(t);
		}

		public CategoryMenu TGetByID(int id)
		{
			return _categoryMenuDal.GetByID(id);
		}

		public List<CategoryMenu> TGetList()
		{
			return _categoryMenuDal.GetList();
		}

		public List<CategoryMenu> TGetListbyFilter(int id)
		{
			return _categoryMenuDal.GetbyFilter(x=>x.CategoryMenuID== id);
		}

		public void TUpdate(CategoryMenu t)
		{
			_categoryMenuDal.Update(t);
		}
	}
}
