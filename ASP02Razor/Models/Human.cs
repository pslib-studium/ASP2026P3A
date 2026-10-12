namespace ASP02Razor.Models
{
    public class Human
    {
        public int HumanId { get; set; }
        public required string Name { get; set; }
        public Gender Gender { get; set; } = Gender.Unknown;
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female,
        Other,
        Whocares
    }
}
