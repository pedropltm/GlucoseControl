namespace GlucoseControl.Models
{
    public class Patient
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Age { get; set; }
    }
}