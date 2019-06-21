using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{

    [Table("Player")]
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string Email { get; set; }
        public int JersyNo { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public virtual Address Address { get; set; }
    }
}
