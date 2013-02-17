namespace AFTRVolunteersWeb.Models
{
    public class TimeSlot
    {
        public int TimeSlotId { get; set; }
        public int? StartTime { get; set; }
        public int? StopTime { get; set; }
        public int? StallId { get; set; }
        public virtual Stall Stall { get; set; }
    }
}