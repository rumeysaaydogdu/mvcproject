using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();  // önce interface kısmnda metodu tanımla sonra sınıf tarafında (categoryManager) içini doldur
        void ContactAdd(Contact contact);
        Contact GetByID(int id);
        void ContactDelete(Contact contact);

        void ContactUpdate(Contact contact);
    }
}

