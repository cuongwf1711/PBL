using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBL.DTO
{
    public class Customer : Person
    {
        [StringLength(50), RegularExpression(@"^[a-zA-Z\s]+$"), Required]
        public string Country { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
