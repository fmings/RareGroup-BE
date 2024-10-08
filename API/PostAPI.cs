﻿using Microsoft.EntityFrameworkCore;
using RareGroup_BE.Models;
using System;

namespace RareGroup_BE.API
{
	public class PostAPI
	{
        public static void Map(WebApplication app)
        {
			// GET all Posts
			app.MapGet("/api/posts", (RareGroup_BEDbContext db) =>
			{
				return db.Posts.Select(p => new
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    CategoryId = p.CategoryId,
                    Title = p.Title,
                    PublicationDate = p.PublicationDate,
                    ImageUrl = p.ImageUrl,
                    Content = p.Content,
                    Approved = p.Approved,
                    Categories = p.Categories,
                    User = p.User,
                    Tags = p.Tags,
                });
			});

            // GET Post by ID
			app.MapGet("/api/post/{postId}", (RareGroup_BEDbContext db, int postId) =>
			{
                Post post = db.Posts
                .Include(p => p.Categories)
                .Include(p => p.Tags)
                .Single(p => p.Id == postId);

                if (post == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(post);

            });

            // POST new Post
            app.MapPost("/api/post", (RareGroup_BEDbContext db, Post post) =>
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return Results.Created($"/api/post/{post.Id}", post);
            });

            // DELETE Post
            app.MapDelete("/posts/{id}", (RareGroup_BEDbContext db, int id) =>
            {
                Post post = db.Posts.FirstOrDefault(p => p.Id == id);

                if (post == null)
                {
                    return Results.NotFound();
                }

                db.Posts.Remove(post);
                db.SaveChanges();

                return Results.NoContent();
            });

            // Edit Post
            app.MapPut("/post/{postId}", (RareGroup_BEDbContext db, int postId, Post updatedPost) =>
            {
                Post postToUpdate = db.Posts.SingleOrDefault(p => p.Id == postId);

                if (postToUpdate == null)
                {
                    return Results.NotFound();
                }
                postToUpdate.Title = updatedPost.Title;
                postToUpdate.PublicationDate = updatedPost.PublicationDate;
                postToUpdate.ImageUrl = updatedPost.ImageUrl;
                postToUpdate.Content = updatedPost.Content;
                postToUpdate.Approved = updatedPost.Approved;
                postToUpdate.UserId = updatedPost.UserId;
                postToUpdate.CategoryId = updatedPost.CategoryId;

                db.SaveChanges();
                return Results.Ok(postToUpdate);
            });
        
            // Get User's Posts
            app.MapGet("/api/user/{userId}/posts", (RareGroup_BEDbContext db, int userId) =>
            {
                if (userId == null)
                {
                    return Results.NotFound("The userId does not exist");
                }

                return Results.Ok(db.Posts.Where(post => post.UserId == userId).Select(p => new
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    CategoryId = p.CategoryId,
                    Title = p.Title,
                    PublicationDate = p.PublicationDate,
                    ImageUrl = p.ImageUrl,
                    Content = p.Content,
                    Approved = p.Approved,
                    Categories = p.Categories,
                    User = p.User,
                    Tags = p.Tags,

                }).ToList());
            });

        }
	}
}

