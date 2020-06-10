using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set;}
        [StringLength(50, MinimumLength = 3)]
        public String Title { get; set; }
        [Range(0, 5)]
        public int Credits { set; get; }
        public int DepartmentID { set; get; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set;}
        public virtual ICollection<Instructor> Instructors { get; set; }



    }
}