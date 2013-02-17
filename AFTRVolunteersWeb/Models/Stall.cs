using System.Collections.Generic;

namespace AFTRVolunteersWeb.Models
{
    public class Stall  
    {
        public int StallId { get; set; }
        public string Name { get; set; }
        public int? OwnerId { get; set; }
        public virtual Person Owner { get; set; }
        public virtual ICollection<TimeSlot> TimeSlots { get; set; } 
    }
}