using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL.DTO
{
    public abstract class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }
        [Index(IsUnique = true), StringLength(10), RegularExpression(@"^[0-9]{10}$"), Required]
        public string PhoneNumber { get; set; }
        [StringLength(100), RegularExpression(@"^[a-zA-Z\s]+$"), Required]
        public string Name { get; set; }
        [CheckBirthday, Column(TypeName = "Date")]
        public DateTime Birthday { get; set; }
    }
}
