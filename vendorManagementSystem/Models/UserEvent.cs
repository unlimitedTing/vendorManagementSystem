using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vendorManagementSystem.Models
{
    public class UserEvent
    {
        public int UserEventId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}