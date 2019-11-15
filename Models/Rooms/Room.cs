using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace midterm.Models
{
    public class Room : IValidatableObject
    {

        /// <summary>
        /// Room id
        /// </summary>
        public int RoomID { get; set; }

        /// <summary>
        /// Room number
        /// </summary>
        [Display(Name = "Room number")]
        [Required]
        public int room_number { get; set; }

        /// <summary>
        /// Number of seats in room
        /// </summary>s
        [Display(Name = "Room seat number")]
        [Required]
        public int room_seat_num { get; set; }
        public ICollection<Schedule> schedules { get; set; }

        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if ((Math.Floor(Math.Log10(room_number) + 1)) != 3)
            {
                yield return new ValidationResult(
                    $"Number of room should contain 3 digits" );
            }
        }

    }
}
