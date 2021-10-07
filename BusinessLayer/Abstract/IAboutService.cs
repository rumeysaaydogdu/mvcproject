using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();  // önce interface kısmnda metodu tanımla sonra sınıf tarafında (categoryManager) içini doldur
        void AboutAdd(About about);
        About GetByID(int id);
        void AboutDelete(About about);

        void AboutUpdate(About about);
    }
}
