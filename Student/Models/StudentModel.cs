using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
       
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
       
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int Age { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Enrolment Date")]
        public DateTime EnrolmentDate { get; set; }

        public int? CourseID { get; set; }
        public CourseModel Course { get; set; }
    }
}