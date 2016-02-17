using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Api.DAL;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using Api.DAL.DTO;

namespace Api.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser
    // class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        static ApplicationDbContext()
        {
            Database.SetInitializer(new MySqlInitializer());
        }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Market> Markets { get; set; }
        public DbSet<MarketUser> MarketUsers { get; set; }
        public DbSet<MarketUserIntegration> MarketUserIntegrations { get; set; }
        public DbSet<IntegrationDetail> IntegrationDetails { get; set; }
        public DbSet<Integration> Integrations { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //one-to-many 
            modelBuilder.Entity<MarketUser>()
                        .HasRequired<Market>(m => m.Market)
                        .WithMany(m => m.MarketUsers)
                        .HasForeignKey(m => m.MarketId);

            modelBuilder.Entity<MarketUserIntegration>()
                     .HasRequired<MarketUser>(m => m.MarketUser)
                     .WithMany(m => m.MarketUserIntegrations)
                     .HasForeignKey(m => m.MarketUserId);

            modelBuilder.Entity<MarketUserIntegration>()
                  .HasRequired<Integration>(m => m.Integration)
                  .WithMany(m => m.MarketUserIntegrations)
                  .HasForeignKey(m => m.IntegrationId);

            modelBuilder.Entity<IntegrationDetail>()
                .HasRequired<Integration>(m => m.Integration)
                .WithMany(m => m.IntegrationDetails)
                .HasForeignKey(m => m.IntegrationId);

        }

    }

}