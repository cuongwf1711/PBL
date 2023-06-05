using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL.DTO
{
    public class TypeRoom
    {
        public int TypeRoomId { get; set; }
        [Index(IsUnique = true), StringLength(10), Required]
        public string Name { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
