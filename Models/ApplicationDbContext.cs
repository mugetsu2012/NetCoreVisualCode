using Microsoft.EntityFrameworkCore;

namespace NetCoreVisualCode.Models {

    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./PartyInvites.db");
        }

        public DbSet<GuestResponse> Invites {get; set;}
    }
}