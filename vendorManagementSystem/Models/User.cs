using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VendorManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public virtual ICollection<UserEvent> UserEvents { get; set; }
    }

    public class UserDto
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
