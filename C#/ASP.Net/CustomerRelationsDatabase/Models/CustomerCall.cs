using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRelationsDatabase.Models
{
    public class CustomerCall 
    {
        [Key]
        public int CustomerCallId { get; set; }
        
        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be more than 2 characters.")]
        [MaxLength(50, ErrorMessage = "must be fewer than 50 characters.")]
        [Display(Name = "Issue Reported")]
        public string IssueReported { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be more than 2 characters.")]
        [Display(Name = "Issue Description")]
        public string IssueDescription { get; set; }

        [MinLength(2, ErrorMessage = "must be more than 2 characters.")]
        [Display(Name = "Follow up Needed")]
        public string FollowUp { get; set; }

        [MinLength(2, ErrorMessage = "must be more than 2 characters.")]
        [Display(Name = "Issue Resolution")]
        public string IssueResolution { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Call Date")]
        public DateTime CallDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* Foreign Keys and Navigation Properties for Relationships */
        public int UserId { get; set; }
        public User User { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}