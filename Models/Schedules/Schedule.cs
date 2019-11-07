using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace midterm.Models
{
    public class Schedule
    {
        /// <summary>
        /// Schedule id
        /// </summary>
        public int ScheduleID { get; set; }

        /// <summary>
        /// Schedule day
        /// </summary>
        [Display(Name = "Schedule day")]
        public int sch_day{ get; set; }

        /// <summary>
        /// Room id
        /// </summary>
        [Display(Name = "Room Id")]
        public int RoomID { get; set; }
        public Room room { get; set; }
        /// <summary>
        /// Teacher id
        /// </summary>s
        [Display(Name = "Teacher Id")]
        public int TeacherID { get; set; }
        public Teacher teacher { get; set; }


        /// <summary>
        /// Group id
        /// </summary>s
        [Display(Name = "Group Id")]
        public int GroupID { get; set; }
        public Group group { get; set; }

        /// <summary>
        /// Course id
        /// </summary>
        [Display(Name = "Course Id")]
        public int CourseID { get; set; }
        public Course course { get; set; }
    }
}
