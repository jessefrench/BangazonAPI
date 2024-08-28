using Bangazon.Models;

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
                return db.Users.SingleOrDefault(user => user.Id == id);
            });

            // check user
            app.MapGet("/users/check/{uid}", (BangazonDbContext db, string uid) =>
            {
                var user = db.Users.Where(user => user.FirebaseKey == uid).ToList();

                if (user == null)
                {
                    return Results.NotFound("User not registered");
                }

                return Results.Ok(user);
            });

            // add user
            app.MapPost("/users/register", (BangazonDbContext db, User user) =>
            {
                db.Users.Add(user);
                db.SaveChanges();
                return Results.Created($"/user/{user.Id}", user);
            });

            // update user
            app.MapPut("/users/{id}", (BangazonDbContext db, int id, User user) =>
            {
                User userToUpdate = db.Users.SingleOrDefault(user => user.Id == id);

                if (userToUpdate == null)
                {
                    return Results.NotFound("User Id not found");
                }

                userToUpdate.FirebaseKey = user.FirebaseKey;
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.Email = user.Email;
                userToUpdate.Address = user.Address;
                userToUpdate.City = user.City;
                userToUpdate.State = user.State;
                userToUpdate.Zip = user.Zip;

                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}