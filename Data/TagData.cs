using RareGroup_BE.Models;

namespace RareGroup_BE.Data
{
    public class TagData
    {
        public static List<Tag> Tags = new List<Tag>
        {
            new Tag
            {
            Id = 1,
            Label = "#photooftheday"
            },

            new Tag
            {
            Id = 2,
            Label = "#likeforlike"
            },

            new Tag
            {
            Id = 3,
            Label = "#food"
            },

            new Tag
            {
            Id = 4,
            Label = "#music"
            },

            new Tag
            {
            Id = 5,
            Label = "#amazing"
            },
        };
    }
}