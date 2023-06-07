using System.ComponentModel.DataAnnotations;

namespace PBL.DTO
{
    public class Addition
    {
        public int AdditionId { get; set; }
        public decimal Price { get; set; }
        public int ServiceId { get; set; }
        [Range(1, 100)]
        public int Quantity { get; set; }
        public int PaymentId { get; set; }

        public virtual Service Service { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
