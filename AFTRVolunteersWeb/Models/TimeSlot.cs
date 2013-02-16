using System.Collections.Generic;

namespace AFTRVolunteersWeb.Models
{
    public class TimeSlot
    {
        public int TimeSlotId { get; set; }
        public int PersonId { get; set; }
        public int StallId { get; set; }
        public virtual Person Person { get; set; }
        public virtual Stall Stall { get; set; }
    }
}