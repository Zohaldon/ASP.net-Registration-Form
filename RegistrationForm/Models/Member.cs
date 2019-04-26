using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Models
{
    public class Member
    {

        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text,ErrorMessage ="Please Check your input, No Numbers or Special Charaters.")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "Please Check your input, No Numbers or Special Charaters.")]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]

        [DataType(DataType.Text, ErrorMessage = "Please Check your input, No Numbers or Special Charaters.")]
        public string City { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "Please Check your input, No Numbers or Special Charaters.")]
        public string Province { get; set; }
        [Required]
        [RegularExpression("(?i)^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$",
            ErrorMessage ="Please Enter the valid Canadian Postal Code With No Space, Format: A0A0A0")]

        public string PostalCode { get; set; }

        [Required]
        [Range(18,120)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Password)] //Default Type for the password
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)] //Default Type for the password
        [Compare("Password")] //Will match the enterred value with password
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string AlternativeEmail { get; set; }

        public long PhoneNumber { get; set; }

    }
}
