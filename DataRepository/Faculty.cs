using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class Faculty
    {
      
        public int Id { get; set; }
        [Required,MaxLength(10),MinLength(4)]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress), Required(ErrorMessage = "Give a valid email address")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Give a valid Password"),MaxLength(20),MinLength(6)]
        public string Password { get; set; }
     


    }
}
