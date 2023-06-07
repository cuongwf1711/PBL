using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.DTO
{
    public class Voucher
    {
        public int VoucherId { get; set; }
        [Index(IsUnique = true), StringLength(50), Required]
        public string Code { get; set;}
        [Range(1, 50)]
        public int Quantity { get; set;}
        [Range(0,1)]
        public decimal Discount { get; set;}
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
