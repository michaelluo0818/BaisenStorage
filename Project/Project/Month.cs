using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    [Table("Month")]
    public class Month
    {
        public virtual ICollection<Room> Rooms { get; set; }
        [Key]
        public string CurrentMonth { get; set; }
    }
}
