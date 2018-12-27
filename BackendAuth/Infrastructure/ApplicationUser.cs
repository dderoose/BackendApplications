using BackendAuth.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace BackendAuth.Infrastructure
{
    //[NotMapped]
    public class ApplicationUser : IdentityUser
    {
        //[NotMapped]
        /*[Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        //[NotMapped]
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }*/

        //[NotMapped]
        [Required]
        public string Password { get; set; }

        //[NotMapped]
        [Required]
        public string ConfirmPassword { get; set; }

        //[NotMapped]
        /*[Required]
        public byte Level { get; set; }*/

        //[NotMapped]
        [Required]
        public DateTime JoinDate { get; set; }

        /*[Required]
        public DateTime LastTimeVisitNotifications { get; set; }

        [NotMapped]
        [Required]
        public int Bedrijf { get; set; }*/


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here

            return userIdentity;
        }
    }
}