using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
   public class SectionRepository:ISectionRepository
    {
        SchedulingDataContext db;
        public SectionRepository()
        {
            this.db = new SchedulingDataContext();
        }

        public List<Section> GetAll()
        {
            return this.db.Sections.ToList();
        }
        public Section Get(int id)
        {
            return db.Sections.SingleOrDefault(d => d.Id == id);
        }
        public int Insert(Section sa)
        {
            db.Sections.Add(sa);
            return db.SaveChanges();
        }
        public int Update(Section sa)
        {
            Section SecToUpdate = db.Sections.SingleOrDefault(d => d.Id == sa.Id);
            SecToUpdate.Id = sa.Id;
            SecToUpdate.CourseId = sa.CourseId;
            SecToUpdate.SectionName = sa.SectionName;
     

            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            Section sa = db.Sections.SingleOrDefault(d => d.Id == id);
            db.Sections.Remove(sa);
            return db.SaveChanges();
        }
    }
}
