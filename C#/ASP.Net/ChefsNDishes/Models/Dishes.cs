using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsNDishes.Models
  {
      public class Dish
      {
        public int DishId { get; set; }
 
        [Required(ErrorMessage = "is required")]
        [Display(Name = "Chef's Name")]
        public string ChefName { get; set; }
        
        [Required(ErrorMessage = "is required")]
        [Display(Name = "Name of Dish")]
        public string DishName { get; set; }

        [Required(ErrorMessage = "is required")]
        [Range(1,5)]
        [Display(Name = "Tastiness")]
        public int Tastiness { get; set; }

        [Required(ErrorMessage = "is required")]
        [Range(1,100000)]
        [Display(Name = "# of Calories")]
        public int Calories { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }
 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

      public int ChefId {get; set;}
			public Chef Cook {get; set;}
      }
  }
