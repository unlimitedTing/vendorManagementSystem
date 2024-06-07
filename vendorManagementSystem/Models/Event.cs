using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VendorManagementSystem.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string EventLocation { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public virtual ICollection<UserEvent> UserEvents { get; set; }
    }

    public class EventDto
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string EventLocation { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }
    }
}
