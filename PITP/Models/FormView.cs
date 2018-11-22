using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PITP.Models
{
    public class FormView
    {
        [StringLength(50, ErrorMessage = "Message cannot be longer than 50 characters.")]
        public string Message { get; set; }

        [StringLength(50, ErrorMessage = "Your Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [DisplayName("Donation Amount")]
        [Range(0.01, 1000.00,
            ErrorMessage = "Price must be between 0.01 and £1000.00")]
        public decimal amount { get; set; }
    }
}