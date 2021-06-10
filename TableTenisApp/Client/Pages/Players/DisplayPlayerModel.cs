using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TableTenisApp.Client.Pages.Players
{
    public class DisplayPlayerModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name too short")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Surname too short")]
        public string Surname { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Email too short")]
        public string Email { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Country name too short")]
        public string Country { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string PicturePath { get; set; }
        [Required]
        public int Points { get; set; }
    }
}

