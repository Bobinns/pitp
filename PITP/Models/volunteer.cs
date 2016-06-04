using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PITP.Models
{
    public class volunteer
    {
        public DateTime Date { get; set; } = DateTime.UtcNow;
        [Required(ErrorMessage = "You forgot to enter your name!")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Telephone No.")]
        public string Telephone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required (we promise not to spam you!).")]
        [DisplayName("Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Select Either Yes or No")]
        [DisplayName("Are you over 18 and below 55?")]
        public IEnumerable<string> Over18 { get; set; }

        [DisplayName("Which roles are you interested in?")]
        public IEnumerable<string> InterestedRoles { get; set; }

        [DisplayName("Please tick one or more from the list below if you have the relevant skills:")]
        public IEnumerable<string> Skills { get; set; }

        [Required(ErrorMessage = "Please Select Either Yes or No")]
        [DisplayName("Do you have a valid CRB check")]
        public IEnumerable<string> CRB { get; set;}

        [DisplayName("Would you like to do a full day of First Aid Training?")]
        public IEnumerable<string> FirstAid { get; set; }

        public bool MadCap { get; set; }
    }
}