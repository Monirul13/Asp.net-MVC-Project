using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyScheduling
{
    public class routineMaker
    {
        public string day { get; set; }
        public string room { get; set; }
        public string slot { get; set; }
        public string FacultyName { get; set; }
        public string SectionName { get; set; }
        public string CourseName { get; set; }

        public routineMaker()
        {
            List<routineMaker> routine = new List<routineMaker>();
        }
        public routineMaker(string d, string room, string slot, string FacultyName,string SectionName, string CourseName)
        {
            this.day = d;
            this.room = room;
            this.slot = slot;
            this.FacultyName = FacultyName;
            this.SectionName = SectionName;
            this.CourseName = CourseName;
            List<routineMaker> routine = new List<routineMaker>();
        }
    }
}