using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace midterm.Models
{
    public class Student
    {
        /// <summary>
        /// Student id
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Student Name
        /// </summary>
        [Display(Name = "Student Name")]
        [StringLength(30, MinimumLength = 4)]
        [Required]
        public String stud_name { get; set; }

        /// <summary>
        /// Student Phone
        /// </summary>
        [Required]
        [Display(Name = "Student Phone")]
        [Phone]
        [StringLength(7)]
        public String stud_phone { get; set; }

        /// <summary>
        /// Student eMail
        /// </summary>
        [Display(Name = "Student e-mail")]
        [Required]
        [EmailAddress]
        public string stud_mail { get; set; }

        /// <summary>
        /// Group id
        /// </summary>s
        [Display(Name = "Group Id")]
        public int GroupID { get; set; }
        public Group group { get; set; }
    }
}
