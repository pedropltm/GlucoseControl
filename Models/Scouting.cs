namespace GlucoseControl.Models
{
    public class Scouting
    {
        public long Id { get; set; }
        public Patient Patient { get; set; }
        public DateTime DateTime { get; set; }
        public Meal Meals { get; set; }
        public Medicine Medicines { get; set; }
        public int Value { get; set; }
        public int RecommendedValue { get; set; }
    }
}