using System;
namespace RareGroup_BE.API
{
	public class CategoryAPI
	{
        public static void Map(WebApplication app)
        {
            app.MapGet("/api/categories", (RareGroup_BEDbContext db) => {
                return db.Categories;
            });
        }
	}
}

