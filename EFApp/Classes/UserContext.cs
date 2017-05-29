using System.Data.Entity;

namespace EFApp.Classes
{
    class UserContext : DbContext
    {
        public UserContext()
             : base("DbConnection")
        { }


        public DbSet<User> Users { get; set; }
    }
}
