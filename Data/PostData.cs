using RareGroup_BE.Models;

namespace RareGroup.Data
{
    public class PostData
    {
        public static List<Post> Posts = new List<Post>
        {
            new Post
            {
            Id = 1,
            UserId = 1,
            CategoryId = 1,
            Title = "Hello World",
            PublicationDate = new DateTime(2024, 7, 19),
            ImageUrl = "https://static1.squarespace.com/static/5e949a92e17d55230cd1d44f/t/61f35a8548933c4ce4cc0daa/1643338381475/HelloLight_Mac.png?format=1500w",
            Content = "Hello World, how are you today?",
            Approved = true
            },

            new Post
            {
            Id = 2,
            UserId = 2,
            CategoryId = 2,
            Title = "Hello Zach",
            PublicationDate = new DateTime(2024, 8, 5),
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Zach_Galifianakis_2012_%28cropped%29.jpg",
            Content = "Hello Zach, doing well?",
            Approved = false
            },

            new Post
            {
            Id = 3,
            UserId = 3,
            CategoryId = 3,
            Title = "Hello Brit",
            PublicationDate = new DateTime(2024, 6, 23),
            ImageUrl = "https://www.rollingstone.com/wp-content/uploads/2022/02/AdeleBritsRedCarpet-1.jpeg",
            Content = "Hello Brit, how's work?",
            Approved = true
            },

            new Post
            {
            Id = 4,
            UserId = 4,
            CategoryId = 4,
            Title = "Hello Fletcher",
            PublicationDate = new DateTime(2024, 1, 1),
            ImageUrl = "https://www.denofgeek.com/wp-content/uploads/2020/08/chevy-chase-fletch-universal-pictures.jpg?fit=1200%2C680",
            Content = "Hello Fletcher, you are turning 21 this year!",
            Approved = true
            },

            new Post
            {
            Id = 5,
            UserId = 5,
            CategoryId = 5,
            Title = "Hello Lola",
            PublicationDate = new DateTime(2024, 6, 30),
            ImageUrl = "https://i.imgur.com/bS6aYJ5.jpg",
            Content = "Hello Lola, stop pooping on the bed",
            Approved = false
            },

            new Post
            {
            Id = 6,
            UserId = 1,
            CategoryId = 1,
            Title = "Hello World 2",
            PublicationDate = new DateTime(2024, 8, 3),
            ImageUrl = "https://static1.squarespace.com/static/5e949a92e17d55230cd1d44f/t/61f35a8548933c4ce4cc0daa/1643338381475/HelloLight_Mac.png?format=1500w",
            Content = "Hello World, how are you today?",
            Approved = true
            },
        };
    }
}