using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "A name is required.")]
        [StringLength(20, ErrorMessage = "UserName must be between 3 and 10 characters")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Numbers and symbols are not allowed in a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "An email is required.")]
        [EmailAddress(ErrorMessage = "That is not a valid email format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A password is required.")]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "This field cannot be empty.")]
        [Range(1,150, ErrorMessage = "Value must be between 1 and 150")]
        public float Balance { get; set; }
        [Phone()]
        [RegularExpression(@"^(?:\([2-9]\d{2}\)\ ?|[2-9]\d{2}(?:\-?|\ ?))[2-9]\d{2}[- ]?\d{4}$", ErrorMessage = "That is not a valid phone number.")]
        /*
        US Phone Number: This regular expression for US phone numbers conforms to NANP A-digit and D-digit requirments (ANN-DNN-NNNN). 
        Area Codes 001-199 are not permitted; Central Office Codes 001-199 are not permitted. Format validation accepts 10-digits without delimiters, 
        optional parens on area code, and optional spaces or dashes between area code, central office code and station code. Acceptable formats 
        include 2225551212, 222 555 1212, 222-555-1212, (222) 555 1212, (222) 555-1212, etc. You can add/remove formatting options to meet your needs.
        */
        public string Phone { get; set; }
        public bool Waffles { get; set; }
    }
}