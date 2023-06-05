using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL.DTO
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomId { get; set; }
        [Range(0, 10)]
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public int TypeRoomId { get; set; }

        public virtual TypeRoom TypeRoom { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
