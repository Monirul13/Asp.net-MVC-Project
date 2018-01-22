using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    interface IMakeRoutineRepository
    {
        List<MakeRoutine> GetAll();
      
        int Insert(MakeRoutine emp);
    
    }
}
