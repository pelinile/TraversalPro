using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementdal;

        public AnnouncementManager(IAnnouncementDal announcementdal)
        {
            _announcementdal = announcementdal;
        }

        public void TAdd(Announcement t)
        {
            _announcementdal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcementdal.Delete(t);
        }

        public Announcement TGetById(int id)
        {
            return _announcementdal.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementdal.GetList();
        }

        public void TUpdate(Announcement t)
        {
            _announcementdal.Update(t);
        }
    }
}
