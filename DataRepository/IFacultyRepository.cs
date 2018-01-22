using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    interface IFacultyRepository
    {
        List<Faculty> GetAll();
        Faculty Get(int id);
        int Insert(Faculty emp);
        int Delete(int id);
        int Update(Faculty emp);
    }
}
