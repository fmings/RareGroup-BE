using System;
namespace RareGroup_BE.API
{
	public class UserAPI
	{
        public static void Map(WebApplication app)
        {
            // Check User
            app.MapPost("/checkuser", (RareGroup_BEDbContext db, string uid) =>
            {

                try
                {
                    var user = db.Users.SingleOrDefault(u => u.Uid == uid);

                    if (user != null)
                    {
                        return Results.Ok(user);
                    }
                    else
                    {
                        return Results.Json(new { error = "User not found" }, statusCode: 404);
                    }
                }
                catch (InvalidOperationException)
                {
                    return Results.NotFound("This user does not exist!");
                }
                catch (ArgumentNullException)
                {
                    return Results.NotFound();
                }

            });

            app.MapGet("/api/user/{userId}", (RareGroup_BEDbContext db, int userId) =>
            {
                if (userId == null)
                {
                    return Results.NotFound("The userId does not exist");
                }

                return Results.Ok(db.Users.SingleOrDefault(user => user.Id == userId));
            });

            app.MapGet("/api/users", (RareGroup_BEDbContext db) =>
            {
                return db.Users;
            });
        }
	}
}

