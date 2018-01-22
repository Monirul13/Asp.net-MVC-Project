using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    interface ISectionRepository
    {
        List<Section> GetAll();
        Section Get(int id);
        int Insert(Section emp);
        int Delete(int id);
        int Update(Section emp);
    }
}
