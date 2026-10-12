using ASP02Razor.Models;

namespace ASP02Razor.Services
{
    public class DataProviderService
    {
        public string Text { get; set; } = "Velryba";
        public List<Human> Humans { get; set; } = new List<Human>
        {
            new Human { HumanId = 1, Name = "Alice", Gender = Gender.Female },
            new Human { HumanId = 2, Name = "Bob", Gender = Gender.Male },
            new Human { HumanId = 3, Name = "Charlie", Gender = Gender.Other },
            new Human { HumanId = 4, Name = "Dana", Gender = Gender.Unknown },
            new Human { HumanId = 5, Name = "Eve", Gender = Gender.Whocares }
        };
    }
}
