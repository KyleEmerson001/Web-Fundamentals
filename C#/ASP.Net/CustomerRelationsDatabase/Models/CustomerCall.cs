using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerRelationsDatabase.Models
{
    public class CustomerCall 
    {
        [Key]
        public int CustomerCallId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* Foreign Keys and Navigation Properties for Relationships */
        public int UserId { get; set; }
        public User User { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}