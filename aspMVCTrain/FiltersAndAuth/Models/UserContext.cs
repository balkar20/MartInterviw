﻿using System.Data.Entity;

namespace FiltersAndAuth.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
    }

}