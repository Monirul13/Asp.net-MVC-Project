using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class SchedulingDataContext: DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<MakeRoutine> MakeRoutines { get; set; }
        public DbSet<ClassSchedules> ClassSchedules { get; set; }
        

    }
}
