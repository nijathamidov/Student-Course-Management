using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Web;

namespace Student.Models
{
    public class CourseContext: DbContext
    {
        public CourseContext():base("CourseDB")
        {

        }

        public DbSet<StudentModel> Students { get; set; }
        public DbSet<CourseModel> Courses { get; set; }

    }
}