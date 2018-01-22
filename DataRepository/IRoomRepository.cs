using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    interface IRoomRepository
    {
        List<Room> GetAll();
        Room Get(int id);
        int Insert(Room emp);
        int Delete(int id);
        int Update(Room emp);
    }
}
