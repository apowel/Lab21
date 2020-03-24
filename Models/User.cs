using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "An email is required.")]
        [EmailAddress(ErrorMessage = "That is not a valid email format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A password is required.")]
        public string Password { get; set; }
    }
}