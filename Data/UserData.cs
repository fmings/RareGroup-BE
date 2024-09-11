using RareGroup_BE.Models;

namespace RareGroup_BE.Data
{
    public class UserData
    {
        public static List<User> Users = new List<User>
        {
            new User
            {
            Id = 1,
            FirstName = "Britnay",
            LastName = "Gore",
            Email = "britnayg@gmail.com",
            Bio = "The Island Gyal",
            CreatedOn = new DateTime(2022, 10, 6),
            },

            new User
            {
            Id = 2,
            FirstName = "Felicia",
            LastName = "Mings",
            Email = "feliciam@gmail.com",
            Bio = "Team Vibes",
            CreatedOn = new DateTime(2023, 5, 9),
            },

            new User
            {
            Id = 3,
            FirstName = "Fletcher",
            LastName = "Moore",
            Email = "fletcherm@gmail.com",
            Bio = "The Young Manager",
            CreatedOn = new DateTime(2023, 12, 12),
            },

            new User
            {
            Id = 4,
            FirstName = "Zach",
            LastName = "Colburn",
            Email = "colburn.zach7@gmail.com",
            Bio = "The Alcohol King",
            CreatedOn = new DateTime(2022, 1, 30),
            },

            new User
            {
            Id = 5,
            FirstName = "Odi",
            LastName = "Joseph",
            Email = "odij@gmail.com",
            Bio = "Backend Genius",
            CreatedOn = new DateTime(2024, 4, 13),
            },
        };
    }
}