using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace JobSeekers.Models
{
    public class JobSeeker
    {
        [Key]
        public long JobSeekersID { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Minimum of 3 character")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Minimum of 3 character")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your date of birth")]
        
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Input should be male or female")]
        public string Sex { get; set; }

        [RegularExpression(@"[0-9]{4}[0-9]{3}[0-9]{4}", ErrorMessage = "Phone number should be in this format XXXX-XXX-XXXX")]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please enter a valid Email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Minimum of 5 character")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "Please enter your qualification")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Minimum of 2 character")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "Please enter your course of study")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Minimum of 3 character")]
        public string CourseOfStudy { get; set; }

        [Required(ErrorMessage = "Please enter your years of experience")]
        [Range(0, 20, ErrorMessage = "Years of experience should be between 0 to 20")]
        public int YrsOfExp { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Password should contain minimum of 4 and maximum of 10")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your confirm password")]

        private string confirmPassword;

        public string ConfirmPassword
        {
            get {return confirmPassword; }
            set
            {
                if(value == Password)
                {
                    confirmPassword = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException ("password did not match");
                }
            }


        }
    }
}
