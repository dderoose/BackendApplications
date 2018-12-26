using BackendAuth.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using StadsApp_Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace BackendAuth
{

    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public AuthContext()
            : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static AuthContext Create()
        {
            return new AuthContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>()
                .ToTable("IdentityUsers");
        }

        public System.Data.Entity.DbSet<BackendAuth.Models.Break> Breaks { get; set; }
        
        public System.Data.Entity.DbSet<BackendAuth.Models.Frame> Frames { get; set; }

        public System.Data.Entity.DbSet<BackendAuth.Models.Match> Matches { get; set; }

        //object placeHolderVariable;
        /*
public System.Data.Entity.DbSet<StadsApp_Services.Models.Gebruikers> Gebruikers { get; set; }*/
    }
}