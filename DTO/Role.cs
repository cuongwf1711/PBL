using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL.DTO
{
    public class Role
    {
        public int RoleId { get; set; }
        [Index(IsUnique = true), StringLength(20), Required]
        public string Name { get; set; }
        public string Permisssion { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
