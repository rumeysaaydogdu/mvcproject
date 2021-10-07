using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IContentService
    {
        List<Content> GetList();  // önce interface kısmnda metodu tanımla sonra sınıf tarafında (categoryManager) içini doldur
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id);
        void ContentAdd(Content content);
        Content GetByID(int id);
        void ContentDelete(Content content);

        void ContentUpdate(Content content);
    }
}
