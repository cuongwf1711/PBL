using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.DTO
{
    public class Late
    {
        public int LateId { get; set; }
        [Index(IsUnique = true), StringLength(50), Required]
        public string Name { get; set; }
        [Range(0, 1)]
        public decimal FeeLate { get; set; }
    }
}
