using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataRepository;
namespace EasyScheduling
{
    public enum Day1
    {
        SUN,
        MON
    }
    public enum Day2
    {
        Wed,
        Tue
    }
    public enum Slot
    {
        M10to12,
        M12to2,
        M2to4
    }



    public class FacultyAssign
    {

        public List<string> slotList = new List<string>();
        public int FacultyId { get; set; }
      
        public string SectionName { get; set; }
        public int CourseId { get; set; }
        SchedulingDataContext context = new SchedulingDataContext();
        public List<FacultyAssign> FacultyAssignList;

        FacultyRepository faculty = new FacultyRepository();
        SectionRepository section = new SectionRepository();
        public FacultyAssign()
        {

            FacultyAssignList = new List<FacultyAssign>();
           
        }

        public FacultyAssign(int FacultyId,  string SectionName, int courseId)
        {

            this.FacultyId = FacultyId;
         
            this.SectionName = SectionName;
            this.CourseId = courseId;


            FacultyAssignList = new List<FacultyAssign>();
        }

        public List<FacultyAssign> GetFacultyAssignList()
        {


            var result = from r in context.Sections
                         select r;
                                        

            foreach (var assign in result)
            {
                FacultyAssignList.Add(new FacultyAssign(assign.FacultyId,assign.SectionName, assign.CourseId));
            }
      
           


            MRoutine routine = new MRoutine();
            return FacultyAssignList;
        }






        public List<routineMaker> GenerateRoutine()
        {

            MRoutine routine = new MRoutine();
            return routine.GenerateRoutine();


        }
       
    }
}

