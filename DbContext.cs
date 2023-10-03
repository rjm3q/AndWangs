using Microsoft.EntityFrameworkCore;
using AndWangs.Models;
public class AndWangsDbContext : DbContext
    {
    public DbSet<UserProfile> UserProfiles { get; set; }

    public AndWangsDbContext(DbContextOptions<AndWangsDbContext>
        {
    }
    
}
