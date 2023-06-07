using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL.DTO
{
    public class Service
    {
        public int ServiceId { get; set; }
        [Index(IsUnique = true), StringLength(50), Required]
        public string Name { get; set; }
        public decimal Price { get; set; }


        public virtual ICollection<Addition> Additions { get; set; }
    }
}
