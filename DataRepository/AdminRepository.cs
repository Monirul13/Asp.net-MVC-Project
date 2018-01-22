using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    class AdminRepository:IAdminRepository
    {
        SchedulingDataContext db;
        public AdminRepository()
        {
            this.db = new SchedulingDataContext();
        }

        public List<Admin> GetAll()
        {
            return this.db.Admins.ToList();
        }
        public Admin Get(int id)
        {
            return db.Admins.SingleOrDefault(d => d.Id == id);
        }
        public int Insert(Admin ad)
        {
            db.Admins.Add(ad);
            return db.SaveChanges();
        }
        public int Update(Admin ad)
        {
            Admin AdToUpdate = db.Admins.SingleOrDefault(d => d.Id == ad.Id);
            AdToUpdate.Id = ad.Id;
            AdToUpdate.Name = ad.Name;
            AdToUpdate.Email = ad.Email;
            AdToUpdate.Password = ad.Password;
            ad.Phone = ad.Phone;

            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            Admin ad = db.Admins.SingleOrDefault(d => d.Id == id);
            db.Admins.Remove(ad);
            return db.SaveChanges();
        }
    }
}
