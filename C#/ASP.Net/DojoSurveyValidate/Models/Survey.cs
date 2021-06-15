using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidate.Models
{
    public class Survey
    {
        [Required(ErrorMessage="is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        public string name { get; set; }
        [Required(ErrorMessage="is required")]
        public string dojo { get; set; }
        [Required(ErrorMessage="is required")]
        public string language { get; set; }
        [MaxLength(20, ErrorMessage = "must be fewer than 20 characters")]
        public string comment { get; set; }

    }
}