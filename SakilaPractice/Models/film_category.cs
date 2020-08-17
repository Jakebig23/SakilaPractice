using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaPractice.Models
{
    public class film_category
    {
        [Key]
        public int film_id { get; set; }
        public byte category_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
