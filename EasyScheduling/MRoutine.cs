using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataRepository;
namespace EasyScheduling
{
    public class MRoutine
    {
        public FacultyAssign faculty;
        public SlotList slotList;
        public List<SlotList> listOfSlot;
        public List<SlotList> listOfSlot1;
        public List<FacultyAssign> listOfFaculty;
        
        public List<routineMaker> listOfRoutine1;
        public List<routineMaker> listOfRoutine2;
        public FacultyAssign fa = new FacultyAssign();
        FacultyRepository fr = new FacultyRepository();
        SectionRepository sr = new SectionRepository();
        CourseRepository cr = new CourseRepository();
        MakeRoutineRepository mk = new MakeRoutineRepository();
        public MRoutine()
        {
          
            listOfRoutine1 = new List<routineMaker>();
            listOfRoutine2 = new List<routineMaker>();
            listOfFaculty = new List<FacultyAssign>();
        }

        public MRoutine(FacultyAssign faculty, SlotList slotList)
        {
            this.faculty = faculty;
            this.slotList = slotList;
            listOfFaculty = new List<FacultyAssign>();
            listOfRoutine1 = new List<routineMaker>();
            listOfRoutine2 = new List<routineMaker>();
        }

        public List<routineMaker> GenerateRoutine()
        {
            SlotList slotList = new SlotList();
            FacultyAssign sc = new FacultyAssign();
            FacultyAssign sc1 = new FacultyAssign();

            listOfSlot = slotList.generateSlotList();
            listOfSlot1 = slotList.generateSlotList1();
         
       
            int count = 0;
            foreach (FacultyAssign a in sc.GetFacultyAssignList())
            {
                routineMaker rt = new routineMaker(listOfSlot[count].getDay1() + " ", listOfSlot[count].getRoom() + " ", listOfSlot[count].getSlot() + " ", fr.Get( a.FacultyId).Name,sr.Get(a.CourseId).SectionName,cr.Get(a.CourseId).CourseName);
                listOfRoutine1.Add(rt);
                MakeRoutine mr = new MakeRoutine(listOfSlot1[count].getDay1() + " ", listOfSlot1[count].getRoom() + " ", listOfSlot1[count].getSlot() + " ",sr.Get(a.CourseId).SectionName, fr.Get(a.FacultyId).Name, cr.Get(a.CourseId).CourseName);
                mk.Insert(mr);
                count++;
            }
            int count1 = 0;
            foreach (FacultyAssign b in sc1.GetFacultyAssignList())
            {
                routineMaker rt1 = new routineMaker(listOfSlot1[count1].getDay2() + " ", listOfSlot1[count1].getRoom() + " ", listOfSlot1[count1].getSlot() + " ", fr.Get(b.FacultyId).Name, sr.Get(b.CourseId).SectionName, cr.Get(b.CourseId).CourseName);
                listOfRoutine2.Add(rt1);
                MakeRoutine mr = new MakeRoutine(listOfSlot1[count1].getDay2() + " ", listOfSlot1[count1].getRoom() + " ", listOfSlot1[count1].getSlot() + " ", sr.Get(b.CourseId).SectionName, fr.Get(b.FacultyId).Name, cr.Get(b.CourseId).CourseName);
                mk.Insert(mr);
                count1++;
            }

            listOfRoutine1.AddRange(listOfRoutine2);
            return listOfRoutine1;

        }
    }
}