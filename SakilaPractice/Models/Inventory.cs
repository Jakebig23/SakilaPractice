using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaPractice.Models
{
    public class Inventory
    {
        [Key]
        public int inventory_id { get; set; }
        public int film_id { get; set; }
        public int store_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
