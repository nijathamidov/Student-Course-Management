using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseID { get; set; }
      
        [Required]
        [Display(Name ="Course Name")]
        public string CourseName { get; set; }
        
        [Required]
        public int Duration{ get; set; }

        [Required]
        public double Price { get; set; }


        public virtual ICollection<StudentModel> Students { get; set; }
    }
}