using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBL.DTO
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public bool Status { get; set; }
        [Range(0, 1)]
        public decimal Deposit { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateCheckout { get; set; }
        [Range(0, 1)]
        public decimal FeeEarly { get; set; }
        [Range(0, 1)]
        public decimal FeeLate { get; set; }

        public int PersonId { get; set; }
        public int? VoucherId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Voucher Voucher { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
    }
}
