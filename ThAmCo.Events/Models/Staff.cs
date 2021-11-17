using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Models
{
    public class Staff
    {
        public Staff()
        {

        }
        public Staff(string staffFirstName, string staffLastName, string staffType) : this()
        {
            StaffFirstName = staffFirstName;
            StaffLastName = staffLastName;
            StaffType = staffType;
        }
        [Display(Name = "Staff Id")]
        public int StaffId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string StaffFirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string StaffLastName { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string StaffType { get; set; }
    }
}
