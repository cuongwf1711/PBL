using System;
using System.ComponentModel.DataAnnotations;

namespace PBL.DTO
{
    public class CheckBirthday : RangeAttribute
    {
        public CheckBirthday() : base(typeof(DateTime), DateTime.Now.AddYears(-80).ToString("dd/MM/yyyy"), DateTime.Now.AddYears(-18).ToString("dd/MM/yyyy"))
        {

        }
    }
}
