using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace belt1.Models
{
    public class ActivityViewModel: BaseEntity
    {
        
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        
        [FutureDate(ErrorMessage="Date should be in the future.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage="Specify the denomination and amount of time for this activity")]
        public int Duration { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get;  set; }

    }

    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && (DateTime)value > DateTime.Now;
        }
    }  
}