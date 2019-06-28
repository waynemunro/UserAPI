using System;
using System.Collections.Generic;
using System.Linq;

namespace UsersAPI.Models
{
    public class DatabaseInitializer
    {

        private readonly Dictionary<int, User> Users = new Dictionary<int, User>();

        public static void Initialize(UsersAPIContext context)
        {
            var initializer = new DatabaseInitializer();

            initializer.SeedEverything(context);
        }

        private void SeedEverything(UsersAPIContext context)
        {

            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            SeedUsers(context);

        }

        private void SeedUsers(UsersAPIContext context)
        {
            var users = new[]
            {
                new User { Id=1, FirstName = "Wayne", LastName = "Munro" },
                new User { Id = 2, FirstName = "Brian", LastName = "Munro" },
                new User { Id = 3, FirstName = "Brent", LastName = "Munro" },
                new User { Id = 4, FirstName = "Leith", LastName = "Munro" }
            };

            context.AddRange(users);
            context.SaveChanges();
        }
    }
}
