using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    [Table("Passwords")]
    public class Password
    {
        [Key]
        public int Id { get; set; }

        public string password { get; set; }
    }
}
