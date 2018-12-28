using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAuth.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Paswoord { get; set; }
        public string PaswoordConfirm { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Match> Matchen { get; set; }
        public virtual ICollection<Break> Breaks { get; set; }
    }
}
