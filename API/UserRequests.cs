using Bangazon.Models;
using Bangazon.DTOs;

namespace Bangazon.API
{
    public class UserRequests
    {
        public static void Map(WebApplication app)
        {
            // get users
            app.MapGet("/users", (BangazonDbContext db) =>
            {
                return db.Users.ToList();
            });

            // get user by id
            app.MapGet("/users/{id}", (BangazonDbContext db, int id) =>
            {
                return db.Users.SingleOrDefault(u => u.Id == id);
            });

            // login user
            app.MapPost("/checkuser", (BangazonDbContext db, UserAuthDTO userAuthDTO) =>
            {
                var userUid = db.Users.SingleOrDefault(u => u.Uid == userAuthDTO.Uid);

                if (userUid == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(userUid);
                }
            });

            // register user
            app.MapPost("/register", (BangazonDbContext db, User user) =>
            {
                db.Users.Add(user);
                db.SaveChanges();
                return Results.Created($"/user/{user.Id}", user);
            });
        }
    }
}