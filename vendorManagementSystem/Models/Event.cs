using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vendorManagementSystem.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription {  get; set; }
        public string EventType { get; set; }
        public string EventLocation { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public ICollection<UserEvent> UserEvents { get; set; }
    }
}