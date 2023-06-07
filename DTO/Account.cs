using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL.DTO
{
    public class Account : Person
    {
        [Index(IsUnique = true), EmailAddress, StringLength(100), Required]
        public string Email { get; set; }
        [StringLength(64), Required]
        public string Password { get; set; }
        public bool Active { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
