using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Street { get; set; }
        public int BuildingNo { get; set; }
        public int Zipcode { get; set; }
        [ForeignKey ("Player")]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
    }
}
