using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class Section
    {
        public int Id { get; set; }
        [Required, MaxLength(10), MinLength(4)]
        public string SectionName { get; set; }
        public int FacultyId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
