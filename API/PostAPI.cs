using System;
namespace RareGroup_BE.API
{
	public class PostAPI
	{
        public static void Map(WebApplication app)
        {
            // Get User's Posts
			app.MapGet("/api/user/{userId}/posts", (RareGroup_BEDbContext db, int userId) =>
			{
                if (userId == null)
                {
                    return Results.NotFound("The userId does not exist");
                }

                return Results.Ok(db.Users.Select(user => new
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Bio = user.Bio,
                    CreatedOn = user.CreatedOn,
                    IsStaff = user.IsStaff,
                    Uid = user.Uid,
                    Active = user.Active,
                    Posts = user.Posts

                }).SingleOrDefault(user => user.Id == userId));
            });
		}
	}
}

