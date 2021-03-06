using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace belt1.Models
{
    public class Activity: BaseEntity
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActivityID {get; set;}

        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        

        public DateTime StartTime { get; set; }

        //This is in Minutes
        public int Duration { get; set; }

        public string Description { get;  set; }

        public int CreatorID { get; set; }

        public User Creator { get; set; }

        public List<UserActivity> UsersAttending { get; set;}


        public Activity() {
            UsersAttending = new List<UserActivity>();
        }

    }
}