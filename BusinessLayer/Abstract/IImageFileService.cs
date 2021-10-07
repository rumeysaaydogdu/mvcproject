using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IImageFileService
    {
        List<ImageFile> GetList();  // önce interface kısmnda metodu tanımla sonra sınıf tarafında (categoryManager) içini doldur
    }
}
