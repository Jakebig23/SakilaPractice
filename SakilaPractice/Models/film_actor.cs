using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaPractice.Models
{
    public class film_actor
    {
        [Key]
        public int actor_id { get; set; }
        public int film_id { get; set; }

        public DateTime last_update { get; set; }
    }
}
