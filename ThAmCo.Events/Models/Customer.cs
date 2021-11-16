using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Models
{
    public class Customer
    {
        public Customer(){

        }
        public Customer(string firstName, string lastName, string emailId): this()
        {
            FirstName = firstName;
            LastName = lastName;
            EmailId = emailId;
        }
        public Customer(string firstName, string lastName, long contactNumber, string emailId): this()
        {
            FirstName = firstName;
            LastName = lastName;
            ContactNumber = contactNumber;
            EmailId = emailId;
        }
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName  { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Contact Number")]
        public long ContactNumber { get; set; }

        [Required]
        public string EmailId { get; set; }



    }

   

}
