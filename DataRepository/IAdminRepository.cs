using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    interface IAdminRepository
    {
        List<Admin> GetAll();
        Admin Get(int id);
        int Insert(Admin emp);
        int Delete(int id);
        int Update(Admin emp);
    }
}
