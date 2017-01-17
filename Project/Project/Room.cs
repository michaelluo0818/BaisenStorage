using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project
{
    [Table("Room")]
    public class Room
    {
        public virtual ICollection<Storages> Str { get; set; }
        [Key]
        public Guid Uid { get; set; }
        public int Unit { get; set; }
    }

    public class StorageDBContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Storages> Strs { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Password> Passwords { get; set; }
    }
}
