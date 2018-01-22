using System;
using System.ComponentModel.DataAnnotations;

namespace DataRepository
{
    public class Admin
    {
        public int Id { get; set; }
        [Required, MaxLength(10), MinLength(4)]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress), Required(ErrorMessage = "Give a valid email address")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Give a valid Password"), MaxLength(20), MinLength(6)]
        public string Password { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}