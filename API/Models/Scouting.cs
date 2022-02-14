using System;

namespace GlucoseControl.Models
{
    public class Scouting
    {
        public long Id { get; set; }
        public Patient Patient { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public Meal Meals { get; set; } = null!;
        public Medicine Medicines { get; set; } = null!;
        public int Value { get; set; }
        public int RecommendedValue { get; set; }
    }
}