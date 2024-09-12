using Microsoft.EntityFrameworkCore;
using RareGroup_BE.Models;
using System;
namespace RareGroup_BE.API
{
	public class PostAPI
	{
        public static void Map(WebApplication app)
        {
			//GET ALL POSTS
			app.MapGet("/api/posts", (RareGroup_BEDbContext db) =>
			{
				return db.Posts.ToList();
			});

			app.MapGet("/api/post/{postId}", async (RareGroup_BEDbContext db, int id) =>
			{
                Post post = await db.Posts
                .Include(p => p.Categories)
                .Include(p => p.Tags)
                .FirstOrDefaultAsync(p => p.Id == id);

                if (post == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(post);

            });
		}
	}
}

