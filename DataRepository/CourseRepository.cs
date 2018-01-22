using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class CourseRepository:ICourseRepository
    {
        SchedulingDataContext db;
        public CourseRepository()
        {
            this.db = new SchedulingDataContext();
        }

        public List<Course> GetAll()
        {
            return this.db.Courses.ToList();
        }
        public Course Get(int id)
        {
            return db.Courses.SingleOrDefault(d => d.Id == id);
        }
        public int Insert(Course fa)
        {
            db.Courses.Add(fa);
            return db.SaveChanges();
        }
        public int Update(Course co)
        {
            Course CrsToUpdate = db.Courses.SingleOrDefault(d => d.Id == co.Id);
            CrsToUpdate.Id = co.Id;
            CrsToUpdate.CourseName = co.CourseName;

            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            Course co = db.Courses.SingleOrDefault(d => d.Id == id);
            db.Courses.Remove(co);
            return db.SaveChanges();
        }
    }
}
