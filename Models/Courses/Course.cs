using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace midterm.Models
{
    public class Course
    {
        /// <summary>
        /// Course id
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Course id
        /// </summary>
        [Display(Name = "Course Language")]
        public String course_lang { get; set; }

        /// <summary>
        /// Teacher id
        /// </summary>
        [Display(Name = "Course Duration")]
        public String course_dur { get; set; }

        public ICollection<Ability> abilities { get; set; }
        public ICollection<Schedule> schedules { get; set; }
    }
}
