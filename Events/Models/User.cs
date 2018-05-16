using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Models
{
    public class User
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Name")]
        [Display(Name = "Ała")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone")]
        public string Phone { get; set; }
        public DateTime? Created { get; set; }
    }
}
