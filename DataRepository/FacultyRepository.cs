using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
   public class FacultyRepository : IFacultyRepository
    {
        SchedulingDataContext db;
        public FacultyRepository()
        {
            this.db = new SchedulingDataContext();
        }

        public List<Faculty> GetAll()
        {
            return this.db.Faculties.ToList();
        }
        public Faculty Get(int id)
        {
            return db.Faculties.SingleOrDefault(d => d.Id == id);
        }
        public int Insert(Faculty fa)
        {
            db.Faculties.Add(fa);
            return db.SaveChanges();
        }
        public int Update(Faculty fa)
        {
            Faculty FacToUpdate = db.Faculties.SingleOrDefault(d => d.Id == fa.Id);
            FacToUpdate.Id = fa.Id;
            FacToUpdate.Name = fa.Name;
            FacToUpdate.Email = fa.Email;
            FacToUpdate.Password = fa.Password;
            FacToUpdate.DateOfBirth = fa.DateOfBirth;
            FacToUpdate.Phone = fa.Phone;

            return db.SaveChanges();
        }
        public int Delete(int id)

        {
            Faculty fa = db.Faculties.SingleOrDefault(d => d.Id == id);
            db.Faculties.Remove(fa);
            return db.SaveChanges();
        }
    }
}
