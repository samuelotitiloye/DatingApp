using API.Entities;
using Microsoft.EntityFrameworkCore;


namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

         public DbSet<AppUser> Users { get; set; }
    }
}

// in order to use DBContext class, we need to tell our class what namespace it's in.
// our DataContext class lives in namespace API.Data, which relates to the folder in which we created the class in.