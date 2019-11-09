using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace midterm.Models
{
    public class Teacher
    {
        /// <summary>
        /// Teacher id
        /// </summary>
        public int TeacherID { get; set; }

        /// <summary>
        /// Teacher id
        /// </summary>
        [Display(Name = "Teacher Name")]
        [Required]
        public String teach_name { get; set; }

        /// <summary>
        /// Teacher Phone
        /// </summary>
        [Display(Name = "Teacher Phone")]
        [Required]
        public int teach_phone { get; set; }

        /// <summary>
        /// Teacher eMail
        /// </summary>
        [Display(Name = "Teacher e-mail")]
        [Required]
        public int teach_mail { get; set; }
        public ICollection<Schedule> schedules { get; set; }
    }
}
