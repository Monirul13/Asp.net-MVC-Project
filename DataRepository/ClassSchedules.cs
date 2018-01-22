using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository
{
    public class ClassSchedules
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string SectionName { get; set; }
        public string RoomNO { get; set; }
        public string CourseName { get; set; }
        public string Slot { get; set; }
    }
}