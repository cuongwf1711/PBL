using System;

namespace PBL.DTO
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Price { get; set; }
        public int RoomId { get; set; }
        public int PersonId { get; set; }
        public int PaymentId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
