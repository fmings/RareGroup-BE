using RareGroup_BE;
using RareGroup_BE.Models;
namespace RareGroup_BE
{
    public class CategoryData
    {
        public static List<Category> Categories = new List<Category>
        {
            new Category
            {
                 Id = 1,
                 Label = "Comedy"
            },

            new Category
            {
            Id = 2,
            Label = "Shopping"
            },

            new Category
            { 
            Id = 3,
            Label = "Music"
            },
            
            new Category
            {
            Id = 4,
            Label = "Sports"
            },

            new Category
            {
            Id = 5,
            Label = "Motivational"
            },
        };
    }
}