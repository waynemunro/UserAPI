using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UsersAPI.Models
{
    public class UsersAPIContext : DbContext
    {
        public UsersAPIContext (DbContextOptions<UsersAPIContext> options)
            : base(options)
        {
        }

        public DbSet<UsersAPI.Models.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }


    }
}
