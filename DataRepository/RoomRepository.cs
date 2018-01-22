using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class RoomRepository:IRoomRepository
    {
        SchedulingDataContext db;
        public RoomRepository()
        {
            this.db = new SchedulingDataContext();
        }

        public List<Room> GetAll()
        {
            return this.db.Rooms.ToList();
        }
        public Room Get(int id)
        {
            return db.Rooms.SingleOrDefault(d => d.Id == id);
        }
        public int Insert(Room ro)
        {
            db.Rooms.Add(ro);
            return db.SaveChanges();
        }
        public int Update(Room ro)
        {
            Room RoomToUpdate = db.Rooms.SingleOrDefault(d => d.Id == ro.Id);
            RoomToUpdate.Id = ro.Id;
            RoomToUpdate.RoomNumber = ro.RoomNumber;

            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            Room ro = db.Rooms.SingleOrDefault(d => d.Id == id);
            db.Rooms.Remove(ro);
            return db.SaveChanges();
        }
    }
}
