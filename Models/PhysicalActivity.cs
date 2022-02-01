namespace GlucoseControl.Models
{
    public class PhysicalActivity
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        public string? Description { get; set; }
        //public PhysicalActivityType Type { get; set; }
    }
}