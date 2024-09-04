using Bangazon.Models;

namespace Bangazon.API
{
    public class UserRequests
    {
        public static void Map(WebApplication app)
        {
            // check user
            app.MapGet("/checkuser/{uid}", (BangazonDbContext db, string uid) =>
            {
                var userUid = db.Users.Where(user => user.Uid == uid).FirstOrDefault();
                if (userUid == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(userUid);
                }
            });

            // add user
            app.MapPost("/register", (BangazonDbContext db, User user) =>
            {
                db.Users.Add(user);
                db.SaveChanges();
                return Results.Created($"/users/{user.Id}", user);
            });

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

            // get user details
            app.MapGet("/users/details/{uid}", (BangazonDbContext db, string uid) =>
            {

                User user = db.Users.SingleOrDefault(u => u.Uid == uid);
                if (user == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(user);
            });

            // update user
            app.MapPatch("/users/{id}", (BangazonDbContext db, int id, User user) =>
            {
                User userToUpdate = db.Users.SingleOrDefault(user => user.Id == id);
                if (userToUpdate == null)
                {
                    return Results.NotFound();
                }
                userToUpdate.Uid = user.Uid;
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.Email = user.Email;
                userToUpdate.Address = user.Address;
                userToUpdate.City = user.City;
                userToUpdate.State = user.State;
                userToUpdate.Zip = user.Zip;
                userToUpdate.Seller = user.Seller;
                db.SaveChanges();
                return Results.Ok(userToUpdate);
            });

            // switch user to seller
            app.MapPatch("users/sell/{uid}", async (BangazonDbContext db, string uid) =>
            {
                User user = db.Users.SingleOrDefault(user => user.Uid == uid);
                if (user == null)
                {
                    return Results.NotFound();
                }
                user.Seller = true;
                await db.SaveChangesAsync();
                return Results.Ok(user);
            });
        }
    }
}