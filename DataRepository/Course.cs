using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class Course
    {
        public int Id { get; set; }
        [Required, MaxLength(10), MinLength(4)]
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
    }
}
