using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StadsApp_Services.Models
{
    public class UserModel
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        [Compare("UserName", ErrorMessage = "Deze gebruikersnaam bestaat al")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [Compare("Email", ErrorMessage = "U hebt geen geldig emailadres ingevoerd")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Het {0} moet minstens {2} characters lang zijn.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "het password and confirm password komen niet overeen.")]
        public string ConfirmPassword { get; set; }

        /*[Display(Name = "Bedrijf")]
        public int Bedrijf { get; set; }*/
    }
}