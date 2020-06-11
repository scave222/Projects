using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsAcademyEFC.Models
{
    public class SystemUsers
    {
        [Key]
        public long Id { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please enter a valid Email address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter your Status")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Minimum of 5 character")]
        public string Status { get; set; }

        [Required(ErrorMessage ="Please enter your Role")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Minimum of 5 character")]
        public string Role { get; set; }

        //[ForeignKey("Department")]
        //public long DeptId { get; set; }

        //public Department DeptName { get; set; }

        [Required(ErrorMessage ="Please enter your username")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Minimum of 5 character")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Please enter your password")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Minimum of 5 character")]
        public string Password { get; set; }
    }
}
