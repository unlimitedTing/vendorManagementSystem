using System.Collections.Generic;

namespace VendorManagementSystem.Models.ViewModels
{
    public class DetailsEvent
    {
        public EventDto SelectedEvent { get; set; }
   
        public IEnumerable<UserDto> AssociatedUsers { get; set; }
        public IEnumerable<UserDto> AvailableUsers { get; set; }
    }
}
