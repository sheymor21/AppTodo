using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DBcontext : DbContext
    {
        public DbSet<Users> users { get; set; }

        // The following configures EF to create a Sqlite database file as `C:\blogging.db`.
        // For Mac or Linux, change this to `/tmp/blogging.db` or any other absolute path.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=Users.db");
    }
}
