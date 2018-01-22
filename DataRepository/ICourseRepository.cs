using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    interface ICourseRepository
    {
        List<Course> GetAll();
        Course Get(int id);
        int Insert(Course emp);
        int Delete(int id);
        int Update(Course emp);
    }
}
