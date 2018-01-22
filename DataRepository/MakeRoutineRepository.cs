using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class MakeRoutineRepository:IMakeRoutineRepository
    {

        SchedulingDataContext db;
        public MakeRoutineRepository()
        {
            this.db = new SchedulingDataContext();
        }

        public List<MakeRoutine> GetAll()
        {
            return this.db.MakeRoutines.ToList();
        }
    
        public int Insert(MakeRoutine mk)
        {
            db.MakeRoutines.Add(mk);
            return db.SaveChanges();
        }
      

        public void DeleteAll()
        {

            db.MakeRoutines.RemoveRange(db.MakeRoutines);
            db.SaveChanges();
        }

    }
}
