using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Domain.Entities
{
    [Table("PERSON_INFO")]
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The First Name is required")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "The Birth Date is required")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "The Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "The Number of Dependents is required")]
        [Range(1, 50, ErrorMessage = "The Number of Dependents must be between 1 and 50")]
        public int NumberOfDependents { get; set; }
    }
}
