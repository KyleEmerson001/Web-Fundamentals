using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidate.Models
{
    public class Survey
    {
        [Required(ErrorMessage="is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "name")]
                public string name { get; set; }
        [Required(ErrorMessage="is required")]
        [Display(Name = "dojo")]
        public string dojo { get; set; }
        [Required(ErrorMessage="is required")]
        [Display(Name = "language")]
        public string language { get; set; }
        [MaxLength(20, ErrorMessage = "must be fewer than 20 characters")]
        [Display(Name = "comment")]
        public string comment { get; set; }

    }
}