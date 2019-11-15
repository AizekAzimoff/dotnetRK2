using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace midterm.Models
{
    public class Group : IValidatableObject
    {
       

        /// <summary>
        /// Group id
        /// </summary>
        public int GroupID { get; set; }

        /// <summary>
        /// Group Name
        /// </summary>
        [Remote("isNameNotUsed", "Groups", HttpMethod = "POST", ErrorMessage = "Group with such name already exists.")]
        public String group_name { get; set; }

        /// <summary>
        /// Teacher id
        /// </summary>
        [Display(Name = "Group Level")]
        [Required]
        public String group_level { get; set; }

        /// <summary>
        /// Number of students in group
        /// </summary>
        [Display(Name = "Group stud number")]
        [Required]
        public int group_stud_num { get; set; }
        public ICollection<Student> students { get; set; }
        public ICollection<Schedule> schedules { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.group_name))
            {
                errors.Add(new ValidationResult("You can not create group without name."));
            }
            else if (new Regex("!@#$%^&*()_+-=").Matches(this.group_name).Count > 0)
            {
                errors.Add(new ValidationResult("Dont use invalid symbols please."));
            }
            return errors;
        }

        public Group(int groupID, string group_name, string group_level, int group_stud_num)
        {
            GroupID = groupID;
            this.group_name = group_name;
            this.group_level = group_level;
            this.group_stud_num = group_stud_num;
        }
        public Group(string group_name)
        {
            this.group_name = group_name;
        }
        public Group()
        {
        }
    }
}
