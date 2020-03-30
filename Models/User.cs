using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "This field cannot be empty.")]
        [Range(1,150, ErrorMessage = "Value must be between 1 and 150")]
        public float Balance { get; set; }
    }
}