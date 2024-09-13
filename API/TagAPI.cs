using System;
using Microsoft.EntityFrameworkCore;
using RareGroup_BE.Models;

namespace RareGroup_BE.API
{
	public class TagAPI
	{
        public static void Map(WebApplication app)
        {
            // Get All Tags
            app.MapGet("/api/tags", (RareGroup_BEDbContext db) =>
            {
                return db.Tags;
            });

            // Add A Tag to A Post
            app.MapPost("/api/post/{postId}/tag/{tagId}", (RareGroup_BEDbContext db, int postId, int tagId) =>
            {
                Post post = db.Posts.Include(p => p.Tags).FirstOrDefault(p => p.Id == postId);

                Tag tagToAdd = db.Tags.SingleOrDefault(t => t.Id == tagId);

                post.Tags.Add(tagToAdd);
                db.SaveChanges();

                return Results.Created($"/api/post/{post.Id}/tag/{tagToAdd.Id}", tagToAdd);
            });

            // Delete A Tag From a Post
            app.MapDelete("/api/post/{postId}/tag/{tagId}", (RareGroup_BEDbContext db, int postId, int tagId) =>
            {
                Post post = db.Posts.Include(p => p.Tags).FirstOrDefault(p => p.Id == postId);


                if (post == null)
                {
                    return Results.NotFound("Post not found.");
                }

                Tag tagToDelete = db.Tags.SingleOrDefault(t => t.Id == tagId);

                if (tagToDelete == null)
                {
                    return Results.NotFound("Tag not found on Post.");
                }

                post.Tags.Remove(tagToDelete);
                db.SaveChanges();

                return Results.Ok($"Tag {tagId} has been deleted");
            });
        }
	}
}

