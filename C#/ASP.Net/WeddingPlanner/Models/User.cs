using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace WeddingPlanner.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [MaxLength(20, ErrorMessage = "must fewer than 20 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [MaxLength(20, ErrorMessage = "must fewer than 20 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage="is required.")]
        [Remote("EmailExists", "Account", HttpMethod = "POST", ErrorMessage = "Email address already registered.")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage="Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(8, ErrorMessage = "must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "must match Password")]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public List<Wedding> Weddings { get; set; }

        public List<WeddingRSVP> RSVPs { get; set; }
    }
}
