using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FullName
        {
            get => FirstName + " " + LastName;
        }
        [Required]
        public string FirstName { get; set; } = "chisom";

        [Required]
        public string LastName { get; set; } = "Faith";
        [Required]
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsDeprecated { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
