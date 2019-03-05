using System.Data.Entity;

namespace IdentityOwin.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }

    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Roles.Add(new Role { Id = 1, Name = "admin" });
            db.Roles.Add(new Role { Id = 2, Name = "user" });
            db.Users.Add(new User
            {
                Email = "alice@gmail.com",
                Password = "123456",
                RoleId = 1
            });
            db.Users.Add(new User
            {
                Email = "tom@gmail.com",
                Password = "123456",
                RoleId = 2
            });
            base.Seed(db);
        }
    }
}