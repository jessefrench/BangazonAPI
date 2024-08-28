using Bangazon.Models;
using Bangazon.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.API
{
    public class UserRequests
    {
        public static void Map(WebApplication app)
        {
            // check user
            app.MapPost("/checkuser", (BangazonDbContext db, UserAuthDTO userAuthDTO) =>
            {
                var userUid = db.Users.SingleOrDefault(user => user.FirebaseKey == userAuthDTO.FirebaseKey);

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
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return Results.Created($"/users/{user.Id}", user);
                }
                catch (DbUpdateException)
                {
                    return Results.BadRequest();
                }
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

            // update user
            app.MapPut("/users/{id}", (BangazonDbContext db, int id, User user) =>
            {
                User userToUpdate = db.Users.SingleOrDefault(user => user.Id == id);

                if (userToUpdate == null)
                {
                    return Results.NotFound();
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