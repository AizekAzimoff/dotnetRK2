using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace midterm.Models
{
    public class Group
    {
        /// <summary>
        /// Group id
        /// </summary>
        public int GroupID { get; set; }

        /// <summary>
        /// Group Name
        /// </summary>
        [Display(Name = "Group Name")]
        public String group_name { get; set; }

        /// <summary>
        /// Teacher id
        /// </summary>
        [Display(Name = "Group Level")]
        public String group_level { get; set; }

        /// <summary>
        /// Number of students in group
        /// </summary>
        [Display(Name = "Group stud number")]
        public int group_stud_num { get; set; }
        public ICollection<Student> students { get; set; }
        public ICollection<Schedule> schedules { get; set; }
    }
}
