using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class MakeRoutine
    {
        public int Id { get; set; }
        public string day { get; set; }
        public string room { get; set; }
        public string slot { get; set; }
        public string FacultyName { get; set; }
        public string SectionName { get; set; }
        public string CourseName { get; set; }
        public MakeRoutine()
        {

        }
        public MakeRoutine(string day,string room,string slot,string SectionName, string Facultyname, string CourseName)
        {
            this.day = day;
            this.room = room;
            this.slot = slot;
            this.FacultyName = Facultyname;
            this.SectionName = SectionName;
            this.CourseName = CourseName;
        }

    }
}
