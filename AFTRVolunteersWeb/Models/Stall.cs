using System.Collections.Generic;

namespace AFTRVolunteersWeb.Models
{
    public class Stall  
    {
        public int StallId { get; set; }
        public string Name { get; set; }
        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<TimeSlot> TimeSlots { get; set; } 
    }
}