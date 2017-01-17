using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    [Table("Storage")]
    public class Storages
    {
        [Key]
        public Guid Uid { get; set; }
        public int unit { get; set; }
        public bool carryOver { get; set; }
        public bool notEmpty { get; set;}
        public bool used { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNum { get; set; }
        public string desc { get; set; }
        public double rent { get; set; }
        public double sumPaid { get; set; }
        public double cardPaid { get; set; }
        public double cashPaid { get; set; }
        public double chequePaid { get; set; }
        public double area { get; set; }
        public double rentleft { get; set; }
    }
}
