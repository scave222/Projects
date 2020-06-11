using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalEFC.Models
{
    public class Student
    {
        public long StudentID { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Minimum of 5 character")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Minimum of 5 character")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Range(18, 100, ErrorMessage = "Age limit is from 18-100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter your gender")]
        public string Gender { get; set; }


        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please enter a valid Email address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string HomeAddress { get; set; }

        [RegularExpression(@"[0-9]{4}[0-9]{3}[0-9]{4}", ErrorMessage = "Phone number should be in this format XXXX-XXX-XXXX")]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string PhoneNumber { get; set; }
    }
}
