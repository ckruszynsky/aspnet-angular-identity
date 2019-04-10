namespace AuthServer.Infrastructure.Data.Identity
{
    using ASPNETCore.Identity;
    using ASPNETCore.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class AppIdentityDbContext : IdentityDbContext<AppUser> {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            //customize the ASP.NET identity model and override the defaults
            //if needed. For example, you can rename the ASP.NET Identity table names and more.
            //Add your customizations after calling base.OnModelCreating(builder)
            modelBuilder.Entity<IdentityRole>()
                .HasData(new IdentityRole{ Name = Constants.Roles.Consumer, NormalizedName = Constants.Roles.Consumer.ToUpper()});
        }
    }
}