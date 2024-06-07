using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vendorManagementSystem.Models
{
    public class User
    {
        public int UserId {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<UserEvent> UserEvents { get; set; }
    }
}