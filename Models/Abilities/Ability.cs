using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace midterm.Models
{
    public class Ability
    {
        /// <summary>
        /// Ability id
        /// </summary>
        public int AbilityID { get; set; }

        /// <summary>
        /// Course id
        /// </summary>
        [Display(Name = "Course Id")]
        public int CourseID { get; set; }
        public Course course { get; set; }

        /// <summary>
        /// Teacher id
        /// </summary>s
        [Display(Name = "Teacher Id")]
        public int TeacherID { get; set; }
        public Teacher teacher { get; set; }
        
    }
}
