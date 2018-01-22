using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class Room
    {
        public int Id { get; set; }
        [Required, MaxLength(5), MinLength(3)]
        public string RoomNumber { get; set; }
    }
}
