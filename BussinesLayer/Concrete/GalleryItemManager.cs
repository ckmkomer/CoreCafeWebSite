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
    public class GalleryItemManager : IGalleryItemService
    {
        IGalleryItemDal _galleryItemDal;

        public GalleryItemManager(IGalleryItemDal galleryItemDal)
        {
            _galleryItemDal = galleryItemDal;
        }

        public void TAdd(GalleryItem t)
        {
            _galleryItemDal.Insert(t);
        }

        public void TDelete(GalleryItem t)
        {
            _galleryItemDal.Delete(t);
        }

        public GalleryItem TGetByID(int id)
        {
            return _galleryItemDal.GetByID(id);
        }

        public List<GalleryItem> TGetList()
        {
            return _galleryItemDal.GetList();
        }

        public List<GalleryItem> TGetListbyFilter(int id)
        {
            return _galleryItemDal.GetbyFilter(x => x.ID == id);

        }

        public void TUpdate(GalleryItem t)
        {
            _galleryItemDal.Update(t);
        }
    }
}
