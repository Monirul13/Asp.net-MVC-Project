using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataRepository;
namespace EasyScheduling
{
    public class SlotList
    {
        SchedulingDataContext context = new SchedulingDataContext();
        private Day1 day1;
        private Day2 day2;
        private string room;
        private Slot slot;
        public List<SlotList> listOfSlot;
        public List<SlotList> listOfSlot1;

        public SlotList()
        {
            listOfSlot = new List<SlotList>();
            listOfSlot1 = new List<SlotList>();
        }

        public SlotList(Day1 day1, string room, Slot slot)
        {
            this.day1 = day1;
            this.room = room;
            this.slot = slot;
            //this.section = section;
            listOfSlot = new List<SlotList>();
        }
        public SlotList(Day2 day2, string room, Slot slot)
        {
            this.day2 = day2;
            this.room = room;
            this.slot = slot;
            //this.section = section;
            listOfSlot1 = new List<SlotList>();
        }

        public Day1 getDay1()
        {
            return day1;
        }
        public Day2 getDay2()
        {
            return day2;
        }

        public string getRoom()
        {
            return room;
        }

        public Slot getSlot()
        {
            return slot;
        }
        public List<SlotList> generateSlotList()
        {
            var room = from ro in context.Rooms
                       select ro.RoomNumber;
            foreach (Day1 d1 in Enum.GetValues(typeof(Day1)))
            {
                foreach (string r in room.ToList())
                {
                    foreach (Slot s in Enum.GetValues(typeof(Slot)))
                    {
                        SlotList ls = new SlotList(d1, r, s);
                        listOfSlot.Add(ls);

                    }
                }
            }
           
            return listOfSlot;
        }
        public List<SlotList> generateSlotList1()
        {
            var room = from ro in context.Rooms
                       select ro.RoomNumber;
            foreach (Day2 d2 in Enum.GetValues(typeof(Day2)))
            {
                foreach (string r in room.ToList())
                {
                    foreach (Slot s in Enum.GetValues(typeof(Slot)))
                    {
                        SlotList ls1 = new SlotList(d2, r, s);
                        listOfSlot1.Add(ls1);

                    }
                }
            }

            return listOfSlot1;
        }

        public List<SlotList> getListOfSlot1()
        {
            return listOfSlot;
        }
        public List<SlotList> getListOfSlot2()
        {
            return listOfSlot1;
        }
    }
}